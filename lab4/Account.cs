using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Account
    {
        private int _acNumber;
        private double _balance;
        private string _ownName;
        private double _monthlyDepositAmount;
        


        public static double MonthlyFee = 4.0;
        public static double MonthlyInterestRate = 0.0025;
        public static int MinimumInitialBalance = 1000;
        public static int MinimumMonthDeposit = 50;


        public  int AccountNumber 
        {
            get {
                return this._acNumber;
            }
            set {
                this._acNumber = value;
            }
        }

        
        public string AccountOwner
        {
            get
            {
                return _ownName;
            }
            set
            {
                this._ownName = value;
            }
        }

        public double AccountBalance
        {
            get
            {
                return this._balance;
            }
            set
            {
                this._balance = value;
            }
        }

        public double MonthlyDepositAmount
        {
            get
            {
                return _monthlyDepositAmount;
            }
            set
            {
                _monthlyDepositAmount = value;
            }
        }

        public void Deposit(double MonthlyDepositAmount)
        {
            if (MonthlyDepositAmount < MinimumMonthDeposit)
            {
                AccountBalance += MinimumMonthDeposit;
            }
           AccountBalance +=( MonthlyDepositAmount + AccountBalance * MonthlyInterestRate);

        }

        public void Withdraw(double MonthlyDepositAmount)
        {
            if (AccountBalance >= MonthlyDepositAmount)
            {
                AccountBalance -= MonthlyDepositAmount;
            }  
        }
        public double Deduction()
        {
            //Deduction Fee
            AccountBalance -= MonthlyFee;
            return AccountBalance;
        }
        public Account(string accountOwner, double accountBalance)
        {
            _ownName = accountOwner;
            _balance = accountBalance;
            if (AccountBalance<MinimumInitialBalance)
            {
                AccountBalance = MinimumInitialBalance;
            }
            //Generate random users account number
            Random random = new Random();
            _acNumber = random.Next(90000, 99999);
        }




    }
}