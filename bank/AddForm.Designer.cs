namespace bank
{
    partial class AddForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            MakeAdd = new Button();
            Back = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(50, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(200, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(50, 80);
            label1.Name = "label1";
            label1.Size = new Size(37, 21);
            label1.TabIndex = 2;
            label1.Text = "Ім'я";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(200, 80);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 4;
            label2.Text = "Баланс";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(50, 30);
            label3.Name = "label3";
            label3.Size = new Size(365, 32);
            label3.TabIndex = 0;
            label3.Text = "Додавання нового користувача";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(350, 80);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 6;
            label4.Text = "Дата створення";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(350, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 23);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(500, 80);
            label5.Name = "label5";
            label5.Size = new Size(31, 21);
            label5.TabIndex = 8;
            label5.Text = "Вік";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(500, 110);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(130, 23);
            textBox4.TabIndex = 9;
            // 
            // MakeAdd
            // 
            MakeAdd.Anchor = AnchorStyles.None;
            MakeAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MakeAdd.Location = new Point(50, 150);
            MakeAdd.Name = "MakeAdd";
            MakeAdd.Size = new Size(115, 30);
            MakeAdd.TabIndex = 10;
            MakeAdd.Text = "Додати";
            MakeAdd.UseVisualStyleBackColor = true;
            MakeAdd.Click += MakeAdd_Click;
            // 
            // Back
            // 
            Back.Anchor = AnchorStyles.None;
            Back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Back.Location = new Point(650, 30);
            Back.Name = "Back";
            Back.Size = new Size(115, 30);
            Back.TabIndex = 1;
            Back.Text = "Назад";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Back);
            Controls.Add(MakeAdd);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            MinimumSize = new Size(816, 489);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "add client";
            FormClosing += AddForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Button MakeAdd;
        private Button Back;
    }
}