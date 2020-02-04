using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDExample.Models;

namespace CRUDInterface
{
    public class IndexModel : PageModel
    {
        private readonly CRUDExample.Models.JournalDbContext _context;

        public IndexModel(CRUDExample.Models.JournalDbContext context)
        {
            _context = context;
        }

        public IList<DailyRecord> DailyRecord { get;set; }

        public async Task OnGetAsync(int? year = null, int? month = null)
        {
            if (year == null && month == null)
            {
                DailyRecord = await _context.Records.OrderBy(o => o.Date).ToListAsync();
            }
            else
            {
                
                var startDate = new DateTime(year.Value, month.Value, 1);

                DailyRecord = await _context.Records
                    .Where(o => o.Date >= startDate &&
                                o.Date < startDate.AddMonths(1))
                    .OrderBy(o => o.Date)
                    .ToListAsync();
            }
            
        }
    }
}
