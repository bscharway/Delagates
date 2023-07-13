using Meddelelsessystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void NotifyHandler( object sender, EventArgs e);

namespace Meddelelsessystem
{
    public class Academy:Organization, INotifyMessageChanged//,ISubject
    {
        public event NotifyHandler MessageChanged;

         


        //public string Name { get; }

        //Property
        private string message;
        public string Message
        {
            get { return message; }
            set 
            { 
                if (value != message)
                    { 
                        message = value;
                    /*if (MessageChanged != null)
                    {
                        MessageChanged(this, EventArgs.Empty);
                    }*/
                    OnMessageChanged(this) /*MessageChanged.Invoke()*/; 
                    }
            }

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

        public void OnMessageChanged (object sender, EventArgs e = null )
        {
            if ( MessageChanged != null ) 
            {
                MessageChanged( this, e );
            }
            
           /* foreach (IObserver observer in students) 
            { 
                student.Update(); 
            } */ 
        }
    }
}
