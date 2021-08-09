using System;

namespace LerArquivoTXT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int counter = 0;
            string line;

            System.IO.StreamReader file = new(@"C:\Users\Willian\Desktop\COLETOR (2).TXT");

            while ((line = file.ReadLine()) != null)
            {
                var pos1 = line.Substring(0,0);
                var barcode = line.Substring(1, 13);
                var nomeProduto = line.Substring(14,35);
                var qtdEmb = line.Substring(75,2);

                Console.WriteLine(barcode + " -  " + nomeProduto + " - Qtd.Emb.:" + qtdEmb);
                counter++;
            }

            file.Close();
            Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            Console.ReadLine();
        }
    }
}
