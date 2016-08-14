using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To enter coordinates click Enter");
            Console.WriteLine("X: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Y: ");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            int width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            int height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the symbol. You can choose *, -, + ");
            string symbol = Console.ReadLine();
            Console.WriteLine("What text do you want to see?");
            string text = Console.ReadLine();

            Box box = new Box();
            box.x = x;
            box.y = y;
            box.width = width;
            box.height = height;
            box.symbol = symbol;
            box.text = text;
            Console.Clear();
            box.Draw();
            


            try
            {
              


                //Implement start position, width and height, symbol, message input
               
                //Create Box class instance

                //Use  Box.Draw() method

                //Console.WriteLine("Press any key...");


                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
            
        }
    }
}
