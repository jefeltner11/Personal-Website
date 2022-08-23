using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Personal_Website.Data;
using Personal_Website.Models;

namespace Personal_Website.Pages.BlogPosts
{
    public class CreateModel : PageModel
    {
        private readonly Personal_Website.Data.Personal_WebsiteContext _context;

        public CreateModel(Personal_Website.Data.Personal_WebsiteContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BlogPost BlogPost { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.BlogPost == null || BlogPost == null)
            {
                return Page();
            }

            _context.BlogPost.Add(BlogPost);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
