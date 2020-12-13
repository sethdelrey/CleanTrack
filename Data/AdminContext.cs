using CleanTrack.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CleanTrack.Data
{
    public class AdminContext : DbContext
    {
        public DbSet<CleaningSession> Sessions { get; set; }
        public DbSet<CleaningTask> Tasks { get; set; }

        public DbSet<SessionTask> SessionTasks { get; set; }

        public AdminContext(DbContextOptions<AdminContext> options)
            : base(options)
        { }

        public AdminContext()
            : base()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CleanTrack;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SessionTask>()
                .HasKey(st => new { st.SessionId, st.TaskId });

            modelBuilder.Entity<SessionTask>()
                .HasOne(st => st.Session)
                .WithMany(s => s.SessionTasks)
                .HasForeignKey(st => st.SessionId);

            modelBuilder.Entity<SessionTask>()
                .HasOne(st => st.Task)
                .WithMany(t => t.SessionTasks)
                .HasForeignKey(st => st.TaskId);

            var sessions = new[]
                {
                    new CleaningSession
                    {
                        CleaningSessionId = 1,
                        IsBigMop = false,
                        StartTime = DateTime.ParseExact("11/27/2020 05:13:15", "MM/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture),
                        EndTime = DateTime.ParseExact("11/20/2020 06:35:15", "MM/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture)
                    },
                    new CleaningSession
                    {
                        CleaningSessionId = 2,
                        IsBigMop = true,
                        StartTime = DateTime.ParseExact("11/20/2020 05:13:30", "MM/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture),
                        EndTime = DateTime.ParseExact("11/20/2020 07:45:15", "MM/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture)
                    }
                };

            var tasks = new[]
            {
                    new CleaningTask()
                    {
                        CleaningTaskId = 1,
                        Name = "Take Out Trash",
                        IsDone = true,
                        IsInDoubleClean = true
                    },
                    new CleaningTask()
                    {
                        CleaningTaskId = 2,
                        Name = "Dust Mop",
                        IsDone = true,
                        IsInDoubleClean = true
                    },
                    new CleaningTask()
                    {
                        CleaningTaskId = 3,
                        Name = "Vacuum",
                        IsDone = true,
                        IsInDoubleClean = true
                    },
                    new CleaningTask()
                    {
                        CleaningTaskId = 4,
                        Name = "Mop",
                        IsDone = true,
                        IsInDoubleClean = true
                    },
                    new CleaningTask()
                    {
                        CleaningTaskId = 5,
                        Name = "Clean Kitchens",
                        IsDone = true,
                        IsInDoubleClean = false
                    },
                    new CleaningTask()
                    {
                        CleaningTaskId = 6,
                        Name = "Clean Bathrooms",
                        IsDone = true,
                        IsInDoubleClean = false
                    },
                    new CleaningTask()
                    {
                        CleaningTaskId = 7,
                        Name = "Dust",
                        IsDone = true,
                        IsInDoubleClean = false
                    },
                    new CleaningTask()
                    {
                        CleaningTaskId = 8,
                        Name = "Dust",
                        IsDone = true,
                        IsInDoubleClean = false
                    },
                    new CleaningTask()
                    {
                        CleaningTaskId = 9,
                        Name = "Clean Windows",
                        IsDone = true,
                        IsInDoubleClean = true
                    }
                };

            var sessionTasks = new[]
            {
                new SessionTask
                {
                    SessionId = 1,
                    TaskId = 1
                },
                new SessionTask
                {
                    SessionId = 1,
                    TaskId = 2
                },
                new SessionTask
                {
                    SessionId = 1,
                    TaskId = 3
                },
                new SessionTask
                {
                    SessionId = 1,
                    TaskId = 4
                },
                new SessionTask
                {
                    SessionId = 2,
                    TaskId = 1
                },
                new SessionTask
                {
                    SessionId = 2,
                    TaskId = 2
                },
                new SessionTask
                {
                    SessionId = 2,
                    TaskId = 3
                },
                new SessionTask
                {
                    SessionId = 2,
                    TaskId = 4
                },
                new SessionTask
                {
                    SessionId = 2,
                    TaskId = 5
                },
                new SessionTask
                {
                    SessionId = 2,
                    TaskId = 6
                },
                new SessionTask
                {
                    SessionId = 2,
                    TaskId = 7
                },
                new SessionTask
                {
                    SessionId = 2,
                    TaskId = 8
                }
            };

            modelBuilder.Entity<CleaningSession>().HasData(sessions);
            modelBuilder.Entity<CleaningTask>().HasData(tasks[0], tasks[1], tasks[2], tasks[3], tasks[4], tasks[5], tasks[6], tasks[7], tasks[8]);
            modelBuilder.Entity<SessionTask>().HasData(sessionTasks[0], sessionTasks[1], sessionTasks[2], sessionTasks[3], sessionTasks[4], sessionTasks[5], sessionTasks[6], sessionTasks[7], sessionTasks[8], sessionTasks[9], sessionTasks[10], sessionTasks[11]);
            base.OnModelCreating(modelBuilder);
        }

        public class CleaningSession
        {
            public int CleaningSessionId { get; set; }

            public DateTime StartTime { get; set; }

            public DateTime EndTime { get; set; }

            public bool IsBigMop { get; set; }


            public virtual List<SessionTask> SessionTasks { get; set; }
        }

        public class CleaningTask
        {

            public int CleaningTaskId { get; set; }
            public string Name { get; set; }

            public DateTime StartTime { get; set; }

            public DateTime EndTime { get; set; }

            public bool IsDone { get; set; }

            public bool IsInDoubleClean { get; set; }


            public virtual List<SessionTask> SessionTasks { get; set; }
        }

        public class SessionTask
        {
            public int SessionId { get; set; }
            public CleaningSession Session { get; set; }

            public int TaskId { get; set; }
            public CleaningTask Task { get; set; }
        }
    }
}
