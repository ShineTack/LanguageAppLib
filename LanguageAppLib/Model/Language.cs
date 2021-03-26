using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageAppLib.Model
{
    /// <summary>
    /// Модель обьекта языка
    /// </summary>
    [Index(nameof(Name))]
    class Language
    {
        /// <summary>
        /// Id языка в таблице 
        /// указываем его интом так как в данной ситуации безопасность нас не интересует
        /// а GUID занимает больше памяти
        /// </summary>
        public byte Id { get; set; }
        /// <summary>
        /// Название языка
        /// атрибут Index указывает на то что колонка в таблице имеет уникальное значение
        /// </summary>
        public string Name { get; set; }
    }
}
