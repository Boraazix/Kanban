using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban
{
    public class TaskRepository
    {
        public static void Save(Task task)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (task.Id == 0)
                    {
                        dbContext.Tasks.Add(task);
                    }
                    else
                    {
                        dbContext.Entry(task).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remove(Task task)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Tasks.Attach(task);
                    dbContext.Tasks.Remove(task);

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Task> FindAllToDo()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Tasks.Where(t=> t.State==0).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Task> FindAllDoing()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Tasks.Where(t => t.State == 1).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Task> FindAllDone()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Tasks.Where(t => t.State == 2).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
