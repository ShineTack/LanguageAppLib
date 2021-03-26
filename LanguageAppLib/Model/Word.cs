using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageAppLib.Model
{
    /// <summary>
    /// Модель слова
    /// </summary>
    [Index(nameof(Text), nameof(TextLanguage), nameof(Translation), nameof(TranslationLanguage))]
    public class Word
    {
        /// <summary>
        /// Id слова в таблице, 
        /// указываем его int так как в данной ситуации безопасность нас не интересует
        /// а GUID занимает больше памяти
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Текст слова.
        /// Является частью комбинированного индекса
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Язык слова.
        /// Является частью комбинированного индекса
        /// </summary>
        public Language TextLanguage { get; set; }
        /// <summary>
        /// Транскрипция слова.
        /// </summary>
        public string Transcription { get; set; }
        /// <summary>
        /// Перевод слова.
        /// Является частью комбинированного индекса
        /// </summary>
        public string Translation { get; set; }
        /// <summary>
        /// Язык перевода.
        /// Является частью комбинированного индекса
        /// </summary>
        public Language TranslationLanguage { get; set; }
        /// <summary>
        /// Является ли слово избранным.
        /// </summary>
        public bool IsFavorite { get; set; }
    }
}
