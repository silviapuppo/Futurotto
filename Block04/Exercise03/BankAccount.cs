using System;
using System.Collections.Generic;

namespace Exercise03
{
    public class Utilities
    {
        public double Value { get; set; }
        public int DayPeriod { get; set; }

    }

    public class BankAccount
    {
        public double CurrentBalance { get; set; }
        public DateTime OpeningDate { get; set; }
        public string Branch { get; set; }
        public double PayableInterests { get; set; }
        public double ReceivableInterests { get; set; }
        public Utilities Utility { get; set; }
        public double BankingCosts { get; set; }
    }
}
