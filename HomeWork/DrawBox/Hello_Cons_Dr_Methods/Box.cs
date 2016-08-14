using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Box
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string symbol { get; set; }
        public string text { get; set; }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            for (int i = 1; i <= width; i++)
            {
                Console.SetCursorPosition(x + i, y);
                Console.Write(symbol);
            }
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(x + width, y + i);
                Console.Write(symbol);
            }
            for (int i = 1; i < width; i++)
            {
                Console.SetCursorPosition(x + width - i, y + height - 1);
                Console.Write(symbol);
            }
            for (int i = 1; i <= height; i++)
            {
                Console.SetCursorPosition(x, y + height - i);
                Console.Write(symbol);
            }
            string message=text;
            int halfwidth = (width - text.Length) / 2 + 1;
            int halfheight = height / 2;
            if (text.Length > width - 2)
            {
                Console.SetCursorPosition(x, y + height + 5);
                Console.Write("Too long");
                halfwidth = 1;
                message = text.Substring(0, width - 2);
            }

                
            Console.SetCursorPosition(x + halfwidth, y + halfheight);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
            



            
            

            Console.Read();
        }

        //private void Draw1()
        //{
        //    string s = new string('*', width);
        //}


    }







    //1.  Implement public auto-implement properties for start position (point position)
    //auto-implement properties for width and height of the box
    //and auto-implement properties for a symbol of a given set of valid characters (*, + ,.) to be used for the border 
    //and a message inside the box

    //2.  Implement public Draw() method
    //to define start position, width and height, symbol, message  according to properties
    //Use Math.Min() and Math.Max() methods
    //Use draw() to draw the box with message

    //3.  Implement private method draw() with parameters 
    //for start position, width and height, symbol, message
    //Change the message in the method to return the Box square
    //Use Console.SetCursorPosition() method
    //Trim the message if necessary


}

