namespace LAb3.NDC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Raschet = new System.Windows.Forms.Button();
            this.Chislo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Procent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.proc10 = new System.Windows.Forms.LinkLabel();
            this.proc18 = new System.Windows.Forms.LinkLabel();
            this.proc20 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.KNOPKA1 = new System.Windows.Forms.RadioButton();
            this.KNOPKA2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Raschet
            // 
            this.Raschet.Location = new System.Drawing.Point(410, 367);
            this.Raschet.Name = "Raschet";
            this.Raschet.Size = new System.Drawing.Size(75, 23);
            this.Raschet.TabIndex = 0;
            this.Raschet.Text = "Рассчитать";
            this.Raschet.UseVisualStyleBackColor = true;
            this.Raschet.Click += new System.EventHandler(this.Raschet_Click);
            // 
            // Chislo
            // 
            this.Chislo.Location = new System.Drawing.Point(315, 99);
            this.Chislo.Name = "Chislo";
            this.Chislo.Size = new System.Drawing.Size(100, 20);
            this.Chislo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // Procent
            // 
            this.Procent.Location = new System.Drawing.Point(315, 155);
            this.Procent.Name = "Procent";
            this.Procent.Size = new System.Drawing.Size(100, 20);
            this.Procent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сумма(цена)";
            // 
            // proc10
            // 
            this.proc10.AutoSize = true;
            this.proc10.Location = new System.Drawing.Point(294, 194);
            this.proc10.Name = "proc10";
            this.proc10.Size = new System.Drawing.Size(27, 13);
            this.proc10.TabIndex = 5;
            this.proc10.TabStop = true;
            this.proc10.Text = "10%";
            this.proc10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.proc10_LinkClicked);
            // 
            // proc18
            // 
            this.proc18.AutoSize = true;
            this.proc18.Location = new System.Drawing.Point(365, 194);
            this.proc18.Name = "proc18";
            this.proc18.Size = new System.Drawing.Size(27, 13);
            this.proc18.TabIndex = 6;
            this.proc18.TabStop = true;
            this.proc18.Text = "18%";
            this.proc18.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.proc18_LinkClicked);
            // 
            // proc20
            // 
            this.proc20.AutoSize = true;
            this.proc20.Location = new System.Drawing.Point(427, 193);
            this.proc20.Name = "proc20";
            this.proc20.Size = new System.Drawing.Size(27, 13);
            this.proc20.TabIndex = 7;
            this.proc20.TabStop = true;
            this.proc20.Text = "20%";
            this.proc20.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.proc20_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ставка НДС,%";
            // 
            // KNOPKA1
            // 
            this.KNOPKA1.AutoSize = true;
            this.KNOPKA1.Location = new System.Drawing.Point(315, 237);
            this.KNOPKA1.Name = "KNOPKA1";
            this.KNOPKA1.Size = new System.Drawing.Size(106, 17);
            this.KNOPKA1.TabIndex = 9;
            this.KNOPKA1.TabStop = true;
            this.KNOPKA1.Text = "Начислить НДС";
            this.KNOPKA1.UseVisualStyleBackColor = true;
            this.KNOPKA1.CheckedChanged += new System.EventHandler(this.KNOPKA1_CheckedChanged);
            // 
            // KNOPKA2
            // 
            this.KNOPKA2.AutoSize = true;
            this.KNOPKA2.Location = new System.Drawing.Point(315, 275);
            this.KNOPKA2.Name = "KNOPKA2";
            this.KNOPKA2.Size = new System.Drawing.Size(102, 17);
            this.KNOPKA2.TabIndex = 10;
            this.KNOPKA2.TabStop = true;
            this.KNOPKA2.Text = "Выделить НДС";
            this.KNOPKA2.UseVisualStyleBackColor = true;
            this.KNOPKA2.CheckedChanged += new System.EventHandler(this.KNOPKA2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Вид Расчёта";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KNOPKA2);
            this.Controls.Add(this.KNOPKA1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.proc20);
            this.Controls.Add(this.proc18);
            this.Controls.Add(this.proc10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Procent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chislo);
            this.Controls.Add(this.Raschet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Raschet;
        private System.Windows.Forms.TextBox Chislo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Procent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel proc10;
        private System.Windows.Forms.LinkLabel proc18;
        private System.Windows.Forms.LinkLabel proc20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton KNOPKA1;
        private System.Windows.Forms.RadioButton KNOPKA2;
        private System.Windows.Forms.Label label4;
    }
}

