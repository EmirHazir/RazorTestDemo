using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorTestDemo.Models;

namespace RazorTestDemo.Pages.Moives
{
    public class EditModel : PageModel
    {
        private readonly RazorTestDemo.Models.MoiveContext _context;

        public EditModel(RazorTestDemo.Models.MoiveContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Moive Moive { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Moive = await _context.Moive.SingleOrDefaultAsync(m => m.ID == id);

            if (Moive == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Moive).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }

            return RedirectToPage("./Index");
        }
    }
}
