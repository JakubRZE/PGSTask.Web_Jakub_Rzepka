using PGSTask.Web_Jakub_Rzepka.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace PGSTask.Web_Jakub_Rzepka.ViewModels
{
    public class UserTaskViewModel
    {
        [Required]
        public string Description { get; set; }

        public List<UserTask> Tasks { get; set; }

        public string Message { get; set; }
    }
}
