using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Personal_Website.Data;
using Personal_Website.Models;

namespace Personal_Website.Pages.BlogPosts
{
    public class IndexModel : PageModel
    {
        private readonly Personal_Website.Data.Personal_WebsiteContext _context;

        public IndexModel(Personal_Website.Data.Personal_WebsiteContext context)
        {
            _context = context;
        }

        public IList<BlogPost> BlogPost { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.BlogPost != null)
            {
                BlogPost = await _context.BlogPost.ToListAsync();
            }
        }
    }
}
