using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csloop_05._08
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 05.08 수업
            long start = DateTime.Now.Ticks;
            long count = 0;
            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }
            Console.WriteLine(count + "번 반복했습니다!");

            String[] array = { "사과주스", "배주스", "포도주스", "딸기우유", "바나나우유" };

            foreach (string item in array)
            {
                Console.WriteLine(item);
            }*/

            //05.12 수업
            //int[] array = new int[10];
            //int[] array = new int[20];
            //int[] array = new int[3] { 1, 2, 3 };
            //오류발생-> int[] array = int[]{ 1,2,3};
            int[] array = { 1, 2, 3 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }  
    }
}
