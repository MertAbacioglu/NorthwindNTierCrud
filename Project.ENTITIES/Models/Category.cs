using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(15, ErrorMessage = "{0} can be up to {1} characters "), Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
