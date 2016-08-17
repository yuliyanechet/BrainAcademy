using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{

    public class Directiry
    {
       public File File;

    }


    public class File
    {
        public int size;
        string extension;

        public virtual void Save() { Console.WriteLine("I can save"); }
    }

    public class Image : File
    {
        public override void Save()
        {
            Console.WriteLine("I can save image");
        }
    }

    public class Document : File
    {
        public override void Save()
        {
            Console.WriteLine("I can save document");
        }
    }
}
