﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCRM.Database.Entities;
using PCRM.Database.Context;

namespace PCRM.Database.DataAccess
{
    public class PcrmDao : IPcrmDao
    {
        private PcrmContext _context;

        public Employee GetEmployee(int id)
        {
            using (_context = new PcrmContext())
            {
                return _context.Employees.Find(id);
            }
        }
    }
}
