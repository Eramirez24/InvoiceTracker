using InvoiceTracker.Data;
using InvoiceTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing.Matching;

namespace InvoiceTracker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly InvoicesDbContext _Context;

        public IndexModel(InvoicesDbContext Context)
        {
            _Context = Context;
        }

        //Handler Method- Get method is the method that request information from a source
        public void OnGet()
        {
            Invoices = _Context.Invoices;
        }

        public IEnumerable<Invoices> Invoices { get; set; }
    }
}