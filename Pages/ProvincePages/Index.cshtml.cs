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
    public class IndexModel : PageModel
    {
        private readonly Lab3CityProvince.Data.ApplicationDbContext _context;

        public IndexModel(Lab3CityProvince.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Province> Province { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Provinces != null)
            {
                Province = await _context.Provinces.ToListAsync();
            }
        }
    }
}
