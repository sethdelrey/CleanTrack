using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanTrack.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AdminContext(serviceProvider.GetRequiredService<DbContextOptions<AdminContext>>()))
            {
                if (context.Sessions.Any())
                {
                    return;
                }

                context.Sessions

            }
        }
    }
}
