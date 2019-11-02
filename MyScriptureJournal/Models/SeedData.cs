using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                if (context.Scripture.Any())
                {
                    return;
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Title = "2 Nephi 28:3",
                        DateAdded = DateTime.Parse("2019-11-02"),
                        Notes = " ",
                        Book = "2 Nephi"
                    },

                    new Scripture
                    {
                        Title = "Mosiah 3:40",
                        DateAdded = DateTime.Parse("2019-11-02"),
                        Notes = " ",
                        Book = "Mosiah"
                    },

                    new Scripture
                    {
                        Title = "Isaiah 1:40",
                        DateAdded = DateTime.Parse("2019-11-02"),
                        Notes = " ",
                        Book = "Isaiah"
                    },

                    new Scripture
                    {
                        Title = "Ezekiel 40:1",
                        DateAdded = DateTime.Parse("2019-11-02"),
                        Notes = " ",
                        Book = "Ezekiel"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
