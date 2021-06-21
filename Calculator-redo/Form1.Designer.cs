
namespace Calculator_redo
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.resultFrame = new System.Windows.Forms.TextBox();
            this.ClrAllBtn = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.csignBtn = new System.Windows.Forms.Button();
            this.DltBtn = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.DecBtn = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.prcntBtn = new System.Windows.Forms.Button();
            this.divisionBtn = new System.Windows.Forms.Button();
            this.timesBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.Label();
            this.stored_Action2 = new System.Windows.Forms.Label();
            this.operation_lbl = new System.Windows.Forms.Label();
            this.stored_action = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultFrame
            // 
            this.resultFrame.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.resultFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.5F);
            this.resultFrame.Location = new System.Drawing.Point(12, 22);
            this.resultFrame.MaximumSize = new System.Drawing.Size(500, 500);
            this.resultFrame.MinimumSize = new System.Drawing.Size(365, 75);
            this.resultFrame.Name = "resultFrame";
            this.resultFrame.Size = new System.Drawing.Size(367, 40);
            this.resultFrame.TabIndex = 0;
            this.resultFrame.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultFrame.TextChanged += new System.EventHandler(this.resultFrame_TextChanged);
            // 
            // ClrAllBtn
            // 
            this.ClrAllBtn.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrAllBtn.Location = new System.Drawing.Point(12, 115);
            this.ClrAllBtn.Name = "ClrAllBtn";
            this.ClrAllBtn.Size = new System.Drawing.Size(84, 53);
            this.ClrAllBtn.TabIndex = 1;
            this.ClrAllBtn.Text = "AC";
            this.ClrAllBtn.UseVisualStyleBackColor = true;
            this.ClrAllBtn.Click += new System.EventHandler(this.ClrAllBtn_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn7.BackgroundImage")));
            this.Btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn7.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(12, 183);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(84, 53);
            this.Btn7.TabIndex = 2;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn4.BackgroundImage")));
            this.Btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn4.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F);
            this.Btn4.Location = new System.Drawing.Point(12, 242);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(84, 53);
            this.Btn4.TabIndex = 3;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn1.BackgroundImage")));
            this.Btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F);
            this.Btn1.Location = new System.Drawing.Point(12, 301);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(84, 53);
            this.Btn1.TabIndex = 4;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // csignBtn
            // 
            this.csignBtn.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold);
            this.csignBtn.Location = new System.Drawing.Point(12, 362);
            this.csignBtn.Name = "csignBtn";
            this.csignBtn.Size = new System.Drawing.Size(84, 53);
            this.csignBtn.TabIndex = 5;
            this.csignBtn.Text = "+/-";
            this.csignBtn.UseVisualStyleBackColor = true;
            this.csignBtn.Click += new System.EventHandler(this.csignBtn_Click);
            // 
            // DltBtn
            // 
            this.DltBtn.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold);
            this.DltBtn.Location = new System.Drawing.Point(102, 115);
            this.DltBtn.Name = "DltBtn";
            this.DltBtn.Size = new System.Drawing.Size(84, 53);
            this.DltBtn.TabIndex = 6;
            this.DltBtn.Text = "DEL";
            this.DltBtn.UseVisualStyleBackColor = true;
            this.DltBtn.Click += new System.EventHandler(this.DltBtn_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn8.BackgroundImage")));
            this.Btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn8.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F);
            this.Btn8.Location = new System.Drawing.Point(102, 183);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(84, 53);
            this.Btn8.TabIndex = 7;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn5.BackgroundImage")));
            this.Btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn5.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F);
            this.Btn5.Location = new System.Drawing.Point(102, 242);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(84, 53);
            this.Btn5.TabIndex = 8;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn2.BackgroundImage")));
            this.Btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn2.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F);
            this.Btn2.Location = new System.Drawing.Point(102, 301);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(84, 53);
            this.Btn2.TabIndex = 9;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn0.BackgroundImage")));
            this.Btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn0.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F);
            this.Btn0.Location = new System.Drawing.Point(102, 362);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(84, 53);
            this.Btn0.TabIndex = 10;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // DecBtn
            // 
            this.DecBtn.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold);
            this.DecBtn.Location = new System.Drawing.Point(192, 115);
            this.DecBtn.Name = "DecBtn";
            this.DecBtn.Size = new System.Drawing.Size(84, 53);
            this.DecBtn.TabIndex = 11;
            this.DecBtn.Text = ".";
            this.DecBtn.UseVisualStyleBackColor = true;
            this.DecBtn.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn9.BackgroundImage")));
            this.Btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn9.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F);
            this.Btn9.Location = new System.Drawing.Point(192, 183);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(84, 53);
            this.Btn9.TabIndex = 12;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn6.BackgroundImage")));
            this.Btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn6.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F);
            this.Btn6.Location = new System.Drawing.Point(192, 242);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(84, 53);
            this.Btn6.TabIndex = 13;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn3.BackgroundImage")));
            this.Btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F);
            this.Btn3.Location = new System.Drawing.Point(192, 301);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(84, 53);
            this.Btn3.TabIndex = 14;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // prcntBtn
            // 
            this.prcntBtn.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold);
            this.prcntBtn.Location = new System.Drawing.Point(192, 362);
            this.prcntBtn.Name = "prcntBtn";
            this.prcntBtn.Size = new System.Drawing.Size(84, 53);
            this.prcntBtn.TabIndex = 15;
            this.prcntBtn.Text = "%";
            this.prcntBtn.UseVisualStyleBackColor = true;
            this.prcntBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // divisionBtn
            // 
            this.divisionBtn.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold);
            this.divisionBtn.Location = new System.Drawing.Point(282, 115);
            this.divisionBtn.Name = "divisionBtn";
            this.divisionBtn.Size = new System.Drawing.Size(97, 53);
            this.divisionBtn.TabIndex = 16;
            this.divisionBtn.Text = "÷";
            this.divisionBtn.UseVisualStyleBackColor = true;
            this.divisionBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // timesBtn
            // 
            this.timesBtn.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold);
            this.timesBtn.Location = new System.Drawing.Point(282, 174);
            this.timesBtn.Name = "timesBtn";
            this.timesBtn.Size = new System.Drawing.Size(97, 53);
            this.timesBtn.TabIndex = 17;
            this.timesBtn.Text = "×";
            this.timesBtn.UseVisualStyleBackColor = true;
            this.timesBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold);
            this.minusBtn.Location = new System.Drawing.Point(282, 233);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(97, 53);
            this.minusBtn.TabIndex = 18;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold);
            this.plusBtn.Location = new System.Drawing.Point(282, 292);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(97, 53);
            this.plusBtn.TabIndex = 19;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold);
            this.equalBtn.Location = new System.Drawing.Point(282, 349);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(97, 66);
            this.equalBtn.TabIndex = 20;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // input1
            // 
            this.input1.AutoSize = true;
            this.input1.Location = new System.Drawing.Point(324, 82);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(36, 13);
            this.input1.TabIndex = 21;
            this.input1.Text = "input1";
            // 
            // stored_Action2
            // 
            this.stored_Action2.AutoSize = true;
            this.stored_Action2.Location = new System.Drawing.Point(283, 82);
            this.stored_Action2.Name = "stored_Action2";
            this.stored_Action2.Size = new System.Drawing.Size(35, 13);
            this.stored_Action2.TabIndex = 22;
            this.stored_Action2.Text = "label2";
            // 
            // operation_lbl
            // 
            this.operation_lbl.AutoSize = true;
            this.operation_lbl.Location = new System.Drawing.Point(12, 82);
            this.operation_lbl.Name = "operation_lbl";
            this.operation_lbl.Size = new System.Drawing.Size(35, 13);
            this.operation_lbl.TabIndex = 23;
            this.operation_lbl.Text = "label1";
            // 
            // stored_action
            // 
            this.stored_action.AutoSize = true;
            this.stored_action.Location = new System.Drawing.Point(12, 6);
            this.stored_action.Name = "stored_action";
            this.stored_action.Size = new System.Drawing.Size(35, 13);
            this.stored_action.TabIndex = 24;
            this.stored_action.Text = "label1";
            this.stored_action.Click += new System.EventHandler(this.stored_action_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 427);
            this.Controls.Add(this.stored_action);
            this.Controls.Add(this.operation_lbl);
            this.Controls.Add(this.stored_Action2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.timesBtn);
            this.Controls.Add(this.divisionBtn);
            this.Controls.Add(this.prcntBtn);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.DecBtn);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.DltBtn);
            this.Controls.Add(this.csignBtn);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.ClrAllBtn);
            this.Controls.Add(this.resultFrame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ClrAllBtn;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button csignBtn;
        private System.Windows.Forms.Button DltBtn;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button DecBtn;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button prcntBtn;
        private System.Windows.Forms.Button divisionBtn;
        private System.Windows.Forms.Button timesBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.TextBox resultFrame;
        private System.Windows.Forms.Label input1;
        private System.Windows.Forms.Label stored_Action2;
        private System.Windows.Forms.Label operation_lbl;
        private System.Windows.Forms.Label stored_action;
    }
}

