using Meddelelsessystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void NotifyHandler();

namespace Meddelelsessystem
{
    public class Academy:Organization//,ISubject
    {
        public NotifyHandler MessageChanged;

         


        //public string Name { get; }

        //Property
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; /*Notify()*/ MessageChanged.Invoke(); }

        }



        //ConstuctoR_____________________________________________________________________________________________________
        public Academy(string name, string addresse) : base(name)
        {
            this.Addresse = addresse;
        }
         
        // Methods_________________________________________________________________________________________________________
        /*
        public void Attach(IObserver o)
        {
            Students += o.Update;
        }
        


        public void Detach(IObserver o)
        {
            Students-=o.Update;
        }
        */

        public void OnMessageChanged ()
        {
            MessageChanged.Invoke();
           /* foreach (IObserver observer in students) 
            { 
                student.Update(); 
            } */ 
        }
    }
}
