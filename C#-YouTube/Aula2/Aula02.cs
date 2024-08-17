using System;

class Aula2{

    static void Main(){

    // Tipo/Nome
        byte n1=10; // entre 0 e 255
        int num=-10;
        char letra='c'; // somente um caracter
        float valor=10.5f;  //f para relacionar a float
        string nome="Luiz";

      //Declarar multiplas variaveis  
        int num1,num2,res; // e pode tbm num1 = 10, num2 = 20, res = num1 * num2;
        num1 = 10;
        num2 = 2;
        res = num1 * num2;

        var aux=10; // Não expecificado por nos, mas o sistema q define

        Console.WriteLine("Valor da variavel: " + aux);

        Console.WriteLine("A Multiplicação de " + num1 + " x " + num2 + " é igual a: " + res); // ou num1 * num2
    }
}