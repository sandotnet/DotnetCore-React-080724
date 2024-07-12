using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
//Application Exception or User defind exception
    class TicketException:Exception
    {
        string message;
        public TicketException(string message)
        {
            this.message = message;
        }
        public TicketException()
        {
            
        }
        public override string Message
        {
           // get { return "Not allow to book more than 3 tickets.\nTransaction Faild"; }
           get { return message; }
        }
        public string ErrMessage
        {
            get { return "Not allow to book more than 3 tickets.\nTransaction Faild"; }
        }
    }
    class BookTicket
    {
        public static void Book(int no)
        {
            try
            {
                if (no > 4)
                    // throw new TicketException("Transaction Failed");
                    throw new TicketException();
                else
                    Console.WriteLine("Transaction Success.");
            }
            catch(TicketException ex)
            {
                Console.WriteLine(ex.Message);
               Console.WriteLine(ex.ErrMessage);
            }
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter tickets");
                int no = int.Parse(Console.ReadLine());
                Book(no);
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
        }
    }
}
