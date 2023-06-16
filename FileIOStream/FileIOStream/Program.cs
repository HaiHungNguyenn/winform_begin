using System;
using System.IO;


namespace FileIOStream { 
    /*
    class Program
    {
        static void Main(string[] args) {
            String path = @"MyFile.txt";
            if (!File.Exists(path)){
                using StreamWriter sw = File.CreateText(path);
                sw.WriteLine("hello");
                sw.WriteLine("And");
                sw.WriteLine("welcome");

            }
            using StreamReader sr = File.OpenText(path);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
    */
    /*
      class Program2 {
        static void Main(string[] args)
        {
            String path = @"MyData.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }
            string appendText = "This is extra text " + Environment.NewLine;
            File.AppendAllText(path, appendText);
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            Console.ReadLine();
        }    
    }
    */
    class Program3
    {
        static void Main(string[] args) {
            string input = null;
            string filename = @"MyData.txt";
            Console.WriteLine("*** Demo StreamWriter and StreamReader *** \n");
            using StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine("Hello Monkey");
            writer.WriteLine("!");
            for(int i = 1; i < 10; i++) {
                writer.Write(i + " ");

            }
            writer.Write(writer.NewLine);
            writer.Close();
            Console.WriteLine("File was created");
            Console.WriteLine("****************");
            Console.WriteLine("Now read date");
            using StreamReader reader = new StreamReader(filename); 
            while((input  = reader.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            reader.Close();
            Console.ReadLine();
        }
    }
}
