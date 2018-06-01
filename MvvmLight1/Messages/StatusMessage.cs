﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight1.Messages
{
    public class StatusMessage
    {
        public StatusMessage(
          string status,
          int timeoutMilliseconds)
        {
            Status = status;
            TimeoutMilliseconds = timeoutMilliseconds;
        }
        public string Status
        {
            get; private set;
        }
        public int TimeoutMilliseconds
        {
            get; private set;
        }
    }
}
