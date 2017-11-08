namespace TxT
{
    partial class Regist
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
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gendernan = new System.Windows.Forms.RadioButton();
            this.gendernv = new System.Windows.Forms.RadioButton();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.telephone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(159, 22);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(113, 21);
            this.username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "出生年月";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "联系方式";
            // 
            // gendernan
            // 
            this.gendernan.AutoSize = true;
            this.gendernan.Location = new System.Drawing.Point(159, 109);
            this.gendernan.Name = "gendernan";
            this.gendernan.Size = new System.Drawing.Size(35, 16);
            this.gendernan.TabIndex = 6;
            this.gendernan.TabStop = true;
            this.gendernan.Text = "男";
            this.gendernan.UseVisualStyleBackColor = true;
            // 
            // gendernv
            // 
            this.gendernv.AutoSize = true;
            this.gendernv.Location = new System.Drawing.Point(227, 108);
            this.gendernv.Name = "gendernv";
            this.gendernv.Size = new System.Drawing.Size(35, 16);
            this.gendernv.TabIndex = 7;
            this.gendernv.TabStop = true;
            this.gendernv.Text = "女";
            this.gendernv.UseVisualStyleBackColor = true;
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(160, 142);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(112, 21);
            this.birthday.TabIndex = 8;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(159, 183);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(112, 21);
            this.telephone.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "登陆";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(160, 63);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(112, 21);
            this.pass.TabIndex = 12;
            // 
            // Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 340);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.gendernv);
            this.Controls.Add(this.gendernan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Name = "Regist";
            this.Text = "Regist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton gendernan;
        private System.Windows.Forms.RadioButton gendernv;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox pass;
    }
}