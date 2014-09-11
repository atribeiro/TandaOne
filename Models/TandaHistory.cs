using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TandaOne.Models
{
    public class TandaHistory
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
      

    }
    public class ObjectContext
    {
        public DbSet<EmployeeDetail> HourEmployeeDetails { get; set; }
    }
}