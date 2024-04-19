using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Roadmap_Practice
{
    public class ProcessBusinessLogic
    {
        public event EventHandler ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process started!");
            // some code here..
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted(bool isSuccessful = true)
        {
            ProcessCompleted?.Invoke(this, EventArgs.Empty);
        }
    }  
}
