﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Abstractions
{
    public interface ITradeValidator
    {
        bool ValidateTrades(string[] fields, int lineCount);
    }
}
