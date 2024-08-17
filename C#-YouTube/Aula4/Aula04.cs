using System;

class Aula04{

    static void Main(){

        // bool é o tipo booleano
        bool nm = 10<5;

        //Operadores relacionais <= >= == != < >

        int num = 10;

        //num ++;OU num += 1; OU num = num + 1;
        num *= 2; // + - / *
        
        int res = (10 + 5)*2;

        Console.WriteLine(res);
        System.Console.WriteLine(nm);
        System.Console.WriteLine(num);

        // & = AND / E
        // | = OR / OU

        bool res2 = (5 > 3) | (10 < 5);

        System.Console.WriteLine(res2);
    }
}