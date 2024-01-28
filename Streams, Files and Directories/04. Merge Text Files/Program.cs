using System;
using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main(string[] args)
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
           
            StreamReader reader1 = new StreamReader(firstInputFilePath);
            StreamReader reader2 = new StreamReader(secondInputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);


            using (reader1) 

            {
                using (reader2)
                {

                    using (writer)
                    {

                   
                    while (!reader1.EndOfStream || !reader2.EndOfStream)
                    {
                            string line1 = reader1.ReadLine();                            
                            string line2 = reader2.ReadLine();
                            
                            if (line1 != null && line2 !=null)
                            {
                                writer.WriteLine(line1);
                                writer.WriteLine(line2);
                            }

                            else if (line1 == null)
                            {
                                
                                writer.WriteLine(line2);

                            }
                            else if (line2 == null)
                            {
                               
                                writer.WriteLine(line1);
                            }
                    }

                }
                }
            }
        }
    }
}