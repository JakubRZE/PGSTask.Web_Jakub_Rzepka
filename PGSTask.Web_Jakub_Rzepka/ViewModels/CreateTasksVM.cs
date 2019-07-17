using PGSTask.Web_Jakub_Rzepka.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PGSTask.Web_Jakub_Rzepka;
using X.PagedList;

namespace PGSTask.Web_Jakub_Rzepka.ViewModels
{
    public class CreateTaskVM
    {
        [Required]
        public string Description { get; set; }

    }
}
