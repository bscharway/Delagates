using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meddelelsessystem
{
    public class Student: Person, IObserver
    {
        Academy academy;
        public string Message { get; set; }
        
        public Student(Academy academy, string name): base(name)
        {
            this.academy = academy;
        }

        //private Academy subject;
        
        //public string Name { get; }

        public void Update()
        {
            if (academy.Message != this.Message)
            {
                this.Message = academy.Message;
                Console.WriteLine($"Studerende {this.Name} modtog nyheden {this.Message} fra akademiet {academy.Name}");
            }
        }
    }
}
