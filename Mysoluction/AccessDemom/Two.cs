using System;
using System.Collections.Generic;
using System.Text;

namespace AccessDemom
{
    class Two : Program
    {
        //Case 2consuming members of a class from a child class in the same project)
        static void Main()
        {
            Two t = new Two();
            t.Test2_Internal();
            t.Test3_Protected();
            t.Test4_ProtecedInternal();
            t.Test5_Public();
            t.Test6_PrivateProtected();
        }
    }
}
