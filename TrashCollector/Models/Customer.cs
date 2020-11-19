using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [Display(Name ="Trash Day")]
        public string TrashDay { get; set; }

        [Display(Name ="Suspended Days")]
        public string SuspendTrashDate { get; set; }
        public List<string> SuspendedDates;

        [Display(Name ="One Time Pick-up Scheduled for:")]
        public string OneTimePickUpDate { get; set; }
        public double Balance { get; set; }
        public bool VerifiedPickedUp = false;

        public IEnumerable<string> DaysOfTheWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        
        
    }


}
