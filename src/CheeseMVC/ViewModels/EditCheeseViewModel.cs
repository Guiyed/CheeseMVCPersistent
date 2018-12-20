using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;

namespace CheeseMVC.ViewModels
{
    public class EditCheeseViewModel : AddCheeseViewModel
    {
        [Required]
        public int CheeseID { get; set; }

        public EditCheeseViewModel() { }

        public EditCheeseViewModel(IEnumerable<CheeseCategory> categories) : base(categories)
        {

        }
    }
}
