using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main(string[] args)
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";




            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordsAndCount = new Dictionary<string, int>();
            using (StreamReader readerWords = new StreamReader(wordsFilePath))
            {
                using (StreamReader readerText = new StreamReader(textFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {

                        string[] words = readerWords.ReadLine().Split();

                        while (!readerText.EndOfStream)
                        {
                            string textLine = readerText.ReadLine().ToLower();
                            textLine= textLine.Replace('-', ' ');
                            textLine= textLine.Replace(".", " ");
                            textLine= textLine.Replace(",", " ");

                            foreach (var word in words)
                            {


                                if (textLine.Contains(word))
                                {
                                    if (!wordsAndCount.ContainsKey(word))
                                    {
                                        wordsAndCount.Add(word, 0);
                                    }
                                    wordsAndCount[word]++;


                                }



                            }

                        }
                            foreach (var word in wordsAndCount.OrderByDescending(x=>x.Value))
                            {
                                writer.WriteLine($"{word.Key} - {word.Value}");
                            }
                    }
                }


            }
        }
    }
}