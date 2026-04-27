namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount bankAccount = new BankAccount("Rashik");

            BankAccount bankAccount2 = new BankAccount("Elon");
            
            BankAccount bankAccount3 = new BankAccount("Bill");
            
            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);

            BankAccountsGrid.DataSource = bankAccounts;
        }
    }
}
