using LanguageAppLib.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LanguageAppLib.Service
{
    public class WordService
    {
        private AppDbContext _dbContext;

        public WordService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Word> GetFourWords(Language languageFrom, Language languageTo)
        {
            List<Word> words = (from word in _dbContext.Words
                                where languageFrom.Id == word.TextLanguage.Id && languageTo.Id == word.TranslationLanguage.Id
                                select word).ToList();
            for(int i =0; i < 4;i++)
            {
                yield return words[new Random(Guid.NewGuid().GetHashCode()).Next(words.Count)];
            }
        }
    }
}
