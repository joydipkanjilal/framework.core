using Quartz;

namespace Core.Scheduler
{
    public class JobMetaData
    {
        public string JobKey { get; set; }
        public string CronExpression { get; set; }
    }

    public class Job : IJob
    {
        private static readonly object lockObj = new object();
        protected DateTime lastExecutionTime = DateTime.Now;
        protected Int32 numHrs = 0;

        public Task Execute(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }

        private List<JobMetaData> GetJobDetails()
        {
            List<JobMetaData> lstJobDetails = new List<JobMetaData>();

            return lstJobDetails;
        }

        private void ExecuteHighPriorityJobs()
        {
        }

        private void ExecuteCronJobs()
        {
        }
    }
}