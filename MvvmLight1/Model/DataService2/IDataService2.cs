﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvvmLight1.Model
{
    public interface IDataService2
    {
        void GetData(Action<DataItem2, Exception> callback);
    }
}
