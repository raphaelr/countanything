namespace CountAnything.Forms {
    partial class CounterForm {
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
            if(disposing && (components != null)) {
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
            this.textCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textCounter
            // 
            this.textCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCounter.AutoSize = true;
            this.textCounter.Location = new System.Drawing.Point(12, 15);
            this.textCounter.Name = "textCounter";
            this.textCounter.Size = new System.Drawing.Size(103, 13);
            this.textCounter.TabIndex = 0;
            this.textCounter.Text = "tape1 is the greatest";
            this.textCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(116, 37);
            this.Controls.Add(this.textCounter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CounterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CountAnything";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textCounter;
    }
}