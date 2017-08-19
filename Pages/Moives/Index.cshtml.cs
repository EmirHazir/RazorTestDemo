using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorTestDemo.Models;

namespace RazorTestDemo.Pages.Moives
{
    public class IndexModel : PageModel
    {
        private readonly RazorTestDemo.Models.MoiveContext _context;

        public IndexModel(RazorTestDemo.Models.MoiveContext context)
        {
            _context = context;
        }

        public IList<Moive> Moive { get;set; }

        public async Task OnGetAsync()
        {
            Moive = await _context.Moive.ToListAsync();
        }
    }
}
