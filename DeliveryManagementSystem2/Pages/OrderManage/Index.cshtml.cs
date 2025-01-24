using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DeliveryManagementSystem.Data;
using DeliveryManagementSystem2.Models;

namespace DeliveryManagementSystem2.Pages.OrderManage
{
    public class IndexModel : PageModel
    {
        private readonly DeliveryManagementSystem.Data.ApplicationDbContext _context;

        public IndexModel(DeliveryManagementSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Order = await _context.Orders.ToListAsync();
        }
    }
}
