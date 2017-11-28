using System;
using System.Collections.Generic;

namespace Exercise03
{
    public enum AccountType
    {
        Saving, Current
    }

    public enum OperationType
    {
        Deposit, Withdraw, Transfer, FailedOp
    }

    public struct Utility
    {
        public double Value { get; set; }
        public int DayPeriod { get; set; }

        public Utility(double value, int dayPeriod) : this()
        {
            Value = value;
            DayPeriod = dayPeriod;
        }
    }

    public struct Operation
    {
        public OperationType Type { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Operation(OperationType type, string description, DateTime date) : this()
        {
            Type = type;
            Description = description;
            Date = date;
        }
    }

    public class BankAccount
    {
        private double currentBalance;
        public DateTime OpeningDate { get; private set; }
        public string Branch { get; set; }
        public double PayableInterests { get; set; }
        public double ReceivableInterests { get; set; }
        public List<Utility> Utilities { get; set; } = new List<Utility>();
        public double BankingCosts { get; set; }
        public List<Costumer> Owners { get; set; } = new List<Costumer>();
        public AccountType Type { get; set; }
        private List<Operation> record = new List<Operation>();

        public double CurrentBalance
        {
            get
            {
                
                return currentBalance;
            }
            set
            {
                currentBalance = value;
            }
        }


        public List<Operation> Record
        {
            get
            {
                foreach (Operation o in record)
                {
                    if ((DateTime.Now - o.Date).Days >= 30)
                    {
                        record.Remove(o);
                    }
                }
                return record;
            }
            private set
            {
                record = value;
            }
        }

        public BankAccount(double currentBalance, DateTime openingDate, string branch, double payableInterests, double receivableInterests, double bankingCosts, AccountType type)
        {
            CurrentBalance = currentBalance;
            OpeningDate = openingDate;
            Branch = branch;
            PayableInterests = payableInterests;
            ReceivableInterests = receivableInterests;
            BankingCosts = bankingCosts;
            Type = type;
        }


    }

    public class Costumer
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Costumer(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void Deposit(double amount, BankAccount account)
        {
            account.CurrentBalance += amount;
            account.Record.Add(new Operation(OperationType.Deposit, "Deposit of €" + amount, DateTime.Now));
        }

        public void Withdraw(double amount, BankAccount account)
        {
            if (account.Type == AccountType.Current)
            {
                account.CurrentBalance -= amount;
                account.Record.Add(new Operation(OperationType.Withdraw, "Withdraw of €" + amount, DateTime.Now));
            }
            else
            {
                account.Record.Add(new Operation(OperationType.FailedOp, "Attempted withdraw of €" + amount, DateTime.Now));
            }
        }

        public void Transfer(double amount, BankAccount from, BankAccount to)
        {
            from.CurrentBalance -= amount;
            to.CurrentBalance += amount;
            from.Record.Add(new Operation(OperationType.Transfer, "Transfer to others €" + amount, DateTime.Now));
            to.Record.Add(new Operation(OperationType.Transfer, "received from others €" + amount, DateTime.Now));
        }
    }

}
