namespace Shuai_C
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
            cassafortebtn = new Button();
            password_inserita = new TextBox();
            data_inserita = new TextBox();
            invia_codice_btn = new Button();
            invia_data_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            codice_utente = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            codice_sblocco = new TextBox();
            button3 = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cassafortebtn
            // 
            cassafortebtn.Location = new Point(545, 155);
            cassafortebtn.Name = "cassafortebtn";
            cassafortebtn.Size = new Size(139, 136);
            cassafortebtn.TabIndex = 0;
            cassafortebtn.Text = "cassaforte";
            cassafortebtn.UseVisualStyleBackColor = true;
            // 
            // password_inserita
            // 
            password_inserita.Location = new Point(165, 188);
            password_inserita.Name = "password_inserita";
            password_inserita.Size = new Size(100, 23);
            password_inserita.TabIndex = 1;
            // 
            // data_inserita
            // 
            data_inserita.Location = new Point(165, 263);
            data_inserita.Name = "data_inserita";
            data_inserita.Size = new Size(100, 23);
            data_inserita.TabIndex = 2;
            // 
            // invia_codice_btn
            // 
            invia_codice_btn.Location = new Point(291, 187);
            invia_codice_btn.Name = "invia_codice_btn";
            invia_codice_btn.Size = new Size(75, 23);
            invia_codice_btn.TabIndex = 3;
            invia_codice_btn.Text = "invia";
            invia_codice_btn.UseVisualStyleBackColor = true;
            invia_codice_btn.Click += invia_codice_btn_Click;
            // 
            // invia_data_btn
            // 
            invia_data_btn.Location = new Point(291, 262);
            invia_data_btn.Name = "invia_data_btn";
            invia_data_btn.Size = new Size(75, 23);
            invia_data_btn.TabIndex = 4;
            invia_data_btn.Text = "invia";
            invia_data_btn.UseVisualStyleBackColor = true;
            invia_data_btn.Click += invia_data_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 155);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "codice utente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 233);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 6;
            label2.Text = "data";
            // 
            // codice_utente
            // 
            codice_utente.Location = new Point(36, 43);
            codice_utente.Name = "codice_utente";
            codice_utente.Size = new Size(100, 23);
            codice_utente.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 19);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 8;
            label3.Text = "imposta password";
            // 
            // button1
            // 
            button1.Location = new Point(36, 86);
            button1.Name = "button1";
            button1.Size = new Size(125, 46);
            button1.TabIndex = 9;
            button1.Text = "converma password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(210, 86);
            button2.Name = "button2";
            button2.Size = new Size(125, 46);
            button2.TabIndex = 12;
            button2.Text = "converma password";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 19);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 11;
            label4.Text = "imposta data";
            // 
            // codice_sblocco
            // 
            codice_sblocco.Location = new Point(210, 43);
            codice_sblocco.Name = "codice_sblocco";
            codice_sblocco.Size = new Size(100, 23);
            codice_sblocco.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new Point(380, 40);
            button3.Name = "button3";
            button3.Size = new Size(166, 23);
            button3.TabIndex = 13;
            button3.Text = "blocca cassaforte";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(572, 44);
            label5.Name = "label5";
            label5.Size = new Size(175, 15);
            label5.TabIndex = 14;
            label5.Text = "codice_sblocco: zxcvbnmafghjk";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(codice_sblocco);
            groupBox1.Controls.Add(codice_utente);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 136);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(invia_data_btn);
            Controls.Add(invia_codice_btn);
            Controls.Add(data_inserita);
            Controls.Add(password_inserita);
            Controls.Add(cassafortebtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cassafortebtn;
        private TextBox password_inserita;
        private TextBox data_inserita;
        private Button invia_codice_btn;
        private Button invia_data_btn;
        private Label label1;
        private Label label2;
        private TextBox codice_utente;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private TextBox codice_sblocco;
        private Button button3;
        private Label label5;
        private GroupBox groupBox1;
    }
}
