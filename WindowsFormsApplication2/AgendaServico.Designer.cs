﻿namespace WindowsFormsApplication2
{
    partial class AgendaServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaServico));
            this.label11 = new System.Windows.Forms.Label();
            this.datalabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.servico = new System.Windows.Forms.ComboBox();
            this.sala = new System.Windows.Forms.ComboBox();
            this.clientetxt = new System.Windows.Forms.TextBox();
            this.projetotxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(566, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(602, 67);
            this.label11.TabIndex = 20;
            this.label11.Text = "AGENDAR SERVIÇO";
            // 
            // datalabel
            // 
            this.datalabel.AutoSize = true;
            this.datalabel.BackColor = System.Drawing.Color.Transparent;
            this.datalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalabel.Location = new System.Drawing.Point(796, 225);
            this.datalabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.datalabel.Name = "datalabel";
            this.datalabel.Size = new System.Drawing.Size(116, 25);
            this.datalabel.TabIndex = 21;
            this.datalabel.Text = "data label";
            this.datalabel.Click += new System.EventHandler(this.datalabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(136, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "CLIENTE :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(136, 450);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "TÍTULO/PROJETO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(154, 564);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "SERVIÇO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(167, 712);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "SALA :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // servico
            // 
            this.servico.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.servico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servico.FormattingEnabled = true;
            this.servico.Items.AddRange(new object[] {
            "Gravação de Ensaio",
            "Gravação de CD",
            "Jingle"});
            this.servico.Location = new System.Drawing.Point(290, 561);
            this.servico.Margin = new System.Windows.Forms.Padding(6);
            this.servico.Name = "servico";
            this.servico.Size = new System.Drawing.Size(320, 33);
            this.servico.TabIndex = 26;
            this.servico.SelectedIndexChanged += new System.EventHandler(this.servico_SelectedIndexChanged);
            this.servico.Enter += new System.EventHandler(this.servico_Enter);
            // 
            // sala
            // 
            this.sala.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sala.FormattingEnabled = true;
            this.sala.Location = new System.Drawing.Point(290, 704);
            this.sala.Margin = new System.Windows.Forms.Padding(6);
            this.sala.Name = "sala";
            this.sala.Size = new System.Drawing.Size(320, 33);
            this.sala.TabIndex = 27;
            this.sala.SelectedIndexChanged += new System.EventHandler(this.sala_SelectedIndexChanged);
            // 
            // clientetxt
            // 
            this.clientetxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.clientetxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.clientetxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clientetxt.Location = new System.Drawing.Point(264, 332);
            this.clientetxt.Margin = new System.Windows.Forms.Padding(6);
            this.clientetxt.Name = "clientetxt";
            this.clientetxt.Size = new System.Drawing.Size(556, 33);
            this.clientetxt.TabIndex = 28;
            this.clientetxt.TextChanged += new System.EventHandler(this.clientetxt_TextChanged);
            // 
            // projetotxt
            // 
            this.projetotxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.projetotxt.Location = new System.Drawing.Point(362, 442);
            this.projetotxt.Margin = new System.Windows.Forms.Padding(6);
            this.projetotxt.Name = "projetotxt";
            this.projetotxt.Size = new System.Drawing.Size(458, 33);
            this.projetotxt.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(660, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "HORÁRIO : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(990, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "DURAÇÃO : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(838, 569);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "OBSERVAÇÃO : ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(826, 614);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(786, 217);
            this.textBox1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(838, 903);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 85);
            this.button1.TabIndex = 35;
            this.button1.Text = "INSTRUMENTOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1090, 903);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 85);
            this.button2.TabIndex = 36;
            this.button2.Text = "VOLTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1278, 903);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 85);
            this.button3.TabIndex = 37;
            this.button3.Text = "PAGAMENTO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1139, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "1 Hora";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1462, 903);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 85);
            this.button4.TabIndex = 39;
            this.button4.Text = "MENU";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(230, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 40;
            this.label10.Text = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(91, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 25);
            this.label12.TabIndex = 41;
            this.label12.Text = "Agenda - ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1103, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "VALOR SERVIÇO :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(1294, 445);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 25);
            this.label13.TabIndex = 43;
            this.label13.Text = "label13";
            this.label13.Visible = false;
            // 
            // AgendaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1764, 1089);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.projetotxt);
            this.Controls.Add(this.clientetxt);
            this.Controls.Add(this.sala);
            this.Controls.Add(this.servico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datalabel);
            this.Controls.Add(this.label11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgendaServico";
            this.Text = "NOAR ESTÚDIO";
            this.Load += new System.EventHandler(this.AgendaServico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label datalabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox servico;
        private System.Windows.Forms.ComboBox sala;
        private System.Windows.Forms.TextBox clientetxt;
        private System.Windows.Forms.TextBox projetotxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
    }
}