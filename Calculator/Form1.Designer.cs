
namespace Calculator
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
            this.gbDispley = new System.Windows.Forms.GroupBox();
            this.lbDistpley = new System.Windows.Forms.Label();
            this.btMRC = new System.Windows.Forms.Button();
            this.btMSum = new System.Windows.Forms.Button();
            this.btMSubtraction = new System.Windows.Forms.Button();
            this.btMMultiplication = new System.Windows.Forms.Button();
            this.btMDivision = new System.Windows.Forms.Button();
            this.btRev = new System.Windows.Forms.Button();
            this.btSeven = new System.Windows.Forms.Button();
            this.btEig = new System.Windows.Forms.Button();
            this.btNine = new System.Windows.Forms.Button();
            this.btMultiplication = new System.Windows.Forms.Button();
            this.btFour = new System.Windows.Forms.Button();
            this.btFife = new System.Windows.Forms.Button();
            this.btSix = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.btOne = new System.Windows.Forms.Button();
            this.btTwo = new System.Windows.Forms.Button();
            this.btThree = new System.Windows.Forms.Button();
            this.btSum = new System.Windows.Forms.Button();
            this.btSubtraction = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.btZapitai = new System.Windows.Forms.Button();
            this.btZero = new System.Windows.Forms.Button();
            this.btRavno = new System.Windows.Forms.Button();
            this.btSqrt = new System.Windows.Forms.Button();
            this.btSquareX = new System.Windows.Forms.Button();
            this.btSqrtX = new System.Windows.Forms.Button();
            this.btXSquareY = new System.Windows.Forms.Button();
            this.btFactiroal = new System.Windows.Forms.Button();
            this.gbDispley.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDispley
            // 
            this.gbDispley.Controls.Add(this.lbDistpley);
            this.gbDispley.Location = new System.Drawing.Point(12, 12);
            this.gbDispley.Name = "gbDispley";
            this.gbDispley.Size = new System.Drawing.Size(502, 43);
            this.gbDispley.TabIndex = 0;
            this.gbDispley.TabStop = false;
            // 
            // lbDistpley
            // 
            this.lbDistpley.AutoSize = true;
            this.lbDistpley.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbDistpley.Location = new System.Drawing.Point(486, 16);
            this.lbDistpley.Name = "lbDistpley";
            this.lbDistpley.Size = new System.Drawing.Size(13, 13);
            this.lbDistpley.TabIndex = 0;
            this.lbDistpley.Text = "0";
            // 
            // btMRC
            // 
            this.btMRC.Location = new System.Drawing.Point(12, 74);
            this.btMRC.Name = "btMRC";
            this.btMRC.Size = new System.Drawing.Size(75, 23);
            this.btMRC.TabIndex = 1;
            this.btMRC.Text = "MRC";
            this.btMRC.UseVisualStyleBackColor = true;
            this.btMRC.Click += new System.EventHandler(this.btMRC_Click);
            // 
            // btMSum
            // 
            this.btMSum.Location = new System.Drawing.Point(105, 74);
            this.btMSum.Name = "btMSum";
            this.btMSum.Size = new System.Drawing.Size(75, 23);
            this.btMSum.TabIndex = 2;
            this.btMSum.Text = "M+";
            this.btMSum.UseVisualStyleBackColor = true;
            this.btMSum.Click += new System.EventHandler(this.btMSum_Click);
            // 
            // btMSubtraction
            // 
            this.btMSubtraction.Location = new System.Drawing.Point(196, 74);
            this.btMSubtraction.Name = "btMSubtraction";
            this.btMSubtraction.Size = new System.Drawing.Size(75, 23);
            this.btMSubtraction.TabIndex = 3;
            this.btMSubtraction.Text = "M-";
            this.btMSubtraction.UseVisualStyleBackColor = true;
            this.btMSubtraction.Click += new System.EventHandler(this.btMSubtraction_Click);
            // 
            // btMMultiplication
            // 
            this.btMMultiplication.Location = new System.Drawing.Point(295, 74);
            this.btMMultiplication.Name = "btMMultiplication";
            this.btMMultiplication.Size = new System.Drawing.Size(75, 23);
            this.btMMultiplication.TabIndex = 4;
            this.btMMultiplication.Text = "M×";
            this.btMMultiplication.UseVisualStyleBackColor = true;
            this.btMMultiplication.Click += new System.EventHandler(this.btMMultiplication_Click);
            // 
            // btMDivision
            // 
            this.btMDivision.Location = new System.Drawing.Point(388, 74);
            this.btMDivision.Name = "btMDivision";
            this.btMDivision.Size = new System.Drawing.Size(54, 23);
            this.btMDivision.TabIndex = 5;
            this.btMDivision.Text = "M÷";
            this.btMDivision.UseVisualStyleBackColor = true;
            this.btMDivision.Click += new System.EventHandler(this.btMDivision_Click);
            // 
            // btRev
            // 
            this.btRev.Location = new System.Drawing.Point(476, 74);
            this.btRev.Name = "btRev";
            this.btRev.Size = new System.Drawing.Size(38, 24);
            this.btRev.TabIndex = 6;
            this.btRev.Text = "+/-";
            this.btRev.UseVisualStyleBackColor = true;
            this.btRev.Click += new System.EventHandler(this.btRev_Click);
            // 
            // btSeven
            // 
            this.btSeven.Location = new System.Drawing.Point(105, 123);
            this.btSeven.Name = "btSeven";
            this.btSeven.Size = new System.Drawing.Size(75, 23);
            this.btSeven.TabIndex = 7;
            this.btSeven.Text = "7";
            this.btSeven.UseVisualStyleBackColor = true;
            this.btSeven.Click += new System.EventHandler(this.btSeven_Click);
            // 
            // btEig
            // 
            this.btEig.Location = new System.Drawing.Point(196, 123);
            this.btEig.Name = "btEig";
            this.btEig.Size = new System.Drawing.Size(75, 23);
            this.btEig.TabIndex = 8;
            this.btEig.Text = "8";
            this.btEig.UseVisualStyleBackColor = true;
            this.btEig.Click += new System.EventHandler(this.btEig_Click);
            // 
            // btNine
            // 
            this.btNine.Location = new System.Drawing.Point(295, 123);
            this.btNine.Name = "btNine";
            this.btNine.Size = new System.Drawing.Size(75, 23);
            this.btNine.TabIndex = 9;
            this.btNine.Text = "9";
            this.btNine.UseVisualStyleBackColor = true;
            this.btNine.Click += new System.EventHandler(this.btNine_Click);
            // 
            // btMultiplication
            // 
            this.btMultiplication.Location = new System.Drawing.Point(388, 123);
            this.btMultiplication.Name = "btMultiplication";
            this.btMultiplication.Size = new System.Drawing.Size(54, 23);
            this.btMultiplication.TabIndex = 10;
            this.btMultiplication.Text = "×";
            this.btMultiplication.UseVisualStyleBackColor = true;
            this.btMultiplication.Click += new System.EventHandler(this.btMultiplication_Click);
            // 
            // btFour
            // 
            this.btFour.Location = new System.Drawing.Point(105, 166);
            this.btFour.Name = "btFour";
            this.btFour.Size = new System.Drawing.Size(75, 23);
            this.btFour.TabIndex = 11;
            this.btFour.Text = "4";
            this.btFour.UseVisualStyleBackColor = true;
            this.btFour.Click += new System.EventHandler(this.btFour_Click);
            // 
            // btFife
            // 
            this.btFife.Location = new System.Drawing.Point(196, 166);
            this.btFife.Name = "btFife";
            this.btFife.Size = new System.Drawing.Size(75, 23);
            this.btFife.TabIndex = 12;
            this.btFife.Text = "5";
            this.btFife.UseVisualStyleBackColor = true;
            this.btFife.Click += new System.EventHandler(this.btFife_Click);
            // 
            // btSix
            // 
            this.btSix.Location = new System.Drawing.Point(295, 166);
            this.btSix.Name = "btSix";
            this.btSix.Size = new System.Drawing.Size(75, 23);
            this.btSix.TabIndex = 13;
            this.btSix.Text = "6";
            this.btSix.UseVisualStyleBackColor = true;
            this.btSix.Click += new System.EventHandler(this.btSix_Click);
            // 
            // btDivision
            // 
            this.btDivision.Location = new System.Drawing.Point(388, 166);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(54, 23);
            this.btDivision.TabIndex = 14;
            this.btDivision.Text = "÷";
            this.btDivision.UseVisualStyleBackColor = true;
            this.btDivision.Click += new System.EventHandler(this.btDivision_Click);
            // 
            // btOne
            // 
            this.btOne.Location = new System.Drawing.Point(105, 206);
            this.btOne.Name = "btOne";
            this.btOne.Size = new System.Drawing.Size(75, 23);
            this.btOne.TabIndex = 15;
            this.btOne.Text = "1";
            this.btOne.UseVisualStyleBackColor = true;
            this.btOne.Click += new System.EventHandler(this.btOne_Click);
            // 
            // btTwo
            // 
            this.btTwo.Location = new System.Drawing.Point(196, 206);
            this.btTwo.Name = "btTwo";
            this.btTwo.Size = new System.Drawing.Size(75, 23);
            this.btTwo.TabIndex = 16;
            this.btTwo.Text = "2";
            this.btTwo.UseVisualStyleBackColor = true;
            this.btTwo.Click += new System.EventHandler(this.btTwo_Click);
            // 
            // btThree
            // 
            this.btThree.Location = new System.Drawing.Point(295, 206);
            this.btThree.Name = "btThree";
            this.btThree.Size = new System.Drawing.Size(75, 23);
            this.btThree.TabIndex = 17;
            this.btThree.Text = "3";
            this.btThree.UseVisualStyleBackColor = true;
            this.btThree.Click += new System.EventHandler(this.btThree_Click);
            // 
            // btSum
            // 
            this.btSum.Location = new System.Drawing.Point(388, 206);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(54, 23);
            this.btSum.TabIndex = 18;
            this.btSum.Text = "+";
            this.btSum.UseVisualStyleBackColor = true;
            this.btSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // btSubtraction
            // 
            this.btSubtraction.Location = new System.Drawing.Point(388, 246);
            this.btSubtraction.Name = "btSubtraction";
            this.btSubtraction.Size = new System.Drawing.Size(54, 23);
            this.btSubtraction.TabIndex = 19;
            this.btSubtraction.Text = "-";
            this.btSubtraction.UseVisualStyleBackColor = true;
            this.btSubtraction.Click += new System.EventHandler(this.btSubtraction_Click);
            // 
            // btCE
            // 
            this.btCE.Location = new System.Drawing.Point(295, 246);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(75, 23);
            this.btCE.TabIndex = 20;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = true;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // btZapitai
            // 
            this.btZapitai.Location = new System.Drawing.Point(196, 246);
            this.btZapitai.Name = "btZapitai";
            this.btZapitai.Size = new System.Drawing.Size(75, 23);
            this.btZapitai.TabIndex = 21;
            this.btZapitai.Text = ",";
            this.btZapitai.UseVisualStyleBackColor = true;
            this.btZapitai.Click += new System.EventHandler(this.btZapitai_Click);
            // 
            // btZero
            // 
            this.btZero.Location = new System.Drawing.Point(105, 246);
            this.btZero.Name = "btZero";
            this.btZero.Size = new System.Drawing.Size(75, 23);
            this.btZero.TabIndex = 22;
            this.btZero.Text = "0";
            this.btZero.UseVisualStyleBackColor = true;
            this.btZero.Click += new System.EventHandler(this.btZero_Click);
            // 
            // btRavno
            // 
            this.btRavno.Location = new System.Drawing.Point(295, 293);
            this.btRavno.Name = "btRavno";
            this.btRavno.Size = new System.Drawing.Size(147, 38);
            this.btRavno.TabIndex = 23;
            this.btRavno.Text = "=";
            this.btRavno.UseVisualStyleBackColor = true;
            this.btRavno.Click += new System.EventHandler(this.btRavno_Click);
            // 
            // btSqrt
            // 
            this.btSqrt.Location = new System.Drawing.Point(476, 123);
            this.btSqrt.Name = "btSqrt";
            this.btSqrt.Size = new System.Drawing.Size(38, 23);
            this.btSqrt.TabIndex = 24;
            this.btSqrt.Text = "√";
            this.btSqrt.UseVisualStyleBackColor = true;
            this.btSqrt.Click += new System.EventHandler(this.btSqrt_Click);
            // 
            // btSquareX
            // 
            this.btSquareX.Location = new System.Drawing.Point(476, 166);
            this.btSquareX.Name = "btSquareX";
            this.btSquareX.Size = new System.Drawing.Size(38, 23);
            this.btSquareX.TabIndex = 25;
            this.btSquareX.Text = "x^2";
            this.btSquareX.UseVisualStyleBackColor = true;
            this.btSquareX.Click += new System.EventHandler(this.btSquareX_Click);
            // 
            // btSqrtX
            // 
            this.btSqrtX.Location = new System.Drawing.Point(476, 206);
            this.btSqrtX.Name = "btSqrtX";
            this.btSqrtX.Size = new System.Drawing.Size(38, 23);
            this.btSqrtX.TabIndex = 26;
            this.btSqrtX.Text = "x√";
            this.btSqrtX.UseVisualStyleBackColor = true;
            this.btSqrtX.Click += new System.EventHandler(this.btSqrtX_Click);
            // 
            // btXSquareY
            // 
            this.btXSquareY.Location = new System.Drawing.Point(476, 246);
            this.btXSquareY.Name = "btXSquareY";
            this.btXSquareY.Size = new System.Drawing.Size(38, 23);
            this.btXSquareY.TabIndex = 27;
            this.btXSquareY.Text = "x^y";
            this.btXSquareY.UseVisualStyleBackColor = true;
            this.btXSquareY.Click += new System.EventHandler(this.btXSquareY_Click);
            // 
            // btFactiroal
            // 
            this.btFactiroal.Location = new System.Drawing.Point(476, 293);
            this.btFactiroal.Name = "btFactiroal";
            this.btFactiroal.Size = new System.Drawing.Size(38, 38);
            this.btFactiroal.TabIndex = 28;
            this.btFactiroal.Text = "n!";
            this.btFactiroal.UseVisualStyleBackColor = true;
            this.btFactiroal.Click += new System.EventHandler(this.btFactiroal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 351);
            this.Controls.Add(this.btFactiroal);
            this.Controls.Add(this.btXSquareY);
            this.Controls.Add(this.btSqrtX);
            this.Controls.Add(this.btSquareX);
            this.Controls.Add(this.btSqrt);
            this.Controls.Add(this.btRavno);
            this.Controls.Add(this.btZero);
            this.Controls.Add(this.btZapitai);
            this.Controls.Add(this.btCE);
            this.Controls.Add(this.btSubtraction);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.btThree);
            this.Controls.Add(this.btTwo);
            this.Controls.Add(this.btOne);
            this.Controls.Add(this.btDivision);
            this.Controls.Add(this.btSix);
            this.Controls.Add(this.btFife);
            this.Controls.Add(this.btFour);
            this.Controls.Add(this.btMultiplication);
            this.Controls.Add(this.btNine);
            this.Controls.Add(this.btEig);
            this.Controls.Add(this.btSeven);
            this.Controls.Add(this.btRev);
            this.Controls.Add(this.btMDivision);
            this.Controls.Add(this.btMMultiplication);
            this.Controls.Add(this.btMSubtraction);
            this.Controls.Add(this.btMSum);
            this.Controls.Add(this.btMRC);
            this.Controls.Add(this.gbDispley);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.gbDispley.ResumeLayout(false);
            this.gbDispley.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDispley;
        private System.Windows.Forms.Label lbDistpley;
        private System.Windows.Forms.Button btMRC;
        private System.Windows.Forms.Button btMSum;
        private System.Windows.Forms.Button btMSubtraction;
        private System.Windows.Forms.Button btMMultiplication;
        private System.Windows.Forms.Button btMDivision;
        private System.Windows.Forms.Button btRev;
        private System.Windows.Forms.Button btSeven;
        private System.Windows.Forms.Button btEig;
        private System.Windows.Forms.Button btNine;
        private System.Windows.Forms.Button btMultiplication;
        private System.Windows.Forms.Button btFour;
        private System.Windows.Forms.Button btFife;
        private System.Windows.Forms.Button btSix;
        private System.Windows.Forms.Button btDivision;
        private System.Windows.Forms.Button btOne;
        private System.Windows.Forms.Button btTwo;
        private System.Windows.Forms.Button btThree;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.Button btSubtraction;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button btZapitai;
        private System.Windows.Forms.Button btZero;
        private System.Windows.Forms.Button btRavno;
        private System.Windows.Forms.Button btSqrt;
        private System.Windows.Forms.Button btSquareX;
        private System.Windows.Forms.Button btSqrtX;
        private System.Windows.Forms.Button btXSquareY;
        private System.Windows.Forms.Button btFactiroal;
    }
}

