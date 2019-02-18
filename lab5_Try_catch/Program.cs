using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_Try_catch
{
    class Program
    {
        static int[] numbers = { 2, 4, 5, 6, 8, 9 };
        public static int GetNumber(int index)
        {
            if(index<0||index>=numbers.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return numbers[index];
        }
        static void Main(string[] args)
        {
            try
            {
                GetNumber(66);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
          

           

            int x = 1;
            int y = 0;
            try
            {
                int result = x / y;
            }
            catch (Exception ex) when(y==0)
            {

                Console.WriteLine("у не должно быть равно 0");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            LogTable log = new LogTable(4);
            Console.WriteLine("---");
            try
            {
                for (int count = 1; ; count++)
                {
                    log.AddRecord(string.Format("Log record number {0}", count));
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("\nMessage---\n{0}", ex.Message);
                Console.WriteLine("\n Help Link---\n{0}", ex.HelpLink);
                Console.WriteLine("\n Sourse---\n{0}", ex.Source);
                Console.WriteLine("\n StackTrace---\n{0}", ex.StackTrace);
                Console.WriteLine("\n TargetSite---\n{0}", ex.TargetSite);
            }

        }
    }
}
