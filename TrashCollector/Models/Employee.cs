using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ZIPCode { get; set; }
        public string DayOfWork { get; set; }
        public List<Customer> PickupList { get; set; }

        public IEnumerable<string> DaysOfTheWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
