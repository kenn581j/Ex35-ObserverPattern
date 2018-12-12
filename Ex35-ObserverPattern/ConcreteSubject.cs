using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_ObserverPattern
{
    public class ConcreteSubject : Subject
    {

        private int state;
        public int State
        {
            get => state;
            set { state = value; Notify(); }
        }

    }
}
