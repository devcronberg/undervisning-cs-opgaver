using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StockItem s = new StockItem(-1);

            }
            catch (StockItemException ex)
            {
                Console.WriteLine("StockItem Error : " + ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("General Error");
            }
        }
    }
    public class StockItem
    {
        public int Id { get; set; }

        public StockItem(int id)
        {
            if (id < 0)
                throw new StockItemException("Wrong id");
        }
    }

    public class StockItemException : Exception
    {
        public StockItemException(string message) : base(message)
        { }
    }

}
