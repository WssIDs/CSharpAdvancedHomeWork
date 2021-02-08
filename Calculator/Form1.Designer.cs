
namespace Calculator
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
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btOne = new System.Windows.Forms.Button();
            this.btTwo = new System.Windows.Forms.Button();
            this.btThree = new System.Windows.Forms.Button();
            this.brSix = new System.Windows.Forms.Button();
            this.brFive = new System.Windows.Forms.Button();
            this.brFour = new System.Windows.Forms.Button();
            this.btNine = new System.Windows.Forms.Button();
            this.btEight = new System.Windows.Forms.Button();
            this.btSeven = new System.Windows.Forms.Button();
            this.btNegative = new System.Windows.Forms.Button();
            this.btZero = new System.Windows.Forms.Button();
            this.btResult = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btMultiply = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.tbComma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbResult.Location = new System.Drawing.Point(8, 10);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(298, 32);
            this.tbResult.TabIndex = 0;
            this.tbResult.Text = "0";
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btOne
            // 
            this.btOne.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOne.Location = new System.Drawing.Point(8, 276);
            this.btOne.Name = "btOne";
            this.btOne.Size = new System.Drawing.Size(70, 70);
            this.btOne.TabIndex = 1;
            this.btOne.Text = "1";
            this.btOne.UseVisualStyleBackColor = true;
            this.btOne.Click += new System.EventHandler(this.Number_Click);
            // 
            // btTwo
            // 
            this.btTwo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTwo.Location = new System.Drawing.Point(84, 276);
            this.btTwo.Name = "btTwo";
            this.btTwo.Size = new System.Drawing.Size(70, 70);
            this.btTwo.TabIndex = 2;
            this.btTwo.Text = "2";
            this.btTwo.UseVisualStyleBackColor = true;
            this.btTwo.Click += new System.EventHandler(this.Number_Click);
            // 
            // btThree
            // 
            this.btThree.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btThree.Location = new System.Drawing.Point(160, 276);
            this.btThree.Name = "btThree";
            this.btThree.Size = new System.Drawing.Size(70, 70);
            this.btThree.TabIndex = 3;
            this.btThree.Text = "3";
            this.btThree.UseVisualStyleBackColor = true;
            this.btThree.Click += new System.EventHandler(this.Number_Click);
            // 
            // brSix
            // 
            this.brSix.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brSix.Location = new System.Drawing.Point(160, 200);
            this.brSix.Name = "brSix";
            this.brSix.Size = new System.Drawing.Size(70, 70);
            this.brSix.TabIndex = 6;
            this.brSix.Text = "6";
            this.brSix.UseVisualStyleBackColor = true;
            this.brSix.Click += new System.EventHandler(this.Number_Click);
            // 
            // brFive
            // 
            this.brFive.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brFive.Location = new System.Drawing.Point(84, 200);
            this.brFive.Name = "brFive";
            this.brFive.Size = new System.Drawing.Size(70, 70);
            this.brFive.TabIndex = 5;
            this.brFive.Text = "5";
            this.brFive.UseVisualStyleBackColor = true;
            this.brFive.Click += new System.EventHandler(this.Number_Click);
            // 
            // brFour
            // 
            this.brFour.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brFour.Location = new System.Drawing.Point(8, 200);
            this.brFour.Name = "brFour";
            this.brFour.Size = new System.Drawing.Size(70, 70);
            this.brFour.TabIndex = 4;
            this.brFour.Text = "4";
            this.brFour.UseVisualStyleBackColor = true;
            this.brFour.Click += new System.EventHandler(this.Number_Click);
            // 
            // btNine
            // 
            this.btNine.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNine.Location = new System.Drawing.Point(160, 124);
            this.btNine.Name = "btNine";
            this.btNine.Size = new System.Drawing.Size(70, 70);
            this.btNine.TabIndex = 9;
            this.btNine.Text = "9";
            this.btNine.UseVisualStyleBackColor = true;
            this.btNine.Click += new System.EventHandler(this.Number_Click);
            // 
            // btEight
            // 
            this.btEight.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btEight.Location = new System.Drawing.Point(84, 124);
            this.btEight.Name = "btEight";
            this.btEight.Size = new System.Drawing.Size(70, 70);
            this.btEight.TabIndex = 8;
            this.btEight.Text = "8";
            this.btEight.UseVisualStyleBackColor = true;
            this.btEight.Click += new System.EventHandler(this.Number_Click);
            // 
            // btSeven
            // 
            this.btSeven.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSeven.Location = new System.Drawing.Point(8, 124);
            this.btSeven.Name = "btSeven";
            this.btSeven.Size = new System.Drawing.Size(70, 70);
            this.btSeven.TabIndex = 7;
            this.btSeven.Text = "7";
            this.btSeven.UseVisualStyleBackColor = true;
            this.btSeven.Click += new System.EventHandler(this.Number_Click);
            // 
            // btNegative
            // 
            this.btNegative.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNegative.Location = new System.Drawing.Point(8, 352);
            this.btNegative.Name = "btNegative";
            this.btNegative.Size = new System.Drawing.Size(70, 70);
            this.btNegative.TabIndex = 10;
            this.btNegative.Text = "+/-";
            this.btNegative.UseVisualStyleBackColor = true;
            this.btNegative.Click += new System.EventHandler(this.btNegative_Click);
            // 
            // btZero
            // 
            this.btZero.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btZero.Location = new System.Drawing.Point(84, 352);
            this.btZero.Name = "btZero";
            this.btZero.Size = new System.Drawing.Size(70, 70);
            this.btZero.TabIndex = 11;
            this.btZero.Text = "0";
            this.btZero.UseVisualStyleBackColor = true;
            this.btZero.Click += new System.EventHandler(this.Number_Click);
            // 
            // btResult
            // 
            this.btResult.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btResult.Location = new System.Drawing.Point(236, 352);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(70, 70);
            this.btResult.TabIndex = 13;
            this.btResult.Text = "=";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // btPlus
            // 
            this.btPlus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btPlus.Location = new System.Drawing.Point(236, 276);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(70, 70);
            this.btPlus.TabIndex = 14;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btMinus
            // 
            this.btMinus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMinus.Location = new System.Drawing.Point(235, 200);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(70, 70);
            this.btMinus.TabIndex = 15;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btMultiply
            // 
            this.btMultiply.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMultiply.Location = new System.Drawing.Point(236, 124);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(70, 70);
            this.btMultiply.TabIndex = 16;
            this.btMultiply.Text = "x";
            this.btMultiply.UseVisualStyleBackColor = true;
            this.btMultiply.Click += new System.EventHandler(this.btMultiply_Click);
            // 
            // btDivide
            // 
            this.btDivide.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDivide.Location = new System.Drawing.Point(236, 48);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(70, 70);
            this.btDivide.TabIndex = 17;
            this.btDivide.Text = "/";
            this.btDivide.UseVisualStyleBackColor = true;
            this.btDivide.Click += new System.EventHandler(this.btDivide_Click);
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btReset.Location = new System.Drawing.Point(160, 48);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(70, 70);
            this.btReset.TabIndex = 18;
            this.btReset.Text = "C";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // tbComma
            // 
            this.tbComma.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbComma.Location = new System.Drawing.Point(160, 352);
            this.tbComma.Name = "tbComma";
            this.tbComma.Size = new System.Drawing.Size(70, 70);
            this.tbComma.TabIndex = 19;
            this.tbComma.Text = ",";
            this.tbComma.UseVisualStyleBackColor = true;
            this.tbComma.Click += new System.EventHandler(this.tbComma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 433);
            this.Controls.Add(this.tbComma);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btMultiply);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.btZero);
            this.Controls.Add(this.btNegative);
            this.Controls.Add(this.btNine);
            this.Controls.Add(this.btEight);
            this.Controls.Add(this.btSeven);
            this.Controls.Add(this.brSix);
            this.Controls.Add(this.brFive);
            this.Controls.Add(this.brFour);
            this.Controls.Add(this.btThree);
            this.Controls.Add(this.btTwo);
            this.Controls.Add(this.btOne);
            this.Controls.Add(this.tbResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btOne;
        private System.Windows.Forms.Button btTwo;
        private System.Windows.Forms.Button btThree;
        private System.Windows.Forms.Button brSix;
        private System.Windows.Forms.Button brFive;
        private System.Windows.Forms.Button brFour;
        private System.Windows.Forms.Button btNine;
        private System.Windows.Forms.Button btEight;
        private System.Windows.Forms.Button btSeven;
        private System.Windows.Forms.Button btNegative;
        private System.Windows.Forms.Button btZero;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button tbComma;
    }
}

