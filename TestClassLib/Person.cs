using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassLib
{
    /// <summary>
    /// Person's
    /// </summary>
    /// <param>
    /// </param>
    public class Person
    {
        public Person()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public string Name { get; set; }
        public int Age { get; set; }
            
}
