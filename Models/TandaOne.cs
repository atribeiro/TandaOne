using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Objects;
using System.Linq;
using System.Web;

namespace TandaOne.Models
{
    [Table ("trackinghours")]
    public class TandaOneModel
    {
        public int EmployeeId { get; set; }
        //[Required]
        //[StringLength(50)]
        //[DisplayName("EmployeeID")]

        public string FirstName { get; set; }
        //[Required]
        //[StringLength(50)]
        //[DisplayName("FirstName")]
        
        public string Surname { get; set; }
        //[Required]
        //[StringLength(50)]
        //[DisplayName("Surname")]

        public DateTime Date { get; set; }
        //[Required]
        //[DisplayName("Time Offset")]
        //[Range(-24, 24)]

        public TimeSpan Arrival { get; set; }
        public TimeSpan Departure { get; set; }


        public List<EmployeeDetail> Employee { get; set; }

        public class ObjectContext
        {
            public DbSet<EmployeeDetail> HourEmployeeDetails { get; set; }
        }
    }
}