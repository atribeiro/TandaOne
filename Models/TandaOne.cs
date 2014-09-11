using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TandaOne.Models
{
   public class TandaOne
       
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? Arrival
         {
           get { return DateTime.Now; }
        }

       public DateTime? Departure { get; set; }

       public class ObjectContext
        {
            public DbSet<trackinghour> HourEmployeeDetails { get; set; }
            public DbSet<EmployeeDetail> EmployeeDetail { get; set; }
        }
    }
}