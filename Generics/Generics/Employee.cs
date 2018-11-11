using System;
using System.Collections.Generic;

namespace Generics
{
    //1. Make the Employee class take a generic type parameter.
    public class Employee<T>
    {
        //2. Add a property to the Employee class called "things" and have its 
        //data type be a generic list matching the generic type of the class.
        public List<T> Things { get; set; }
    }
}



    

