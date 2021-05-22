
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
            this.resultFrame = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultFrame
            // 
            this.resultFrame.Location = new System.Drawing.Point(12, 12);
            this.resultFrame.MaximumSize = new System.Drawing.Size(400, 400);
            this.resultFrame.MinimumSize = new System.Drawing.Size(410, 85);
            this.resultFrame.Name = "resultFrame";
            this.resultFrame.Size = new System.Drawing.Size(410, 85);
            this.resultFrame.TabIndex = 0;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 473);
            this.Controls.Add(this.resultFrame);
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultFrame;
    }
}

