using System;// this is used  for console input and output some of things like Console.WriteLine() and Console.ReadLine() are used for input and output.
using System.Collections.Generic;//this is used for collection of data like list, dictionary, queue, stack etc.
using System.Linq;//this is used for querying the data from collection like list, dictionary, queue, stack etc.
using System.Text;//this is used for string manipulation like stringbuilder, stringformat etc.
using System.Threading.Tasks;//this is used for multithreading and asynchronous programming like task, async, await etc.

/* C# Vs .Net
 * C# is a programing Language and .Net is a framework for building application on windows.
 * .Net  composed to two component one is CLR(common Language Runtime) and other is Class library.
 */
/*C# History
 * Before C# in the C family there are two languages one is c and other c++.when it compiles it convert language to direct computer code 
 * due this it will not run on another os only on those os for which it made.like Java when it compile it convert to byte code and then machine
 * code.similarly it is made by microsoft to overcome this flaws.so when C# is compiled it convert to IL code (intermediate Language)
 * and after that it convert to native language.
 */
/*CLR 
 * Like we discuss clr is application that set in the memory and convert the IL code to native or machine code and the Process is called 
 * JIT compilation (Just in time )
 */
/*Archeticture of .Net
 * -In advance Level an application is made of building blocks and these building is said to classes which represent the property and 
 * functionality of things like car have name model and speed and also class contain the function or method that perform a task.
 * -while to organized the classes we use the namespace .so namespace is a container for related classes.
 * -when the namespace increase we need a defferent way partition or cotainer .for that we use the Assembly (DLL(dynamically link libray)
 * or EXE) so assembly is the container for related namespaces .like physically it is partition in the disk contain files which may be Dll or exe.
 * -When application is compiled the compiler compiled one or more assembly defending on how we partition and how we make the application
 */

namespace Introduaction// it is namespace which is used to organize the classes and avoid the name conflict with other classes.
{
    internal class introduction//it is class which is used to represent the property and functionality of things like car have name
                               //model and speed and also class contain the function or method that perform a task.
    {
        static void Main(string[] args)//it is entry point of the application and it is static method which is used to run the
                                       //application and it is called by the runtime.
        {   
            Console.WriteLine("Hello World");//it is used to print the output on the console and it is used for output.
            Console.Beep();//it is used to make a beep sound and it is used for output.
            Console.ReadLine();//it is used to read the input from the console and it is used for input.
            Console.Beep();//it is used to make a beep sound and it is used for output.
        }
    }
}
