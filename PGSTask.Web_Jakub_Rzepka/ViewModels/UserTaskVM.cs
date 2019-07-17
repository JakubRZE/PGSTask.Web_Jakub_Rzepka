using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace PGSTask.Web_Jakub_Rzepka.ViewModels
{
    public class UserTaskVM
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }
        
        public DateTime CreatedAt { get; set; }
    }
}
