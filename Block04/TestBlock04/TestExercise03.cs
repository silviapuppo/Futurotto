using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise03;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise03
    {
        [TestMethod]
        public void TestBankAccount()
        {
            BankAccount account = new BankAccount(1000, DateTime.Now, "Genova 2", 0.05, 0.01, 2.10, AccountType.Current);
            Costumer ibb = new Costumer("Ibb", 1234);

            account.AddCostumer(ibb);

            Assert.AreEqual("Ibb", account.Owners[0].Name);
        }

        [TestMethod]
        public void TestBankAccountDeposit()
        {
            BankAccount account = new BankAccount(1000, DateTime.Now, "Genova 2", 0.05, 0.01, 2.10, AccountType.Current);
            Costumer ibb = new Costumer("Ibb", 1234);

            account.AddCostumer(ibb);
            ibb.Deposit(1000, account, DateTime.Now);

            Assert.AreEqual(2000, account.CurrentBalance);
        }

        [TestMethod]
        public void TestBankAccountWithDraw()
        {
            BankAccount account = new BankAccount(1000, DateTime.Now, "Genova 2", 0.05, 0.01, 2.10, AccountType.Current);
            Costumer ibb = new Costumer("Ibb", 1234);

            account.AddCostumer(ibb);
            ibb.Withdraw(1000, account, DateTime.Now);

            Assert.AreEqual(0, account.CurrentBalance);
        }

        [TestMethod]
        public void TestBankAccountTransfer()
        {
            BankAccount account1 = new BankAccount(4000, DateTime.Now, "Genova 2", 0.05, 0.01, 2.10, AccountType.Current);
            BankAccount account2 = new BankAccount(2000, DateTime.Now, "Genova 2", 0.05, 0.01, 2.10, AccountType.Current);
            Costumer ibb = new Costumer("Ibb", 1234);
            Costumer obb = new Costumer("Obb", 4321);

            account1.AddCostumer(ibb);
            account2.AddCostumer(obb);

            ibb.Transfer(1000, account1, account2, DateTime.Now);

            Assert.AreEqual(3000, account1.CurrentBalance);
            Assert.AreEqual(3000, account2.CurrentBalance);
        }

        [TestMethod]
        public void TestBankAccountRecord()
        {
            BankAccount account1 = new BankAccount(4000, DateTime.Now, "Genova 2", 0.05, 0.01, 2.10, AccountType.Current);
            BankAccount account2 = new BankAccount(2000, DateTime.Now, "Genova 2", 0.05, 0.01, 2.10, AccountType.Current);
            Costumer ibb = new Costumer("Ibb", 1234);
            Costumer obb = new Costumer("Obb", 4321);
            TimeSpan diff20 = (new DateTime(2017, 10, 30) - new DateTime(2017, 10, 10));
            TimeSpan diff40 = (new DateTime(2017, 10, 30) - new DateTime(2017, 09, 20));

            account1.AddCostumer(ibb);
            account2.AddCostumer(obb);

            ibb.Withdraw(500, account1, DateTime.Now.Subtract(diff40));
            ibb.Transfer(2000, account1, account2, DateTime.Now.Subtract(diff20));

            Assert.AreEqual(1500, account1.CurrentBalance);
            Assert.AreEqual(4000, account2.CurrentBalance);
            Assert.AreEqual(1, account1.Record.Count);
            Assert.AreEqual("Transfer to others €2000", account1.Record[0].Description);
            Assert.AreEqual("Received from others €2000", account2.Record[0].Description);
        }

    }
}
