﻿using Practice.Mef.Service.Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Mef.Service.SimpleCalculator
{
    [Export(typeof(IOperation))]
    [ExportMetadata("Symbol", '-')]
    class Subtract : IOperation
    {

        public int Operate(int left, int right)
        {
            return left - right;
        }

    }
}
