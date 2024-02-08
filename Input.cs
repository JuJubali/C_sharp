using System;

using namespace Input{
    class Program;

        static void Main (string[] args){

            Console.WriteLine('Hello World');
            //int num = 123;
            string nome = Console.ReadLine();
            Console.WriteLine('Digite o seu nome: ');
            Console.WriteLine('\n {nome}');
            Console.WriteLine($"Seu nome e: {0}", nome); // Aspas duplas
            //string str = string.Format('Seu nome e: {0}', nome);
            //Console.WriteLine($"Seu nome e: {nome}");
            //Console.WriteLine($"O numero e: {0}", num); 

            string str = "Azul";
            string strFormat = string.Format("A cor e: {0}", str);  
            Console.WriteLine(strFormat);
        }
}