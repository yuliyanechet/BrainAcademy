using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP
{
    public enum gender { male, female };

    public class Watcher
    {
        public string FirstName;
        public string LastName;
        public gender Gender;
        public int Ages;

        public Watcher()
        {

        }

        public Watcher(string firstName, string lastName, gender gender, int ages)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Ages = ages;
        }



    }
}