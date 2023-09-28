using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab3CityProvince.Data;
using Lab3CityProvince.Models;
using Microsoft.AspNetCore.Authorization;

namespace Lab3CityProvince.Pages.CityPages
{

    // [Authorize]
    public class IndexModel : PageModel
    {
        private readonly Lab3CityProvince.Data.ApplicationDbContext _context;

        public IndexModel(Lab3CityProvince.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<City> City { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Cities != null)
            {
                City = await _context.Cities
                .Include(c => c.Province).ToListAsync();
            }
        }
    }
}
