using Quartz;
using Quartz.Impl;

namespace Core.Scheduler
{
    public abstract class JobSchedulerBase
    {
        protected ISchedulerFactory schedulerFactory = null;
        protected IScheduler scheduler = null;
        protected IJobDetail job = null;
        protected ICronTrigger trigger = null;
        protected ISimpleTrigger defaultTrigger = null;

        public JobSchedulerBase()
        {
            schedulerFactory = new StdSchedulerFactory();
        }
    }
}