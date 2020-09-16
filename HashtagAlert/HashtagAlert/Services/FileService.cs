using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashtagAlert.Services
{
    public static class FileService
    {
        public static List<string> LoadFile()
        {
            var wordList = new List<string>();

            try
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Renato\Documents\GitHub\HashtagAlert\HashtagAlert\HashtagAlert\Hashtags.txt");
                
                wordList = lines.ToList<string>();
            }
            catch (Exception)
            {
                wordList.Add("Erro ao carregar o arquivo");
                wordList.Add("Verifique se o arquivo existe e se as palavras estão " +
                    "separadas por virgula");
            }

            return wordList;
        }
    }
}
