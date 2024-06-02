namespace bank
{
    partial class MainForm
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
            SearchButton = new Button();
            Add = new Button();
            label1 = new Label();
            SearchBox = new TextBox();
            ClientsBox = new ListBox();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.None;
            SearchButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchButton.Location = new Point(350, 33);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(110, 40);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Знайти";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // Add
            // 
            Add.Anchor = AnchorStyles.None;
            Add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Add.Location = new Point(670, 20);
            Add.Name = "Add";
            Add.Size = new Size(110, 40);
            Add.TabIndex = 3;
            Add.Text = "Додати";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(229, 21);
            label1.TabIndex = 0;
            label1.Text = "Введіть щось про користувача";
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.None;
            SearchBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchBox.Location = new Point(30, 50);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(300, 23);
            SearchBox.TabIndex = 1;
            // 
            // ClientsBox
            // 
            ClientsBox.Anchor = AnchorStyles.None;
            ClientsBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClientsBox.FormattingEnabled = true;
            ClientsBox.ItemHeight = 21;
            ClientsBox.Location = new Point(30, 90);
            ClientsBox.Name = "ClientsBox";
            ClientsBox.Size = new Size(700, 256);
            ClientsBox.TabIndex = 4;
            ClientsBox.DoubleClick += ClientsBox_DoubleClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClientsBox);
            Controls.Add(SearchBox);
            Controls.Add(label1);
            Controls.Add(Add);
            Controls.Add(SearchButton);
            MinimumSize = new Size(816, 489);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "bank";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private Button Add;
        private Label label1;
        private TextBox SearchBox;
        private ListBox ClientsBox;
    }
}
