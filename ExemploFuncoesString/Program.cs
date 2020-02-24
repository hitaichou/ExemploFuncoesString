using System;

namespace ExemploFuncoesString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            //convertendo para maiúsculo
            string s1 = original.ToUpper();
            //convertendo para minúsculo
            string s2 = original.ToLower();
            //convertendo para trim - remove espaço antes e depois da variável
            string s3 = original.Trim();
            //procura pela primeira ocorrência do valor da váriavel
            int n1 = original.IndexOf("bc");
            //procura pela última ocorrência do valor da váriavel
            int n2 = original.LastIndexOf("bc");
            //inicia a variável de acordo com o index adicionado na função
            string s4 = original.Substring(3);
            //inicia a variável de acordo com o index adicionado na função e finaliza no limite do index inserido na função
            string s5 = original.Substring(3,5);
            //troca um caracter pelo outro
            string s6 = original.Replace('a','x');
            //troca uma string pela outra
            string s7 = original.Replace("abc", "xy");
            //testa se a string é nula ou vazia.
            bool b1 = String.IsNullOrEmpty(original);
            //testa se a string é nula ou possui somente espaço em branco.
            bool b2 = String.IsNullOrWhiteSpace(original);
            

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("--");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("--");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("--");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("--");
            Console.WriteLine("IndexOf: ('bc') " + n1);
            Console.WriteLine("--");
            Console.WriteLine("LastIndexOf: ('bc') " + n2);
            Console.WriteLine("--");
            Console.WriteLine("Substring(3) -" + s4 + "-");
            Console.WriteLine("--");
            Console.WriteLine("Substring(3,5) -" + s5 + "-");
            Console.WriteLine("--");
            Console.WriteLine("Replace -" + s6 + "-");
            Console.WriteLine("--");
            Console.WriteLine("Replace ('abc','xy') -" + s7 + "-");
            Console.WriteLine("--");
            Console.WriteLine("IsNullOrEmpty -" + b1 + "-");
            Console.WriteLine("--");
            Console.WriteLine("IsNullOrWhiteSpace -" + b2 + "-");
            Console.WriteLine("--");
        }
    }
}
