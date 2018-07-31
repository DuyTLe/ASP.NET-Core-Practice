using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPNetTest.Models;

namespace ASPNetTest.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ASPNetTest.Models.ASPNetTestContext _context;

        public IndexModel(ASPNetTest.Models.ASPNetTestContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
