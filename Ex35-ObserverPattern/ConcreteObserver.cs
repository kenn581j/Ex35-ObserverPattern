using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;
        private int state;

        public ConcreteObserver(ConcreteSubject cs)
        {
            subject = cs;
        }

        public int State
        {
            get => state;
            set { state = value; }            
        }

        public override void Update()
        {
            State = subject.State;
        }
    }
}
