using System;

namespace Course.Entities {
    class HomeLoan : BankingProduct {

        public double BalanceDue { get; set; }

        public void deposit(double amount) {
            throw new InvalidOperationException("Invalid operation");
        }

        public void loan(double amount) {
            BalanceDue += amount;
        }

        public void pay(double amount) {
            BalanceDue -= amount;
        }

        public void withdraw(double amount) {
            throw new InvalidOperationException("Invalid operation");
        }
    }
}
