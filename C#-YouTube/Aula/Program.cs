using System;

namespace aula{

    class Program{

        static void Main(string[] arg){

            Console.WriteLine("Ola Mundo");
            if(arg.GetLength(0)>0){
                Console.Write(arg.GetValue(0));
            }
        }
    }
}
