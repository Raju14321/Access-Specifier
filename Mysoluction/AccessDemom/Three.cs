using System;
using System.Collections.Generic;
using System.Text;

namespace AccessDemom
{
    class Three
    {
        //Case:3 consuming memburs of a non-child class
        static void Main()
        {
            Program p = new Program();
            
            p.Test2_Internal();
            p.Test4_ProtecedInternal();
            p.Test5_Public();
            Console.ReadLine();
        }
    }
}
