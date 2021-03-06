﻿using CRM.Data;
using CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Repositories
{
    public class ActionRepository
    {
        private ApplicationDbContext _context;

        public ActionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Models.Action> GetGroupActions()
        {
            return _context.Actions.Where(w => w.IsGroupAction);
        }

        public IEnumerable<ActionPermission> GetActionPermissions()
        {
            return _context.ActionPermissions;
        }

        public Models.Action GetAction(string actionId)
        {
            return _context.Actions.Where(w => w.Id == actionId).FirstOrDefault();
        }

        public Models.State GetState(string stateId)
        {
            return _context.States.Where(w => w.Id == stateId).FirstOrDefault();
        }

        public ActionPermission GetActionPermissions(string actionId, string userRoleName)
        {
            return _context.ActionPermissions.Where(w => w.ActionId == actionId && w.ApplicationRoleName == userRoleName).FirstOrDefault();
        }
    }
}
