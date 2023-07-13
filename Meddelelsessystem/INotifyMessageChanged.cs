using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meddelelsessystem
{
    public interface INotifyMessageChanged
    {
        public event NotifyHandler MessageChanged;
        
    }
}
