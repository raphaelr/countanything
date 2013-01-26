using CountAnything.Controls;

namespace CountAnything.Forms {
    partial class ConfigForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.label1 = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textFormat = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.fontInput = new CountAnything.Controls.FontInput();
            this.colorBackground = new CountAnything.Controls.ColorInput();
            this.colorDone = new CountAnything.Controls.ColorInput();
            this.colorNotDone = new CountAnything.Controls.ColorInput();
            this.hotkeyIncrement = new CountAnything.Controls.HotkeyInput();
            this.label9 = new System.Windows.Forms.Label();
            this.numDoubleTapPrevention = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDoubleTapPrevention)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count to what:";
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(112, 12);
            this.numMax.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(240, 20);
            this.numMax.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Increment hotkey:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Not finished color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Finished color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Background color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Font:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Format:";
            // 
            // textFormat
            // 
            this.textFormat.Location = new System.Drawing.Point(112, 154);
            this.textFormat.Name = "textFormat";
            this.textFormat.Size = new System.Drawing.Size(240, 20);
            this.textFormat.TabIndex = 13;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(358, 9);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(161, 49);
            this.buttonStart.TabIndex = 14;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStartOnClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "These settings are saved automatically.";
            // 
            // fontInput
            // 
            this.fontInput.Location = new System.Drawing.Point(112, 180);
            this.fontInput.Name = "fontInput";
            this.fontInput.ReadOnly = true;
            this.fontInput.SelectedFont = ((CountAnything.FontDescription)(resources.GetObject("fontInput.SelectedFont")));
            this.fontInput.Size = new System.Drawing.Size(240, 20);
            this.fontInput.TabIndex = 11;
            this.fontInput.Text = "Microsoft Sans Serif 8,25 Regular";
            // 
            // colorBackground
            // 
            this.colorBackground.BackColor = System.Drawing.Color.Black;
            this.colorBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBackground.Location = new System.Drawing.Point(112, 124);
            this.colorBackground.Name = "colorBackground";
            this.colorBackground.SelectedColor = System.Drawing.Color.Black;
            this.colorBackground.Size = new System.Drawing.Size(240, 24);
            this.colorBackground.TabIndex = 9;
            // 
            // colorDone
            // 
            this.colorDone.BackColor = System.Drawing.Color.Black;
            this.colorDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorDone.Location = new System.Drawing.Point(112, 94);
            this.colorDone.Name = "colorDone";
            this.colorDone.SelectedColor = System.Drawing.Color.Black;
            this.colorDone.Size = new System.Drawing.Size(240, 24);
            this.colorDone.TabIndex = 7;
            // 
            // colorNotDone
            // 
            this.colorNotDone.BackColor = System.Drawing.Color.Black;
            this.colorNotDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorNotDone.Location = new System.Drawing.Point(112, 64);
            this.colorNotDone.Name = "colorNotDone";
            this.colorNotDone.SelectedColor = System.Drawing.Color.Black;
            this.colorNotDone.Size = new System.Drawing.Size(240, 24);
            this.colorNotDone.TabIndex = 4;
            // 
            // hotkeyIncrement
            // 
            this.hotkeyIncrement.Hotkey = null;
            this.hotkeyIncrement.Location = new System.Drawing.Point(112, 38);
            this.hotkeyIncrement.Name = "hotkeyIncrement";
            this.hotkeyIncrement.Size = new System.Drawing.Size(240, 20);
            this.hotkeyIncrement.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Double Tap Prevention:";
            // 
            // numDoubleTapPrevention
            // 
            this.numDoubleTapPrevention.Location = new System.Drawing.Point(138, 207);
            this.numDoubleTapPrevention.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numDoubleTapPrevention.Name = "numDoubleTapPrevention";
            this.numDoubleTapPrevention.Size = new System.Drawing.Size(67, 20);
            this.numDoubleTapPrevention.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "ms";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 299);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numDoubleTapPrevention);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textFormat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fontInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.colorBackground);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.colorDone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colorNotDone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hotkeyIncrement);
            this.Controls.Add(this.numMax);
            this.Controls.Add(this.label1);
            this.Name = "ConfigForm";
            this.Text = "CountAnything: Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDoubleTapPrevention)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMax;
        private HotkeyInput hotkeyIncrement;
        private System.Windows.Forms.Label label2;
        private ColorInput colorNotDone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ColorInput colorDone;
        private System.Windows.Forms.Label label5;
        private ColorInput colorBackground;
        private System.Windows.Forms.Label label6;
        private FontInput fontInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textFormat;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numDoubleTapPrevention;
        private System.Windows.Forms.Label label10;
    }
}

