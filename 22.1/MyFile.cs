using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _22._1
{
    public class MyFile
    {
        public MyFile(string fileName, int linesNum)
        {
            Name = fileName + ".txt";
            LinesNum = linesNum;
            ValidFile();
            Random = new Random(DateTime.Now.Millisecond);
            thread = new Thread(AddRandomNumLines);
        }

        private Random Random { get; set; }
        public int LinesNum;
        public Thread thread;

        public string Name
        { get; set; }

        public void ValidFile()
        {
            try
            {
                if (!File.Exists(Name)) File.Create(Name).Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddLine(string line)
        {
            FileInfo file = new FileInfo(Name);   // create a FileInfo object to check the size of the file

            using (StreamWriter sw = File.AppendText(Name))
            {
                sw.WriteLine(line);
            }
        }

        public void AddRandomNumLines()
        {
            try
            {
                for (int i = 1; i <= LinesNum; i++)
                {
                    string rand = Random.Next().ToString();
                    AddLine(rand);
                    Console.WriteLine($"{Name} , {rand} , {i}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}