namespace bank
{
    partial class EditClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddToBalance = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Withdraw = new TextBox();
            Back = new Button();
            FromBalanceToDeposit = new TextBox();
            label3 = new Label();
            Confirm = new Button();
            label4 = new Label();
            Data = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Term = new TextBox();
            UpdateDataOfClient = new Button();
            listView1 = new ListView();
            dataBox = new ListBox();
            CalculatePercent = new Button();
            ListBoxForPercent = new ListBox();
            label7 = new Label();
            AddDepositToBalance = new Button();
            HistoryBox = new ListBox();
            ShowHistory = new Button();
            MakeInvoice = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // AddToBalance
            // 
            AddToBalance.Anchor = AnchorStyles.None;
            AddToBalance.Location = new Point(548, 51);
            AddToBalance.Name = "AddToBalance";
            AddToBalance.Size = new Size(100, 23);
            AddToBalance.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(548, 27);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 11;
            label1.Text = "Покласти на баланс";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(548, 90);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 13;
            label2.Text = "Зняти з балансу";
            // 
            // Withdraw
            // 
            Withdraw.Anchor = AnchorStyles.None;
            Withdraw.Location = new Point(548, 114);
            Withdraw.Name = "Withdraw";
            Withdraw.Size = new Size(100, 23);
            Withdraw.TabIndex = 14;
            // 
            // Back
            // 
            Back.Anchor = AnchorStyles.None;
            Back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Back.Location = new Point(20, 20);
            Back.Name = "Back";
            Back.Size = new Size(115, 30);
            Back.TabIndex = 0;
            Back.Text = "Назад";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // FromBalanceToDeposit
            // 
            FromBalanceToDeposit.Anchor = AnchorStyles.None;
            FromBalanceToDeposit.Location = new Point(548, 176);
            FromBalanceToDeposit.Name = "FromBalanceToDeposit";
            FromBalanceToDeposit.Size = new Size(100, 23);
            FromBalanceToDeposit.TabIndex = 16;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(548, 152);
            label3.Name = "label3";
            label3.Size = new Size(248, 21);
            label3.TabIndex = 15;
            label3.Text = "Переказати з балансу на депозит";
            // 
            // Confirm
            // 
            Confirm.Anchor = AnchorStyles.None;
            Confirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Confirm.Location = new Point(673, 408);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(115, 30);
            Confirm.TabIndex = 21;
            Confirm.Text = "Підтвердити";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(20, 152);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 3;
            label4.Text = "Дані клієнта";
            // 
            // Data
            // 
            Data.Anchor = AnchorStyles.None;
            Data.Location = new Point(548, 349);
            Data.Name = "Data";
            Data.Size = new Size(120, 23);
            Data.TabIndex = 20;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(548, 325);
            label5.Name = "label5";
            label5.Size = new Size(248, 21);
            label5.TabIndex = 19;
            label5.Text = "Дата операції (обов'язкове поле)";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(548, 213);
            label6.Name = "label6";
            label6.Size = new Size(115, 21);
            label6.TabIndex = 17;
            label6.Text = "Кількість років";
            // 
            // Term
            // 
            Term.Anchor = AnchorStyles.None;
            Term.Location = new Point(548, 237);
            Term.Name = "Term";
            Term.Size = new Size(100, 23);
            Term.TabIndex = 18;
            // 
            // UpdateDataOfClient
            // 
            UpdateDataOfClient.Anchor = AnchorStyles.None;
            UpdateDataOfClient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UpdateDataOfClient.Location = new Point(20, 378);
            UpdateDataOfClient.Name = "UpdateDataOfClient";
            UpdateDataOfClient.Size = new Size(200, 30);
            UpdateDataOfClient.TabIndex = 5;
            UpdateDataOfClient.Text = "Оновити дані клієнта";
            UpdateDataOfClient.UseVisualStyleBackColor = true;
            UpdateDataOfClient.Click += UpdateDataOfClient_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(20, 130);
            listView1.Name = "listView1";
            listView1.Size = new Size(350, 250);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dataBox
            // 
            dataBox.Anchor = AnchorStyles.None;
            dataBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataBox.FormattingEnabled = true;
            dataBox.ItemHeight = 21;
            dataBox.Location = new Point(20, 179);
            dataBox.Name = "dataBox";
            dataBox.Size = new Size(260, 193);
            dataBox.TabIndex = 4;
            // 
            // CalculatePercent
            // 
            CalculatePercent.Anchor = AnchorStyles.None;
            CalculatePercent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CalculatePercent.Location = new Point(300, 320);
            CalculatePercent.Name = "CalculatePercent";
            CalculatePercent.Size = new Size(180, 30);
            CalculatePercent.TabIndex = 9;
            CalculatePercent.Text = "Порахувати відсотки";
            CalculatePercent.UseVisualStyleBackColor = true;
            CalculatePercent.Click += CalculatePercent_Click;
            // 
            // ListBoxForPercent
            // 
            ListBoxForPercent.Anchor = AnchorStyles.None;
            ListBoxForPercent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ListBoxForPercent.FormattingEnabled = true;
            ListBoxForPercent.ItemHeight = 21;
            ListBoxForPercent.Location = new Point(300, 237);
            ListBoxForPercent.Name = "ListBoxForPercent";
            ListBoxForPercent.Size = new Size(180, 67);
            ListBoxForPercent.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(300, 213);
            label7.Name = "label7";
            label7.Size = new Size(165, 21);
            label7.TabIndex = 7;
            label7.Text = "Депозит з відсотками";
            // 
            // AddDepositToBalance
            // 
            AddDepositToBalance.Anchor = AnchorStyles.None;
            AddDepositToBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddDepositToBalance.Location = new Point(300, 378);
            AddDepositToBalance.Name = "AddDepositToBalance";
            AddDepositToBalance.Size = new Size(180, 30);
            AddDepositToBalance.TabIndex = 10;
            AddDepositToBalance.Text = "Нарахувати";
            AddDepositToBalance.UseVisualStyleBackColor = true;
            AddDepositToBalance.Click += AddDepositToBalance_Click;
            // 
            // HistoryBox
            // 
            HistoryBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            HistoryBox.FormattingEnabled = true;
            HistoryBox.ItemHeight = 21;
            HistoryBox.Location = new Point(20, 56);
            HistoryBox.Name = "HistoryBox";
            HistoryBox.Size = new Size(512, 88);
            HistoryBox.TabIndex = 1;
            // 
            // ShowHistory
            // 
            ShowHistory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ShowHistory.Location = new Point(352, 152);
            ShowHistory.Name = "ShowHistory";
            ShowHistory.Size = new Size(180, 30);
            ShowHistory.TabIndex = 6;
            ShowHistory.Text = "Показати історію";
            ShowHistory.UseVisualStyleBackColor = true;
            ShowHistory.Click += ShowHistory_Click;
            // 
            // MakeInvoice
            // 
            MakeInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MakeInvoice.Location = new Point(417, 20);
            MakeInvoice.Name = "MakeInvoice";
            MakeInvoice.Size = new Size(115, 30);
            MakeInvoice.TabIndex = 22;
            MakeInvoice.Text = "Створити";
            MakeInvoice.UseVisualStyleBackColor = true;
            MakeInvoice.Click += MakeInvoice_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(158, 20);
            label8.Name = "label8";
            label8.Size = new Size(253, 21);
            label8.TabIndex = 23;
            label8.Text = "Створити квитанцію останньої дії";
            // 
            // EditClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(MakeInvoice);
            Controls.Add(ShowHistory);
            Controls.Add(HistoryBox);
            Controls.Add(AddDepositToBalance);
            Controls.Add(label7);
            Controls.Add(ListBoxForPercent);
            Controls.Add(CalculatePercent);
            Controls.Add(dataBox);
            Controls.Add(UpdateDataOfClient);
            Controls.Add(Term);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Data);
            Controls.Add(label4);
            Controls.Add(Confirm);
            Controls.Add(label3);
            Controls.Add(FromBalanceToDeposit);
            Controls.Add(Back);
            Controls.Add(Withdraw);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddToBalance);
            MinimumSize = new Size(816, 489);
            Name = "EditClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "edit client";
            FormClosing += EditClientForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AddToBalance;
        private Label label1;
        private Label label2;
        private TextBox Withdraw;
        private Button Back;
        private TextBox FromBalanceToDeposit;
        private Label label3;
        private Button Confirm;
        private Label label4;
        private TextBox Data;
        private Label label5;
        private Label label6;
        private TextBox Term;
        private Button UpdateDataOfClient;
        private ListView listView1;
        private ListBox dataBox;
        private Button CalculatePercent;
        private ListBox ListBoxForPercent;
        private Label label7;
        private Button AddDepositToBalance;
        private ListBox HistoryBox;
        private Button ShowHistory;
        private Button MakeInvoice;
        private Label label8;
    }
}