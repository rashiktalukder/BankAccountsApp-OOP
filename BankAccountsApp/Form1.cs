namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount bankAccount = new BankAccount();
            bankAccount.Owner = "Rashik";
            bankAccount.AccountNumber = Guid.NewGuid();
            bankAccount.Balance = 250;

            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.Owner = "Elon";
            bankAccount2.AccountNumber = Guid.NewGuid();
            bankAccount2.Balance = 9999;

            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.Owner = "Bill";
            bankAccount3.AccountNumber = Guid.NewGuid();
            bankAccount3.Balance = 2750;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);

            BankAccountsGrid.DataSource = bankAccounts;
        }
    }
}
