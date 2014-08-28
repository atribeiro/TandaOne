using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TandaOne.Models
{
    public class TandaOneModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public TimeSpan DepartureTime { get; set; }
    }
}