using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_Try_catch
{
    public class LogTableOverflowExeption
        : Exception
    {
        const string overflowMessage = "The log table has overflowed";
        public LogTableOverflowExeption(string auxMessage, Exception inner)
            : base(string.Format("{0} - {1}", overflowMessage, auxMessage), inner)
        {
            this.HelpLink = "http://google.com";
            this.Source = "Exception_Class_Samples" +
                "";

        }
    }

    public class LogTable
        {
        protected string[] logArea;
        protected int elemntUse;
        public LogTable(int numElements)
        {
            logArea = new string[numElements];
            elemntUse = 0;
        }

        public int AddRecord(string newRecord)
        {
            try
            {
                logArea[elemntUse] = newRecord;
                return elemntUse++;

            }
            catch (Exception e)
            {
                throw new LogTableOverflowExeption(string.Format("Record \"{0}\" was not logged", newRecord), e);
                throw;
            }
        }
        }
}
