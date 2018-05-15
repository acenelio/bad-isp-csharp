namespace Course.Entities {
    interface BankingProduct {

        void deposit(double amount);
        void withdraw(double amount);
        void loan(double amount);
        void pay(double amount);
    }
}
