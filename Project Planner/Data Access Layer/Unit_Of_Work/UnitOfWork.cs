using Data_Access_Layer.Models;
using Data_Access_Layer.Repositories;
using System;

namespace Data_Access_Layer.Unit_Of_Work
{
    public class UnitOfWork : IDisposable
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        private GenericRepository<Project> projectRepository;
        private GenericRepository<Bug> bugRepository;
        private GenericRepository<Features> featuresRepository;
        private GenericRepository<Objective> objectiveRepository;
        private GenericRepository<Task> taskRepository;
        private GenericRepository<Technology> technologyRepository;
        private GenericRepository<TimeLog> timeLogRepository;

        public GenericRepository<Project> ProjectRepository
        {
            get
            {
                if (this.projectRepository == null)
                    this.projectRepository = new GenericRepository<Project>(context);
                return projectRepository;
            }
        }

        public GenericRepository<Bug> BugRepository
        {
            get
            {
                if (this.bugRepository == null)
                    this.bugRepository = new GenericRepository<Bug>(context);
                return bugRepository;
            }
        }

        public GenericRepository<Features> FeaturesRepository
        {
            get
            {
                if (this.featuresRepository == null)
                    this.featuresRepository = new GenericRepository<Features>(context);
                return featuresRepository;
            }
        }

        public GenericRepository<Objective> ObjectiveRepository
        {
            get
            {
                if (this.objectiveRepository == null)
                    this.objectiveRepository = new GenericRepository<Objective>(context);
                return objectiveRepository;
            }
        }

        public GenericRepository<Task> TaskRepository
        {
            get
            {
                if (this.taskRepository == null)
                    this.taskRepository = new GenericRepository<Task>(context);
                return taskRepository;
            }
        }

        public GenericRepository<Technology> TechnologyRepository
        {
            get
            {
                if (this.technologyRepository == null)
                    this.technologyRepository = new GenericRepository<Technology>(context);
                return technologyRepository;
            }
        }

        public GenericRepository<TimeLog> TimeLogRepository
        {
            get
            {
                if (this.timeLogRepository == null)
                    this.timeLogRepository = new GenericRepository<TimeLog>(context);
                return timeLogRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
