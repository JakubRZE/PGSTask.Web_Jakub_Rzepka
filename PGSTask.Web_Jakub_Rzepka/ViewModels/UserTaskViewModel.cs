using PGSTask.Web_Jakub_Rzepka.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PGSTask.Web_Jakub_Rzepka;

namespace PGSTask.Web_Jakub_Rzepka.ViewModels
{
    public class UserTaskViewModel
    {
        [Required]
        public string Description { get; set; }

        public List<UserTask> Tasks { get; set; }
        
        public string SortOrder { get;  set; }
        public string CurrentColumn { get;  set; }
        public string CurrentFilter { get;  set; }

        public string GetInverseSortOrder() =>
            SortOrder == Web_Jakub_Rzepka.SortOrder.Desc || SortOrder == null ? Web_Jakub_Rzepka.SortOrder.Asc : Web_Jakub_Rzepka.SortOrder.Desc;
    }
}
