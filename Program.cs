using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Files;

List<Indirizzo> indirizzi = new List<Indirizzo>();

if (!File.Exists("indirizzi.txt"))
    Console.WriteLine("File non trovato!");
else
{
    StreamReader sr = File.OpenText("indirizzi.txt");

    string? firstLine = sr.ReadLine();

    while (!sr.EndOfStream)
    {
        string? line = sr.ReadLine();
        if (line != null)
        {
            string[] campi = line.Split(',');
            if (campi.Length >= 6)
            {
                Console.WriteLine("UTENTE:");
                Console.WriteLine($"\tNome: {campi[0]}");
                Console.WriteLine($"\tCognome: {campi[1]}");
                Console.WriteLine($"\tVia: {campi[2]}");
                Console.WriteLine($"\tCittà: {campi[3]}");
                Console.WriteLine($"\tProvincia: {campi[4]}");
                Console.WriteLine($"\tZip: {campi[5]}");
                //indirizzi.Add(new Indirizzo(campi[0], campi[1], campi[2], campi[3], campi[4], campi[5]));
            }
        }
    }
    sr.Close();
}