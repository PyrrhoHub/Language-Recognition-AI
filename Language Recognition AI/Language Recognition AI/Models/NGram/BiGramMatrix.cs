﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Recognition_AI
{
    public class BiGramMatrix : NGramMatrix
    {
        public override void Train(LanguageRecords[] languageRecords)
        {
            Train<BiGram>(languageRecords);
        }
    }
}