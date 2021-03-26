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
        /// <summary>
        /// Метод для получения 4х слов для игры
        /// </summary>
        /// <param name="languageFrom">Язык с которого переводим</param>
        /// <param name="languageTo">Язык на который переводим</param>
        /// <returns>Возвращает список слов</returns>
        public List<Word> GetFourWords(Language languageFrom, Language languageTo)
        {
            List<Word> words = (from word in _dbContext.Words
                                where languageFrom.Id == word.TextLanguage.Id && languageTo.Id == word.TranslationLanguage.Id
                                select word).ToList();
            List<Word> result = new List<Word>();
            for(int i =0; i < 4;i++)
            {
                result.Add(words[new Random(Guid.NewGuid().GetHashCode()).Next(words.Count)]);
            }
            return result;
        }
    }
}
