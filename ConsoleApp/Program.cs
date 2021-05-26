using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // 간격(초)
            // 오전 9:00에 시작하여 1 초마다 호출됩니다.
            ConsoleScheduler.IntervalInSeconds(9,0,1,
            () =>
            {
                Console.WriteLine($"간격(초)-{DateTime.Now.ToString("HHmmss")}");
            });

            // 간격(분)
            // 오전 9:00에 시작하여 1 분마다 호출됩니다.
            ConsoleScheduler.IntervalInMinutes(9, 0, 1,
            () =>
            {
                Console.WriteLine($"간격(분)-{DateTime.Now.ToString("HHmmss")}");
            });

            // 간격(시간)
            // 오전 9:00에 시작하여 1 시간마다 호출됩니다.
            ConsoleScheduler.IntervalInHours(9, 0, 1,
            () =>
            {
                Console.WriteLine($"간격(시간)-{DateTime.Now.ToString("HHmmss")}");
            });

            // 간격(날짜) 
            // 오전 9:00 에 시작되며 1 일마다 호출됩니다.
            ConsoleScheduler.IntervalInDays(9, 0, 1,
            () =>
            {
                Console.WriteLine($"간격(날짜)-{DateTime.Now.ToString("HHmmss")}");
            });

            Console.ReadLine();

        }
    }
}
