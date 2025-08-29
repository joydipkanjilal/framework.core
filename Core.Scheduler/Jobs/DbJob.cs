using Quartz;

namespace Core.Scheduler
{
    public class DbJob : IJob
    {
        Task IJob.Execute(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}