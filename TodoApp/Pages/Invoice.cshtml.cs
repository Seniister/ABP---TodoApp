using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BasicAspNetCoreApplication.Entities;
using TodoApp.Data;
using static BasicAspNetCoreApplication.Entities.Invoice;

namespace TodoApp.Pages
{
    public class InvoiceModel : PageModel
    {
        private readonly TodoApp.Data.TodoAppDbContext _context;

        public InvoiceModel(TodoApp.Data.TodoAppDbContext context)
        {
            _context = context;

        }
        
        [BindProperty]
        public Invoice Invoice { get; set; }

        public IActionResult OnGet()
        {
            /*Invoice = new Invoice
            {
                Date = DateTime.Now,
                Refundable = true,
                InvoiceItems = 
                {
                  new InvoiceItem {
                    Name = "Mouse",
                    Price = 10,
                },
                  new InvoiceItem {
                    Name = "keyboard",
                    Price = 10,
                },
                },
                ImgUrl = "",
                FileUrl = "",
                Type = InvoiceType.Type1
            };*/
            return Page();
        }

        
        
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Invoice.Add(Invoice);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
