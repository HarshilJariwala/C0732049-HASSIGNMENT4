using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732049_Assignment4
{
    class Program
    {
        ArrayList Beowulf;

        static void Main(string[] args)
        {
            Program p = new Program();

            p.Beowulf = new ArrayList();

            p.ReadTextFiles();
            p.WordCounter();
            p.find();
            p.skipp();
            Console.ReadLine();

        }  

        public void Run()
        {
            this.ReadTextFiles();
        }
        public void ReadTextFiles()
        {
            // Read file using StreamReader. Read file line by line
            using (StreamReader file = new StreamReader("Beowulf.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }

                counter = File.ReadLines("Beowulf.txt").Count();
                Console.WriteLine("\n\n\nFile has "+counter+" lines.");
                file.Close();
            }

        }

        public int FindNumberOfBlankSpaces(string line)
        {
                                                                                                                                                                                                                                                                                                                                                                                                   
            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countletters++; }
            }
            return countSpaces;

        }
        public void WordCounter()
        {
            StreamReader reader = new StreamReader("Beowulf.txt");
            string script = reader.ReadToEnd();

            var text = script.Trim();
           int wordCount = 0;
           int index = 0;

            while (index < text.Length)
            {
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;
                wordCount++;
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }
            Console.WriteLine("File has "+wordCount+" word.");
        }
        public void find()
        {
            int f = 0;
            foreach (var line in File.ReadAllLines("Beowulf.txt"))
            {
                f++;
                if (line.Contains("sea") && line.Contains("fare"))
                {
                    Console.WriteLine("The line " + f + " contains both sea and Fare");
                }
            }
            
                
        }

        public void skipp()
        {
            int x = 0, y = 0, z =0;
  
            foreach (var line in File.ReadAllLines("Beowulf.txt"))
            {
                if (line.Contains("fare") && line.Contains("war"))
                {
                    if (line.Contains("war") && line.Contains("fare"))
                    {
                        y++;
                    }
                }
            }

          

        }
    }
}
