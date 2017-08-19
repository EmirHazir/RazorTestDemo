using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorTestDemo.Models;

namespace RazorTestDemo.Pages.Moives
{
    public class CreateModel : PageModel
    {
        private readonly RazorTestDemo.Models.MoiveContext _context;

        public CreateModel(RazorTestDemo.Models.MoiveContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Moive Moive { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Moive.Add(Moive);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}