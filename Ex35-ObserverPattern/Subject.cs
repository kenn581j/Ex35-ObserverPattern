using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex35_ObserverPattern
{
    public abstract class Subject
    {

        internal List<Observer> observers = new List<Observer>();

        public void Attach(Observer o)
        {
            observers.Add(o);
        }
        public void Detach(Observer o)
        {
            observers.Remove(o);
        }
        public void Notify()
        {
            observers.ForEach(x => x.Update());            
        }
    }
}
