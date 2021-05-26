using System;

namespace ConsoleApp
{
    class ConsoleScheduler
    {
        /// <summary>
        /// 간격 (초) 
        /// </summary>
        /// <param name="hour">시</param>
        /// <param name="min">분</param>
        /// <param name="interval">반복간격(초)</param>
        /// <param name="task">void:함수</param>
        public static void IntervalInSeconds(int hour, int min, double interval, Action task)
        {
            interval = interval / 3600;
            SchedulerService.Instance.ScheduleTask(hour, min, interval, task);
        }
        /// <summary>
        /// 간격 (분) 
        /// </summary>
        /// <param name="hour">시</param>
        /// <param name="min">분</param>
        /// <param name="interval">반복간격(분)</param>
        /// <param name="task">void:함수</param>
        public static void IntervalInMinutes(int hour, int min, double interval, Action task)
        {
            interval = interval / 60;
            SchedulerService.Instance.ScheduleTask(hour, min, interval, task);
        }
        /// <summary>
        /// 간격 (시간) 
        /// </summary>
        /// <param name="hour">시</param>
        /// <param name="min">분</param>
        /// <param name="interval">반복간격(시간)</param>
        /// <param name="task">void:함수</param>
        public static void IntervalInHours(int hour, int min, double interval, Action task)
        {
            SchedulerService.Instance.ScheduleTask(hour, min, interval, task);
        }
        /// <summary>
        /// 간격 (일) 
        /// </summary>
        /// <param name="hour">시</param>
        /// <param name="min">분</param>
        /// <param name="interval">반복간격(일)</param>
        /// <param name="task">void:함수</param>
        public static void IntervalInDays(int hour, int min, double interval, Action task)
        {
            interval = interval * 24;
            SchedulerService.Instance.ScheduleTask(hour, min, interval, task);
        }
    }

}
