using System.Reflection.Emit;

namespace June_july_111224
{
    class AA
    {
        public AA()
        {
            Console.WriteLine("AA created");
        }
        ~AA()
        {
            Console.WriteLine("distructor called or object deleted...");
        }
    }

    class myclass
    {
        public void method1()
        {
            Console.WriteLine("start of method1");
            AA obj = new AA();


            Console.WriteLine("end of method1");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5/2);
            Console.WriteLine("***************");
            string s1 = "abcdDBA";


            string s2 = new string(s1.Reverse().ToArray());

            if (string.Equals(s1, s2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"string {s1} is palindrom");
            }
            else
            {
                Console.WriteLine($"string {s1} is NOT palindrom");
            }

            /*
             * **************************************************************************
            char[] temp=new char[s1.Length];
            char[]tempOld=new char[s1.Length];
            for (int i = 0; i < s1.Length; i++)
            {
                temp[i] = s1.ElementAt(i);
                tempOld[i]=s1.ElementAt(i);
            }
            int j = temp.Length - 1;
            //for (int i = 0; i < temp.Length/2; i++)
             for (int i = 0; i <j; i++)
            {
                char t=temp[i];
                temp[i] = temp[j];
                temp[j] = t;
                j--;
            }
            for (int i = 0; i < temp.Length; i++) {
                Console.WriteLine(temp[i]);
            }
          
            //---------------compare logic for palindrom

            bool Flag = true;
            for (int i = 0; i < tempOld.Length; i++) 
            {
                //if (temp[i] != tempOld[i])
                //{
                //    Flag = false;
                //    break;
                //}
                int old = (int)tempOld[i];
                int new1= (int)temp[i];
                if (( new1- old)!=0 &&(new1-old!=32) && (new1 - old != -32))
                {
                    Flag = false;
                    break;

                }
            }
            if (Flag)
            {
                Console.WriteLine("String is palindrom");
            }
            else
            {
                Console.WriteLine("String is not Palindrom");
            }
            */
        }
    }
}
