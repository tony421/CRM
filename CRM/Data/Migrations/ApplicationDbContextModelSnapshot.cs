﻿// <auto-generated />
using System;
using CRM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRM.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRM.Models.Action", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5);

                    b.Property<string>("ActionName");

                    b.Property<string>("ActionTarget");

                    b.Property<string>("ControllerName");

                    b.Property<string>("DisplayName");

                    b.Property<string>("GroupActionDisplayName");

                    b.Property<string>("Icon");

                    b.Property<bool>("IsGroupAction");

                    b.Property<string>("NextStateId");

                    b.Property<string>("RequestType");

                    b.HasKey("Id");

                    b.HasIndex("NextStateId");

                    b.ToTable("Actions");

                    b.HasData(
                        new { Id = "AL0", ActionName = "SendLeadMessage", ActionTarget = "Message", ControllerName = "Message", DisplayName = "Send message", GroupActionDisplayName = "Message customers", Icon = "batch-icon batch-icon-envelope", IsGroupAction = true, NextStateId = "S0", RequestType = "Post" },
                        new { Id = "AL1", ActionName = "SendLeadRequestInfo", ActionTarget = "Message", ControllerName = "Message", DisplayName = "Request Info", GroupActionDisplayName = "Request info", Icon = "batch-icon batch-icon-envelope", IsGroupAction = true, NextStateId = "SL4", RequestType = "Post" },
                        new { Id = "AL2", ActionName = "Assignments", ActionTarget = "Window", ControllerName = "Leads", DisplayName = "Assign partners", Icon = "batch-icon batch-icon-user-alt-2", IsGroupAction = false, NextStateId = "SL2", RequestType = "Get" },
                        new { Id = "AL3", ActionName = "Assignments", ActionTarget = "Window", ControllerName = "Leads", DisplayName = "Re-assign partners", Icon = "batch-icon batch-icon-user-alt-2", IsGroupAction = false, NextStateId = "SL3", RequestType = "Get" },
                        new { Id = "AL4", ActionName = "InvoiceByLeads", ActionTarget = "Window", ControllerName = "Reports", DisplayName = "Get invoices", GroupActionDisplayName = "Get invoices", Icon = "fa fa-dollar", IsGroupAction = true, NextStateId = "SLA4", RequestType = "Get" },
                        new { Id = "ALA0", ActionName = "SendAssignmentMessage", ActionTarget = "Message", ControllerName = "Message", DisplayName = "Send message", GroupActionDisplayName = "Message partners", Icon = "batch-icon batch-icon-envelope", IsGroupAction = true, NextStateId = "S0", RequestType = "Post" },
                        new { Id = "ALA1", ActionName = "CommentLead", ActionTarget = "Rating", ControllerName = "LeadAssignments", DisplayName = "Comment lead", Icon = "batch-icon batch-icon-speech-bubble-left-tip-text", IsGroupAction = false, NextStateId = "S0", RequestType = "Post" },
                        new { Id = "ALA2", ActionName = "Accept", ActionTarget = "Ajax", ControllerName = "LeadAssignments", DisplayName = "Accept lead", Icon = "batch-icon batch-icon-tick", IsGroupAction = false, NextStateId = "SLA2", RequestType = "Put" },
                        new { Id = "ALA3", ActionName = "Reject", ActionTarget = "Ajax", ControllerName = "LeadAssignments", DisplayName = "Reject lead", Icon = "batch-icon batch-icon-cross", IsGroupAction = false, NextStateId = "SLA3", RequestType = "Put" },
                        new { Id = "ALA4", ActionName = "InvoiceByAssignments", ActionTarget = "Window", ControllerName = "Reports", DisplayName = "Get invoice", Icon = "fa fa-dollar", IsGroupAction = false, NextStateId = "SLA4", RequestType = "Get" },
                        new { Id = "ALA5", ActionName = "InvoiceByAssignments", ActionTarget = "Window", ControllerName = "Reports", DisplayName = "Get invoice", Icon = "fa fa-dollar", IsGroupAction = false, NextStateId = "SLA5", RequestType = "Get" }
                    );
                });

            modelBuilder.Entity("CRM.Models.ActionPermission", b =>
                {
                    b.Property<string>("ActionId");

                    b.Property<string>("ApplicationRoleName");

                    b.HasKey("ActionId", "ApplicationRoleName");

                    b.ToTable("ActionPermissions");

                    b.HasData(
                        new { ActionId = "AL0", ApplicationRoleName = "Admin" },
                        new { ActionId = "AL0", ApplicationRoleName = "Manager" },
                        new { ActionId = "AL0", ApplicationRoleName = "Agent" },
                        new { ActionId = "AL1", ApplicationRoleName = "Admin" },
                        new { ActionId = "AL1", ApplicationRoleName = "Manager" },
                        new { ActionId = "AL1", ApplicationRoleName = "Agent" },
                        new { ActionId = "AL2", ApplicationRoleName = "Admin" },
                        new { ActionId = "AL2", ApplicationRoleName = "Manager" },
                        new { ActionId = "AL2", ApplicationRoleName = "Agent" },
                        new { ActionId = "AL3", ApplicationRoleName = "Admin" },
                        new { ActionId = "AL3", ApplicationRoleName = "Manager" },
                        new { ActionId = "AL3", ApplicationRoleName = "Agent" },
                        new { ActionId = "ALA0", ApplicationRoleName = "Admin" },
                        new { ActionId = "ALA0", ApplicationRoleName = "Manager" },
                        new { ActionId = "ALA0", ApplicationRoleName = "Agent" },
                        new { ActionId = "ALA0", ApplicationRoleName = "Partner" },
                        new { ActionId = "ALA1", ApplicationRoleName = "Partner" },
                        new { ActionId = "ALA2", ApplicationRoleName = "Admin" },
                        new { ActionId = "ALA2", ApplicationRoleName = "Manager" },
                        new { ActionId = "ALA2", ApplicationRoleName = "Agent" },
                        new { ActionId = "ALA2", ApplicationRoleName = "Partner" },
                        new { ActionId = "ALA3", ApplicationRoleName = "Admin" },
                        new { ActionId = "ALA3", ApplicationRoleName = "Manager" },
                        new { ActionId = "ALA3", ApplicationRoleName = "Agent" },
                        new { ActionId = "ALA3", ApplicationRoleName = "Partner" },
                        new { ActionId = "ALA4", ApplicationRoleName = "Admin" },
                        new { ActionId = "ALA4", ApplicationRoleName = "Manager" },
                        new { ActionId = "ALA4", ApplicationRoleName = "Agent" },
                        new { ActionId = "ALA5", ApplicationRoleName = "Admin" },
                        new { ActionId = "ALA5", ApplicationRoleName = "Manager" },
                        new { ActionId = "ALA5", ApplicationRoleName = "Agent" }
                    );
                });

            modelBuilder.Entity("CRM.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PostCode")
                        .HasMaxLength(4);

                    b.Property<string>("State")
                        .HasMaxLength(4);

                    b.Property<string>("StreetAddress")
                        .HasMaxLength(256);

                    b.Property<string>("Suburb")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CRM.Models.Agent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("ContactName")
                        .IsRequired();

                    b.Property<string>("ContactNumber")
                        .IsRequired();

                    b.Property<string>("EMail")
                        .IsRequired();

                    b.Property<int>("OfficeId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique()
                        .HasFilter("[ApplicationUserId] IS NOT NULL");

                    b.HasIndex("OfficeId");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("CRM.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("CRM.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CRM.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ABN")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<double>("GST");

                    b.Property<string>("Logo");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Company");

                    b.HasData(
                        new { Id = 1, ABN = "65 626 309 073", Email = "leads@comparisonadvantage.com.au", GST = 0.1, Logo = "logo-dark.png", Name = "Comparison Advantage" }
                    );
                });

            modelBuilder.Entity("CRM.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("BusinessName")
                        .HasMaxLength(256);

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("ContactNumber")
                        .IsRequired();

                    b.Property<string>("EMail")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CRM.Models.Invoice", b =>
                {
                    b.Property<int>("No")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<DateTime>("DueDate");

                    b.Property<double>("GST");

                    b.Property<double>("SubTotal");

                    b.Property<double>("Total");

                    b.HasKey("No");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("CRM.Models.InvoiceItem", b =>
                {
                    b.Property<int>("InvoiceNo");

                    b.Property<int>("LeadAssignmentId");

                    b.Property<bool>("Reinvoiced");

                    b.HasKey("InvoiceNo", "LeadAssignmentId");

                    b.HasIndex("LeadAssignmentId");

                    b.ToTable("InvoiceItems");
                });

            modelBuilder.Entity("CRM.Models.Lead", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CustomerId");

                    b.Property<string>("Details")
                        .IsRequired();

                    b.Property<int>("LeadTypeId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LeadTypeId");

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("CRM.Models.LeadAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<string>("CommentedBy");

                    b.Property<DateTime>("CommentedOn");

                    b.Property<Guid>("LeadId");

                    b.Property<Guid>("PartnerBranchId");

                    b.Property<int>("Rate");

                    b.HasKey("Id");

                    b.HasIndex("LeadId");

                    b.HasIndex("PartnerBranchId");

                    b.ToTable("LeadAssignments");
                });

            modelBuilder.Entity("CRM.Models.LeadAssignmentState", b =>
                {
                    b.Property<string>("StateId");

                    b.Property<int>("LeadAssignmentId");

                    b.Property<DateTime>("ActionTimestamp");

                    b.Property<string>("Action");

                    b.Property<string>("Actor");

                    b.HasKey("StateId", "LeadAssignmentId", "ActionTimestamp");

                    b.HasIndex("LeadAssignmentId");

                    b.ToTable("LeadAssignmentStates");
                });

            modelBuilder.Entity("CRM.Models.LeadState", b =>
                {
                    b.Property<string>("StateId");

                    b.Property<Guid>("LeadId");

                    b.Property<DateTime>("ActionTimestamp");

                    b.Property<string>("Action");

                    b.Property<string>("Actor");

                    b.HasKey("StateId", "LeadId", "ActionTimestamp");

                    b.HasIndex("LeadId");

                    b.ToTable("LeadStates");
                });

            modelBuilder.Entity("CRM.Models.LeadType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.ToTable("LeadTypes");
                });

            modelBuilder.Entity("CRM.Models.MessageTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MessageBody")
                        .IsRequired();

                    b.Property<string>("MessageSubject")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("MessageTemplates");
                });

            modelBuilder.Entity("CRM.Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<int>("CompanyId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("CompanyId");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("CRM.Models.Partner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Logo");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("CRM.Models.PartnerBranch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<Guid>("PartnerId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("PartnerId");

                    b.ToTable("PartnerBranches");
                });

            modelBuilder.Entity("CRM.Models.PartnerService", b =>
                {
                    b.Property<Guid>("PartnerId");

                    b.Property<int>("LeadTypeId");

                    b.HasKey("PartnerId", "LeadTypeId");

                    b.HasIndex("LeadTypeId");

                    b.ToTable("PartnerServices");
                });

            modelBuilder.Entity("CRM.Models.SalesPerson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<Guid>("BranchId");

                    b.Property<string>("ContactName")
                        .IsRequired();

                    b.Property<string>("ContactNumber")
                        .IsRequired();

                    b.Property<string>("EMail")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique()
                        .HasFilter("[ApplicationUserId] IS NOT NULL");

                    b.HasIndex("BranchId");

                    b.ToTable("SalesPeople");
                });

            modelBuilder.Entity("CRM.Models.State", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Owner")
                        .IsRequired();

                    b.Property<bool>("Repeatable");

                    b.Property<int>("Seq");

                    b.HasKey("Id");

                    b.ToTable("States");

                    b.HasData(
                        new { Id = "S0", Name = "Unknown", Owner = "Unknown", Repeatable = false, Seq = 1 },
                        new { Id = "SL1", Name = "New", Owner = "Lead", Repeatable = false, Seq = 1 },
                        new { Id = "SL4", Name = "Requested Info", Owner = "Lead", Repeatable = false, Seq = 1 },
                        new { Id = "SL2", Name = "Assigned", Owner = "Lead", Repeatable = false, Seq = 2 },
                        new { Id = "SL3", Name = "Re-assigned", Owner = "Lead", Repeatable = false, Seq = 3 },
                        new { Id = "SLA1", Name = "Considering", Owner = "LeadAssignment", Repeatable = false, Seq = 1 },
                        new { Id = "SLA2", Name = "Accepted", Owner = "LeadAssignment", Repeatable = false, Seq = 1 },
                        new { Id = "SLA3", Name = "Rejected", Owner = "LeadAssignment", Repeatable = false, Seq = 1 },
                        new { Id = "SLA4", Name = "Invoiced", Owner = "LeadAssignment", Repeatable = false, Seq = 1 },
                        new { Id = "SLA5", Name = "Re-invoiced", Owner = "LeadAssignment", Repeatable = false, Seq = 1 }
                    );
                });

            modelBuilder.Entity("CRM.Models.StateAction", b =>
                {
                    b.Property<string>("StateId");

                    b.Property<string>("ActionId");

                    b.HasKey("StateId", "ActionId");

                    b.HasIndex("ActionId");

                    b.ToTable("StateActions");

                    b.HasData(
                        new { StateId = "SL1", ActionId = "AL0" },
                        new { StateId = "SL1", ActionId = "AL1" },
                        new { StateId = "SL1", ActionId = "AL2" },
                        new { StateId = "SL4", ActionId = "AL0" },
                        new { StateId = "SL4", ActionId = "AL1" },
                        new { StateId = "SL4", ActionId = "AL2" },
                        new { StateId = "SL2", ActionId = "AL0" },
                        new { StateId = "SL2", ActionId = "AL3" },
                        new { StateId = "SL3", ActionId = "AL0" },
                        new { StateId = "SL3", ActionId = "AL3" },
                        new { StateId = "SLA1", ActionId = "ALA0" },
                        new { StateId = "SLA1", ActionId = "ALA1" },
                        new { StateId = "SLA1", ActionId = "ALA2" },
                        new { StateId = "SLA1", ActionId = "ALA3" },
                        new { StateId = "SLA2", ActionId = "ALA0" },
                        new { StateId = "SLA2", ActionId = "ALA1" },
                        new { StateId = "SLA2", ActionId = "ALA3" },
                        new { StateId = "SLA2", ActionId = "ALA4" },
                        new { StateId = "SLA3", ActionId = "ALA0" },
                        new { StateId = "SLA3", ActionId = "ALA1" },
                        new { StateId = "SLA3", ActionId = "ALA2" },
                        new { StateId = "SLA4", ActionId = "ALA0" },
                        new { StateId = "SLA4", ActionId = "ALA1" },
                        new { StateId = "SLA4", ActionId = "ALA5" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CRM.Models.Action", b =>
                {
                    b.HasOne("CRM.Models.State", "NextState")
                        .WithMany("ActionsWithNextSate")
                        .HasForeignKey("NextStateId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CRM.Models.ActionPermission", b =>
                {
                    b.HasOne("CRM.Models.Action", "Action")
                        .WithMany("ActionPermissions")
                        .HasForeignKey("ActionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CRM.Models.Agent", b =>
                {
                    b.HasOne("CRM.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("Agent")
                        .HasForeignKey("CRM.Models.Agent", "ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CRM.Models.Office", "Office")
                        .WithMany("Agents")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CRM.Models.Customer", b =>
                {
                    b.HasOne("CRM.Models.Address", "Address")
                        .WithOne("Customer")
                        .HasForeignKey("CRM.Models.Customer", "AddressId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CRM.Models.InvoiceItem", b =>
                {
                    b.HasOne("CRM.Models.Invoice", "Invoice")
                        .WithMany("InvoiceItems")
                        .HasForeignKey("InvoiceNo")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CRM.Models.LeadAssignment", "LeadAssignment")
                        .WithMany("InvoiceItems")
                        .HasForeignKey("LeadAssignmentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CRM.Models.Lead", b =>
                {
                    b.HasOne("CRM.Models.Customer", "Customer")
                        .WithMany("Leads")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CRM.Models.LeadType", "LeadType")
                        .WithMany("Leads")
                        .HasForeignKey("LeadTypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CRM.Models.LeadAssignment", b =>
                {
                    b.HasOne("CRM.Models.Lead", "Lead")
                        .WithMany("LeadAssignments")
                        .HasForeignKey("LeadId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CRM.Models.PartnerBranch", "PartnerBranch")
                        .WithMany("LeadAssignments")
                        .HasForeignKey("PartnerBranchId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CRM.Models.LeadAssignmentState", b =>
                {
                    b.HasOne("CRM.Models.LeadAssignment", "LeadAssignment")
                        .WithMany("LeadAssignmentStates")
                        .HasForeignKey("LeadAssignmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CRM.Models.State", "State")
                        .WithMany("LeadAssignmentStates")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CRM.Models.LeadState", b =>
                {
                    b.HasOne("CRM.Models.Lead", "Lead")
                        .WithMany("LeadStates")
                        .HasForeignKey("LeadId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CRM.Models.State", "State")
                        .WithMany("LeadStates")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CRM.Models.Office", b =>
                {
                    b.HasOne("CRM.Models.Address", "Address")
                        .WithOne("Office")
                        .HasForeignKey("CRM.Models.Office", "AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CRM.Models.Company", "Company")
                        .WithMany("Offices")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CRM.Models.PartnerBranch", b =>
                {
                    b.HasOne("CRM.Models.Address", "Address")
                        .WithOne("PartnerBranch")
                        .HasForeignKey("CRM.Models.PartnerBranch", "AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CRM.Models.Partner", "Partner")
                        .WithMany("Branches")
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CRM.Models.PartnerService", b =>
                {
                    b.HasOne("CRM.Models.LeadType", "LeadType")
                        .WithMany("PartnerServices")
                        .HasForeignKey("LeadTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CRM.Models.Partner", "Partner")
                        .WithMany("PartnerServices")
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CRM.Models.SalesPerson", b =>
                {
                    b.HasOne("CRM.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("SalesPerson")
                        .HasForeignKey("CRM.Models.SalesPerson", "ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CRM.Models.PartnerBranch", "Branch")
                        .WithMany("SalesPeople")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CRM.Models.StateAction", b =>
                {
                    b.HasOne("CRM.Models.Action", "Action")
                        .WithMany("StateActions")
                        .HasForeignKey("ActionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CRM.Models.State", "State")
                        .WithMany("StateActions")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("CRM.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CRM.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CRM.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("CRM.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CRM.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CRM.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
