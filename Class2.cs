﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SavingsAccount
    {

       
        public double balance;
        public const int transactionlimit = 200;
        public int poso_analipsis=0;
       // public int poso_katathesis=0;
        public const  double interestrate = 0.01;
        public double interest;
        public SavingsAccount(int amount)
        {

            this.balance = amount;

        }


        public void withdraw(int amount)
        {
            if (amount <= transactionlimit && amount <= balance)
            {

                this.balance = this.balance - amount;
                this.poso_analipsis = amount;
            }
            else
            {
                this.poso_analipsis = 0;
                Console.WriteLine("Η ΑΝΑΛΗΨΗ ΔΕΝ ΕΓΙΝΕ"); }
        }

        public void deposit(int amount)
        {

            this.balance = this.balance + amount;

        }


        public void addinterest()
        {    
            this.interest = interestrate * this.balance;
            this.balance = this.balance + this.interest;

        }

    }
}
