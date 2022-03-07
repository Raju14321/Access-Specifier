using System;

namespace AccessDemom
{
    public class Program
    {
        //Case 1 consuming members of a class from same class
        private void Test1_Private()
        {
            Console.WriteLine("Private Method");
        }
        internal void Test2_Internal()
        {
            Console.WriteLine("Internal Method");
        }
        protected void Test3_Protected()
        {
            Console.WriteLine("Protected Method");
        }
        protected internal void Test4_ProtecedInternal()
        {
            Console.WriteLine("Protected Internal Method");
        }
        public void Test5_Public()
        {
            Console.WriteLine("Public Method");
        }
        private protected void Test6_PrivateProtected()
        {
            Console.WriteLine("Private Protected Method");
        }

        //static void Main()
        //{
        //    Program p = new Program();
        //    p.Test1_Private();
        //    p.Test2_Internal();
        //    p.Test3_Protected();
        //    p.Test4_ProtecedInternal();
        //    p.Test5_Public();
        //    p.Test6_PrivateProtected();
        //    Console.ReadLine();
        //}

    }
}
     