using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakBot
{
    public class Language
    {
        public string lang { get; }
        public object langCode { get; }
        public Language(string lang, string langCode)
        {
            this.langCode = langCode;
            this.lang = lang;
        }
    }
}
