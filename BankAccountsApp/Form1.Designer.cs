namespace BankAccountsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            DepositeBtn = new Button();
            WithdrawBtn = new Button();
            CreateAccountBtn = new Button();
            label3 = new Label();
            InterestRateNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 27);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 38);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 454);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 38);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(153, 27);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(269, 43);
            OwnerTxt.TabIndex = 2;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(170, 454);
            AmountNum.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 1410065407, 2, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(252, 43);
            AmountNum.TabIndex = 3;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(606, 27);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 51;
            BankAccountsGrid.Size = new Size(835, 417);
            BankAccountsGrid.TabIndex = 4;
            // 
            // DepositeBtn
            // 
            DepositeBtn.BackColor = SystemColors.ButtonShadow;
            DepositeBtn.Location = new Point(611, 454);
            DepositeBtn.Name = "DepositeBtn";
            DepositeBtn.Size = new Size(398, 59);
            DepositeBtn.TabIndex = 5;
            DepositeBtn.Text = "Deposite";
            DepositeBtn.UseVisualStyleBackColor = false;
            DepositeBtn.Click += DepositeBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.BackColor = SystemColors.ButtonShadow;
            WithdrawBtn.Location = new Point(1032, 454);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(398, 59);
            WithdrawBtn.TabIndex = 6;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = false;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.BackColor = SystemColors.ButtonShadow;
            CreateAccountBtn.Location = new Point(148, 167);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(269, 59);
            CreateAccountBtn.TabIndex = 7;
            CreateAccountBtn.Text = "Create Account";
            CreateAccountBtn.UseVisualStyleBackColor = false;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 104);
            label3.Name = "label3";
            label3.Size = new Size(179, 38);
            label3.TabIndex = 8;
            label3.Text = "Interest Rate:";
            // 
            // InterestRateNum
            // 
            InterestRateNum.Location = new Point(222, 102);
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size(200, 43);
            InterestRateNum.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 512);
            Controls.Add(InterestRateNum);
            Controls.Add(label3);
            Controls.Add(CreateAccountBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositeBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button DepositeBtn;
        private Button WithdrawBtn;
        private Button CreateAccountBtn;
        private Label label3;
        private NumericUpDown InterestRateNum;
    }
}
