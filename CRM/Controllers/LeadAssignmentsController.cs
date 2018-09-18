﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.Enum;
using CRM.Helpers;
using CRM.Models;
using CRM.Models.ViewModels;
using CRM.Repositories;
using CRM.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CRM.Controllers
{
    public class LeadAssignmentsController : BaseController
    {
        private IUnitOfWork _uow;
        private ILeadRepository _leadRepo;
        private ILeadAssignmentRepository _leadAssRepo;
        private IEmailSender _emailSender;

        public LeadAssignmentsController(IUnitOfWork unitOfWork, IEmailSender emailSender)
        {
            _uow = unitOfWork;
            _leadAssRepo = unitOfWork.LeadAssignmentRepository;
            _leadRepo = unitOfWork.LeadRepository;

            _emailSender = emailSender;
        }

        [HttpGet]
        public JsonResult Get()
        {
            return Json(_leadAssRepo.Get());
        }

        [HttpGet]
        public object GetByLead(DataSourceLoadOptions loadOptions, Guid id)
        {
            var leadAssignments = _leadAssRepo.GetByLead(id);

            return DataSourceLoader.Load(this.GetLeadAssignmentViewModels(leadAssignments), loadOptions);
        }

        [HttpGet]
        public object GetByPartner(DataSourceLoadOptions loadOptions, Guid id)
        {
            var leadAssignments = _leadAssRepo.GetByPartner(id);
            
            return DataSourceLoader.Load(this.GetLeadAssignmentViewModels(leadAssignments), loadOptions);
        }

        [HttpDelete]
        public void Delete(int key)
        {
            var model = _leadAssRepo.Get(key);

            _leadAssRepo.Remove(model);
            _uow.Commit();
        }

        [HttpPost]
        public JsonResult AjaxPostToAssignPartners([FromBody]LeadAssignmentSelectedPartnerViewModel data)
        {
            _leadAssRepo.AddByViewModel(data);
            _leadRepo.SetLeadAssignedState(data.LeadId);
            
            if (_uow.Commit())
            {
                this.SendAssignmentEmailToPartners(data.PartnerBranchIds);
                return Json(Ok());
            }
            else
            {
                return Json(StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status500InternalServerError));
            }
        }

        [HttpPut]
        public JsonResult Accept([FromBody]LeadAssignmentResponseVM data) // can process "int id" too
        {
            _leadAssRepo.AcceptAssignment(data);

            if (_uow.Commit())
            {
                return Json(Ok(data.LeadId));
            }
            else
            {
                return Json(StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status500InternalServerError));
            }
        }

        [HttpPut]
        public JsonResult Reject([FromBody]LeadAssignmentResponseVM data)
        {
            _leadAssRepo.RejectAssignment(data);

            if (_uow.Commit())
            {
                return Json(Ok(data.LeadId));
            }
            else
            {
                return Json(StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status500InternalServerError));
            }
        }

        protected void SendAssignmentEmailToPartners(List<Guid> partnerBranchIds)
        {
            _emailSender.SendEmailAsync("thawatchai.j14@gmail.com", "Lead assignment from ComparisonAdvantage", "{lead_type} lead is assigned to you guys.");
        }

        protected LeadAssignmentViewModel GetLeadAssignmentViewModel(LeadAssignment item)
        {
            var itemVM = new LeadAssignmentViewModel();
            itemVM.Id = item.Id;
            itemVM.LeadId = item.LeadId;

            if (item.Lead != null)
            {
                itemVM.LeadDetails = item.Lead.Details;

                if (item.Lead.LeadType != null)
                {
                    itemVM.LeadTypeName = item.Lead.LeadType.Name;
                    itemVM.LeadTypeImage = item.Lead.LeadType.Image;
                }

                if (item.Lead.Customer != null)
                {
                    itemVM.CustomerId = item.Lead.Customer.Id;
                    itemVM.CustomerUnique = String.Format("{0} ({1})", item.Lead.Customer.ContactName, item.Lead.Customer.EMail);

                    itemVM.CustomerName = item.Lead.Customer.ContactName;
                    itemVM.CustomerBusinessName = item.Lead.Customer.BusinessName;
                    itemVM.CustomerEMail = item.Lead.Customer.EMail;
                    itemVM.CustomerContactNumber = item.Lead.Customer.ContactNumber;
                    itemVM.CustomerStreetAddress = item.Lead.Customer.Address.StreetAddress;
                    itemVM.CustomerSuburb = item.Lead.Customer.Address.Suburb;
                    itemVM.CustomerState = item.Lead.Customer.Address.State;
                    itemVM.CustomerPostCode = item.Lead.Customer.Address.PostCode;
                    itemVM.CustomerAddress = AddressHelper.MergeAddress(itemVM.CustomerStreetAddress, itemVM.CustomerSuburb, itemVM.CustomerState, itemVM.CustomerPostCode);

                    itemVM.CustomerDetails = String.Format("Business: <b>{0}</b><br>Tel: <b>{1}</b><br>Address: <b>{2}</b>", itemVM.CustomerBusinessName, itemVM.CustomerContactNumber, itemVM.CustomerAddress);
                }
            }

            itemVM.PartnerId = item.PartnerBranch.Partner.Id;
            itemVM.PartnerName = item.PartnerBranch.Partner.Name;
            itemVM.PartnerLogo = ImageHelper.PATH_PARTNER + item.PartnerBranch.Partner.Logo;

            itemVM.PartnerBranchId = item.PartnerBranch.Id;
            itemVM.PartnerBranchStreetAddress = item.PartnerBranch.Address.StreetAddress;
            itemVM.PartnerBranchSuburb = item.PartnerBranch.Address.Suburb;
            itemVM.PartnerBranchState = item.PartnerBranch.Address.State;
            itemVM.PartnerBranchPostCode = item.PartnerBranch.Address.PostCode;
            itemVM.PartnerBranchAddress = AddressHelper.MergeAddress(itemVM.PartnerBranchStreetAddress, itemVM.PartnerBranchSuburb, itemVM.PartnerBranchState, itemVM.PartnerBranchPostCode);

            // Current status
            var currentStatus = item.LeadAssignmentStates.OrderByDescending(o => o.ActionTimestamp).FirstOrDefault();
            itemVM.StatusId = currentStatus.State.Id;
            itemVM.StatusName = currentStatus.State.Name;
            itemVM.StatusTag = StatusHelper.GetHtmlBadge(currentStatus.State.Id, currentStatus.State.Name);

            // Actions of current status
            var actions = currentStatus.State.StateActions.Select(s => new ActionLeadAssignmentVM
            {
                LeadId = itemVM.LeadId,
                PartnerBranchId = itemVM.PartnerBranchId,
                LeadAssignmentId = itemVM.Id,
                ControllerName = s.Action.ControllerName,
                ActionName = s.Action.ActionName,
                ActionTarget = s.Action.ActionTarget,
                RequestType = s.Action.RequestType,
                DisplayName = s.Action.DisplayName,
                Icon = s.Action.Icon,
                NextStateId = s.Action.NextStateId
            }).ToList();

            itemVM.Actions = actions;

            var histories = item.LeadAssignmentStates
                //.Where(w => w.StateId != currentStatus.StateId) // *show all
                .Select(s => HistoryHelper.GetHtmlHistoryLine(s.ActionTimestamp, s.Action.ToLower(), s.Actor));

            itemVM.History = HistoryHelper.GetHtmlHistoryTag(histories.ToList());

            return itemVM;
        }

        protected List<LeadAssignmentViewModel> GetLeadAssignmentViewModels(IEnumerable<LeadAssignment> leadAssignments)
        {
            List<LeadAssignmentViewModel> leadVMs = new List<LeadAssignmentViewModel>();
            
            foreach (var item in leadAssignments)
            {
                leadVMs.Add(this.GetLeadAssignmentViewModel(item));
            }

            return leadVMs;
        }
    }
}