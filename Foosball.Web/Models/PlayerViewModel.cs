using System;
using System.ComponentModel.DataAnnotations;
using Foosball.Domain.Model;

namespace Foosball.Web.Models
{
    public class PlayerViewModel : IPlayer
    {
        public Guid Id { get; set; }

        public string DisplayName { get { return string.Format("{0} {1}", FirstName, LastName); } }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public double Rating { get; set; }
    }
}