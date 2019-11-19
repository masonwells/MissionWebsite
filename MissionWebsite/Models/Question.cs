using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionWebsite.Models
{
    public class Question
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int QuestionID { get; set; }

        [Required(ErrorMessage = "You must type a message to submit")]
        [DisplayName("Question")]
        [StringLength(500)]
        public string sMessage { get; set; }
    }
}