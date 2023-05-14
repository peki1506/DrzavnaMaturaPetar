namespace DrzavnaMaturaPetar
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име ученика";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Презиме ученика";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип матуре";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ОПШТА",
            "СТРУЧНА",
            "УМЕТНИЧКА"});
            this.comboBox1.Location = new System.Drawing.Point(17, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(14, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "1. предмет";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Српски језик и књижевност",
            "Албански језик и књижевност",
            "Босански језик и књижевност",
            "Бугарски језик и књижевност",
            "Мађарски језик и књижевност",
            "Румунски језик и књижевност",
            "Словачки језик и књижевност",
            "Хрватски језик и књижевност"});
            this.comboBox2.Location = new System.Drawing.Point(17, 256);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(213, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "2. предмет";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Математика"});
            this.comboBox3.Location = new System.Drawing.Point(17, 333);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(213, 24);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "ОПШТА",
            "СТРУЧНА",
            "УМЕТНИЧКА"});
            this.comboBox5.Location = new System.Drawing.Point(17, 401);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(213, 35);
            this.comboBox5.TabIndex = 10;
            this.comboBox5.Text = "Област 3. предмета";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "3. предмет";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Биологија",
            "Географија",
            "Енглески језик",
            "Историја",
            "Италијански језик",
            "Немачки језик",
            "Руски језик",
            "Српски као нематерњи језик",
            "Физика",
            "Француски језик",
            "Хемија",
            "Шпански језик"});
            this.comboBox4.Location = new System.Drawing.Point(17, 442);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(213, 24);
            this.comboBox4.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(342, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(738, 308);
            this.listBox1.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(19, 496);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 31);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Фиксирај предмете";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(476, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 70);
            this.button1.TabIndex = 16;
            this.button1.Text = "Унеси податак";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(621, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 70);
            this.button2.TabIndex = 17;
            this.button2.Text = "Отвори фајл са подацима";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(766, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 70);
            this.button3.TabIndex = 18;
            this.button3.Text = "Обриши";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(911, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 70);
            this.button4.TabIndex = 19;
            this.button4.Text = "Следећи ученик";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1104, 539);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}