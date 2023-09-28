using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab3CityProvince.Data;
using Lab3CityProvince.Models;

namespace Lab3CityProvince.Pages.ProvincePages
{
    public class DeleteModel : PageModel
    {
        private readonly Lab3CityProvince.Data.ApplicationDbContext _context;

        public DeleteModel(Lab3CityProvince.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Province Province { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Provinces == null)
            {
                return NotFound();
            }

            var province = await _context.Provinces.FirstOrDefaultAsync(m => m.ProvinceCode == id);

            if (province == null)
            {
                return NotFound();
            }
            else 
            {
                Province = province;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _context.Provinces == null)
            {
                return NotFound();
            }
            var province = await _context.Provinces.FindAsync(id);

            if (province != null)
            {
                Province = province;
                _context.Provinces.Remove(Province);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
