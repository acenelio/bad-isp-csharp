using System;

namespace Course.Entities {
    class Account : BankingProduct {

        public int Number { get; set; }
        public double Balance { get; set; }

        public void deposit(double amount) {
            Balance += amount;
        }

        public void loan(double amount) {
            Balance += amount;
        }

        public void pay(double amount) {
            throw new InvalidOperationException("Invalid operation");
        }

        public void withdraw(double amount) {
            Balance -= amount;
        }
    }
}
