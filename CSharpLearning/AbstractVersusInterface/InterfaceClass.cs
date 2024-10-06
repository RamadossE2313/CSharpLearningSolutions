using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.AbstractVersusInterface
{
    // An interface is a contract that defines a set of methods and properties that implementing classes must provide.
    // Interfaces do not provide any implementation.
    // Can only contain method signatures, properties, events, and indexers (no fields).
    // interfaces can't have constructor
    // Used when you want to define a contract that can be implemented by any class, regardless of its position in the class hierarchy.
    // When you want to define a contract that can be implemented by any class, promoting loose coupling and flexibility. This is particularly useful when multiple classes from different hierarchies need to share common behavior.
    public interface InterfaceClass
    {
        int MyProperty { get; set; }

        // Interface can't contain field
        //int _field;

        void Speak();
    }

    public class InterfaceImplementClass : InterfaceClass
    {
        public int MyProperty { get; set; }
        public void Speak()
        {
            MyProperty++;
        }
    }
}


