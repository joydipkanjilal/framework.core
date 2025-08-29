using Quartz;

namespace Core.Scheduler
{
    public class DefaultJob : IJob
    {
        Task IJob.Execute(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}