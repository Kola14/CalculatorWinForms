namespace CalculatorWinForms
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbRawX = new System.Windows.Forms.TextBox();
            this.tbRawY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnPow = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnMod = new System.Windows.Forms.Button();
            this.BtnLog = new System.Windows.Forms.Button();
            this.BtnFac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRawX
            // 
            this.tbRawX.Location = new System.Drawing.Point(46, 77);
            this.tbRawX.Name = "tbRawX";
            this.tbRawX.Size = new System.Drawing.Size(339, 20);
            this.tbRawX.TabIndex = 1;
            // 
            // tbRawY
            // 
            this.tbRawY.Location = new System.Drawing.Point(46, 104);
            this.tbRawY.Name = "tbRawY";
            this.tbRawY.Size = new System.Drawing.Size(339, 20);
            this.tbRawY.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(46, 181);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(339, 20);
            this.tbResult.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "=";
            // 
            // BtnPlus
            // 
            this.BtnPlus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPlus.Location = new System.Drawing.Point(46, 138);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(22, 29);
            this.BtnPlus.TabIndex = 7;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlusClick);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMinus.Location = new System.Drawing.Point(78, 138);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(22, 29);
            this.BtnMinus.TabIndex = 8;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinusClick);
            // 
            // BtnPow
            // 
            this.BtnPow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPow.Location = new System.Drawing.Point(134, 138);
            this.BtnPow.Name = "BtnPow";
            this.BtnPow.Size = new System.Drawing.Size(40, 29);
            this.BtnPow.TabIndex = 9;
            this.BtnPow.Text = "x^y";
            this.BtnPow.UseVisualStyleBackColor = true;
            this.BtnPow.Click += new System.EventHandler(this.BtnPowClick);
            // 
            // BtnMult
            // 
            this.BtnMult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMult.Location = new System.Drawing.Point(106, 138);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(22, 29);
            this.BtnMult.TabIndex = 10;
            this.BtnMult.Text = "*";
            this.BtnMult.UseVisualStyleBackColor = true;
            this.BtnMult.Click += new System.EventHandler(this.BtnMultClick);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDiv.Location = new System.Drawing.Point(180, 138);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(29, 29);
            this.BtnDiv.TabIndex = 11;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDivClick);
            // 
            // BtnMod
            // 
            this.BtnMod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMod.Location = new System.Drawing.Point(215, 138);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(29, 29);
            this.BtnMod.TabIndex = 12;
            this.BtnMod.Text = "%";
            this.BtnMod.UseVisualStyleBackColor = true;
            this.BtnMod.Click += new System.EventHandler(this.BtnModClick);
            // 
            // BtnLog
            // 
            this.BtnLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLog.Location = new System.Drawing.Point(250, 138);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Size = new System.Drawing.Size(47, 29);
            this.BtnLog.TabIndex = 13;
            this.BtnLog.Text = "log";
            this.BtnLog.UseVisualStyleBackColor = true;
            this.BtnLog.Click += new System.EventHandler(this.BtnLogClick);
            // 
            // BtnFac
            // 
            this.BtnFac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFac.Location = new System.Drawing.Point(303, 138);
            this.BtnFac.Name = "BtnFac";
            this.BtnFac.Size = new System.Drawing.Size(47, 29);
            this.BtnFac.TabIndex = 14;
            this.BtnFac.Text = "x!";
            this.BtnFac.UseVisualStyleBackColor = true;
            this.BtnFac.Click += new System.EventHandler(this.BtnFacClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 217);
            this.Controls.Add(this.BtnFac);
            this.Controls.Add(this.BtnLog);
            this.Controls.Add(this.BtnMod);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.BtnPow);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRawY);
            this.Controls.Add(this.tbRawX);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRawX;
        private System.Windows.Forms.TextBox tbRawY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnPow;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnMod;
        private System.Windows.Forms.Button BtnLog;
        private System.Windows.Forms.Button BtnFac;
    }
}

