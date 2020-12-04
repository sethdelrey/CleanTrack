/*using CleanTrack.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

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

                *//*CleaningTask takeOutTrash = new CleaningTask()
                {
                    Name = "Take Out Trash",
                    IsDone = true,
                    IsInDoubleClean = true
                };

                CleaningTask takeOutTrash2 = new CleaningTask()
                {
                    Name = "Take Out Trash",
                    IsDone = false,
                    IsInDoubleClean = true
                };

                CleaningTask dustMop = new CleaningTask()
                {
                    Name = "Dust Mop",
                    IsDone = true,
                    IsInDoubleClean = true
                };

                CleaningTask dustMop2 = new CleaningTask()
                {
                    Name = "Dust Mop",
                    IsDone = false,
                    IsInDoubleClean = true
                };

                CleaningTask vacuum = new CleaningTask()
                {
                    Name = "Vacuum",
                    IsDone = true,
                    IsInDoubleClean = true
                };

                CleaningTask vacuum2 = new CleaningTask()
                {
                    Name = "Vacuum",
                    IsDone = false,
                    IsInDoubleClean = true
                };

                CleaningTask mop = new CleaningTask()
                {
                    Name = "Mop",
                    IsDone = true,
                    IsInDoubleClean = true
                };

                CleaningTask mop2 = new CleaningTask()
                {
                    Name = "Mop",
                    IsDone = false,
                    IsInDoubleClean = true
                };

                CleaningTask cleanKitchens = new CleaningTask()
                {
                    Name = "Clean Kitchens",
                    IsDone = true,
                    IsInDoubleClean = false
                };

                CleaningTask cleanKitchens2 = new CleaningTask()
                {
                    Name = "Clean Kitchens",
                    IsDone = false,
                    IsInDoubleClean = false
                };

                CleaningTask cleanBathrooms = new CleaningTask()
                {
                    Name = "Clean Bathrooms",
                    IsDone = true,
                    IsInDoubleClean = false
                };

                CleaningTask cleanBathrooms2 = new CleaningTask()
                {
                    Name = "Clean Bathrooms",
                    IsDone = false,
                    IsInDoubleClean = false
                };

                CleaningTask dust = new CleaningTask()
                {
                    Name = "Dust",
                    IsDone = true,
                    IsInDoubleClean = false
                };

                CleaningTask dust2 = new CleaningTask()
                {
                    Name = "Dust",
                    IsDone = false,
                    IsInDoubleClean = false
                };

                CleaningTask washDishes = new CleaningTask()
                {
                    Name = "Dust",
                    IsDone = true,
                    IsInDoubleClean = false
                };

                CleaningTask washDishes2 = new CleaningTask()
                {
                    Name = "Dust",
                    IsDone = false,
                    IsInDoubleClean = false
                };

                CleaningTask cleanWindows = new CleaningTask()
                {
                    Name = "Clean Windows",
                    IsDone = true,
                    IsInDoubleClean = true
                };

                CleaningTask cleanWindows2 = new CleaningTask()
                {
                    Name = "Clean Windows",
                    IsDone = false,
                    IsInDoubleClean = true
                };

                context.Sessions.AddRange(
                    new CleaningSession()
                    {
                        StartTime = DateTime.ParseExact("11/27/2020 05:13:15", "MM/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture),
                        EndTime = DateTime.ParseExact("11/27/2020 06:45:11", "MM/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture),
                        IsBigMop = false,
                        FinishedTasks = new List<CleaningTask>
                        {
                            takeOutTrash,
                            dust,
                            vacuum,
                            mop
                        }
                    },
                    new CleaningSession()
                    {
                        StartTime = DateTime.ParseExact("11/20/2020 05:13:30", "MM/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture),
                        EndTime = DateTime.ParseExact("11/20/2020 07:45:15", "MM/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture),
                        IsBigMop = false,
                        FinishedTasks = new List<CleaningTask>
                        {
                            takeOutTrash,
                            dust,
                            vacuum,
                            mop,
                            cleanKitchens,
                            cleanBathrooms,
                            dust,
                            washDishes,
                            cleanWindows
                        }
                    });

                context.SessionTasks.AddRange(
                    
                    );*//*

                var sessions = new[]
                {
                    new CleaningSession
                    {
                        CleaningSessionId = 1,
                        IsBigMop = false,
                        StartTime = DateTime.ParseExact("11/27/2020 05:13:15", "MM/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture),
                        EndTime = DateTime.ParseExact("11/20/2020 07:45:15", "MM/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture)
                    },
                    new CleaningSession
                    {
                        CleaningSessionId = 2,
                        IsBigMop = false,
                        StartTime = DateTime.ParseExact("11/20/2020 05:13:30", "MM/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture),
                        EndTime = DateTime.ParseExact("11/20/2020 07:45:15", "MM/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture)
                    }
                };

                var tasks = new[]
                {
                    new CleaningTask()
                    {
                        Name = "Take Out Trash",
                        IsDone = true,
                        IsInDoubleClean = true
                    },
                    new CleaningTask()
                    {
                        Name = "Dust Mop",
                        IsDone = true,
                        IsInDoubleClean = true
                    },
                    new CleaningTask()
                    {
                        Name = "Vacuum",
                        IsDone = true,
                        IsInDoubleClean = true
                    },
                    new CleaningTask()
                    {
                        Name = "Mop",
                        IsDone = true,
                        IsInDoubleClean = true
                    },
                    new CleaningTask()
                    {
                        Name = "Clean Kitchens",
                        IsDone = true,
                        IsInDoubleClean = false
                    },
                    new CleaningTask()
                    {
                        Name = "Clean Bathrooms",
                        IsDone = true,
                        IsInDoubleClean = false
                    },
                    new CleaningTask()
                    {
                        Name = "Dust",
                        IsDone = true,
                        IsInDoubleClean = false
                    },
                    new CleaningTask()
                    {
                        Name = "Dust",
                        IsDone = true,
                        IsInDoubleClean = false
                    },
                    new CleaningTask()
                    {
                        Name = "Clean Windows",
                        IsDone = true,
                        IsInDoubleClean = true
                    }
                };

                context.Sessions

                context.SaveChanges();
            }
        }
    }
}
*/