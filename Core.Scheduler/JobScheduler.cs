using Quartz;

namespace Core.Scheduler
{
    public class JobScheduler : JobSchedulerBase
    {
        public void Run()
        {
            job = JobBuilder.Create<DefaultJob>()
                    .WithIdentity(new JobKey("Test"))
                    .Build();

            defaultTrigger = (ISimpleTrigger)TriggerBuilder.Create()
                                 .WithIdentity("sampleTrigger", "sampleGroup")
                                 .Build();
        }

        private void WriteToLog(IJobDetail job, DateTimeOffset dateTimeOffset, ICronTrigger trigger)
        {
        }
    }
}