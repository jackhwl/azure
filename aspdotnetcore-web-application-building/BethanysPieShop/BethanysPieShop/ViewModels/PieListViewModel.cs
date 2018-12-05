using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
    public class PieListViewModel
    {
        public string CurrentCategory { get; set; }
        public IEnumerable<Pie> Pies { get; set; }
    }
}
