using System;

namespace CSharpHelloWorld
{
    class HelloWorl
    {
        static void Main(string[] args)
        {   
            // Hola mundo
            Console.WriteLine("Hello, C#");

            /*
            Esto
            es
            un
            comentario
            */

            string myString = "Esto es una cadena de texto";
            myString = "Aqui cambia el valor de la cadena de texto";
            Console.WriteLine(myString);

            int myInt = 10;
            myInt = myInt + 8;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 6);
            Console.WriteLine(myInt);

            double myDouble = 6.5;
            Console.WriteLine(myDouble);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            bool myBool = true;
            myBool =  false;
            Console.WriteLine(myBool);


            Console.WriteLine(myDouble + myFloat + myInt);

            var myVar = "Mi variable de tipo inferido";
            // myVar = 6; Error
            Console.WriteLine(myVar);


            Console.WriteLine($"El valor de mi entero es {myInt} y el de mi bool es {myBool}");

            const string MyConst = "Mi constante"; //upper camelcase para el nombre
            Console.WriteLine(MyConst);

            // Estructuras

            var myArray = new string [] {"Daniel","Rodriguez","Sanchez"};
            Console.WriteLine(myArray[0]);

            myArray[2] = "32";
            Console.WriteLine(myArray[2]);

            var myDictionary = new Dictionary<string, int>
            {
                {"Daniel", 32},
                {"Emily", 25}
            };

            Console.WriteLine(myDictionary["Emily"]);

            var mySet = new HashSet<string> {"Daniel","Rodriguez","Sanchez"};
            Console.WriteLine();


        }
    }
}
