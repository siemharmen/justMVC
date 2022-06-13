using ReversiMVC.Controllers;
using ReversiMVC.Data;
using ReversiMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReversiMVC.ViewModels
{
    public class ViewListSpelers
    {
        public IEnumerable<ReversiMVC.Models.Speler> Spelers { get; set; }
        private readonly ApplicationDbContext _context;


        public ViewListSpelers(IEnumerable<Speler> spelers, ApplicationDbContext context)
        {
            Spelers = spelers;
            _context = context;
        }

        public Boolean Refresh()
        {
            Spelers = _context.Spelers.ToList();
            return true;
        }
    }
}
