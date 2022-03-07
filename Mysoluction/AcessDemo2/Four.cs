using System;

namespace AcessDemo2
{
    class Four : AccessDemom.Program
    {
        //consuming the mumbers of a class in different project
        static void Main(string[] args)
        {
            Four f = new Four();
            f.Test3_Protected();
            f.Test4_ProtecedInternal();
            f.Test5_Public();
            Console.ReadLine();
        }
    }
}
