using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExtractBytes
{
    public class ExtractBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using var streamReader = new StreamReader(bytesFilePath);
            using var streamWriter = new StreamWriter(outputPath);

            byte[] bytes = File.ReadAllBytes(binaryFilePath);

            var list = new List<string>();

            var stringBuilder = new StringBuilder();

            while (!streamReader.EndOfStream)
            {
                list.Add(streamReader.ReadLine());
            }

            foreach (var b in bytes)
            {
                if (list.Contains(b.ToString()))
                {
                    stringBuilder.AppendLine(b.ToString());
                }
            }

            streamWriter.WriteLine(stringBuilder.ToString());
        }
    }
}