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

            account.Owners.Add(ibb);

            Assert.AreEqual("Ibb", account.Owners[0].Name);
        }

        [TestMethod]
        public void TestBankAccountDeposit()
        {
            BankAccount account = new BankAccount(1000, DateTime.Now, "Genova 2", 0.05, 0.01, 2.10, AccountType.Current);
            Costumer ibb = new Costumer("Ibb", 1234);

            account.Owners.Add(ibb);
            ibb.Deposit(1000, account);

            Assert.AreEqual(2000, account.CurrentBalance);
        }

        [TestMethod]
        public void TestBankAccountWithDraw()
        {
            BankAccount account = new BankAccount(1000, DateTime.Now, "Genova 2", 0.05, 0.01, 2.10, AccountType.Current);
            Costumer ibb = new Costumer("Ibb", 1234);

            account.Owners.Add(ibb);
            ibb.Withdraw(1000, account);

            Assert.AreEqual(0, account.CurrentBalance);
        }

        [TestMethod]
        public void TestBankAccountTransfer()
        {
            BankAccount account1 = new BankAccount(4000, DateTime.Now, "Genova 2", 0.05, 0.01, 2.10, AccountType.Current);
            BankAccount account2 = new BankAccount(2000, DateTime.Now, "Genova 2", 0.05, 0.01, 2.10, AccountType.Current);
            Costumer ibb = new Costumer("Ibb", 1234);
            Costumer obb = new Costumer("Obb", 4321);

            account1.Owners.Add(ibb);
            account2.Owners.Add(obb);

            ibb.Transfer(1000, account1, account2);

            Assert.AreEqual(3000, account1.CurrentBalance);
            Assert.AreEqual(3000, account2.CurrentBalance);
        }
    }
}
