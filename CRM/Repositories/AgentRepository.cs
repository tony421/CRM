﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.Data;
using CRM.Models;

namespace CRM.Repositories
{
    public class AgentRepository : IAgentRepository
    {
        private ApplicationDbContext _context;

        public AgentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Agent entity)
        {
            _context.Agents.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Agent> Get()
        {
            return _context.Agents;
        }

        public Agent Get(int id)
        {
            throw new NotImplementedException();
        }

        public Agent GetByUid(Guid uid)
        {
            return _context.Agents.FirstOrDefault(w => w.Id == uid);
        }

        public void Remove(Agent entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Agent entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Agent> GetAgentsByOffice(int officeId)
        {
            return _context.Agents.Where(w => w.OfficeId == officeId);
        }
    }
}