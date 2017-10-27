﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IModelFacade
    {
        void TrainModel(LanguageRecords[] languagerecords);

        ValidationReport ValidateModel(LanguageRecords[] languagerecords);        

        Dictionary<string, double> ValidateSentence(string sentence);
    }
}