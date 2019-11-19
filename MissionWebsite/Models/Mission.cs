using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MissionWebsite.Models
{
    public class Mission
    {
        [Required]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "The Mission Name must be no longer than 20 Characters")]
        [Display(Name = "Mission Name")]
        public string missionName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Please enter a name")]
        [Display(Name = "Mission President's Name")]
        public string missionPresident { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Please enter a Mission")]
        [Display(Name = "Mission Address")]
        public string missionAddress { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Please enter a Language")]
        [Display(Name = "Language")]
        public string missionLanguage { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Please enter a Language")]
        [Display(Name = "Climate")]
        public string missionClimate { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Please enter a dominant religion")]
        [Display(Name = "Dominant Religion")]
        public string missionReligion { get; set; }







    }
}