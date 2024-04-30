using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    // Define the IQuittable interface with a Quit method
    public interface IQuittable
    {
        // A method that, when implemented, will define the actions to perform when quitting
        void Quit();
    }
}
