namespace CountAnything.Forms {
    partial class ConfigDialog {
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tableGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.tabPageDisplay = new System.Windows.Forms.TabPage();
            this.tableDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.colorBackground = new CountAnything.Controls.ColorInput();
            this.colorNotDone = new CountAnything.Controls.ColorInput();
            this.colorDone = new CountAnything.Controls.ColorInput();
            this.fontInput = new CountAnything.Controls.FontInput();
            this.textFormat = new System.Windows.Forms.TextBox();
            this.linkFormatHelp = new System.Windows.Forms.LinkLabel();
            this.linkGeneralFormatHelp = new System.Windows.Forms.LinkLabel();
            this.tabPageHotkeys = new System.Windows.Forms.TabPage();
            this.tableHotkeys = new System.Windows.Forms.TableLayoutPanel();
            this.hotkeyReset = new CountAnything.Controls.HotkeyInput();
            this.hotkeyDecrement = new CountAnything.Controls.HotkeyInput();
            this.tableDoubleTapPrevention = new System.Windows.Forms.TableLayoutPanel();
            this.numDoubleTapPrevention = new System.Windows.Forms.NumericUpDown();
            this.hotkeyIncrement = new CountAnything.Controls.HotkeyInput();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tableGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            this.tabPageDisplay.SuspendLayout();
            this.tableDisplay.SuspendLayout();
            this.tabPageHotkeys.SuspendLayout();
            this.tableHotkeys.SuspendLayout();
            this.tableDoubleTapPrevention.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDoubleTapPrevention)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 24);
            label1.TabIndex = 0;
            label1.Text = "Count to what:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 24);
            label2.TabIndex = 0;
            label2.Text = "Not finished color:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 24);
            label3.TabIndex = 0;
            label3.Text = "Finished color:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 48);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(94, 24);
            label4.TabIndex = 0;
            label4.Text = "Background color:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 72);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(31, 24);
            label5.TabIndex = 0;
            label5.Text = "Font:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(3, 96);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 24);
            label6.TabIndex = 0;
            label6.Text = "Format:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(3, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(120, 24);
            label7.TabIndex = 0;
            label7.Text = "Double Tap Prevention:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(234, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(20, 24);
            label8.TabIndex = 0;
            label8.Text = "ms";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(3, 24);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(57, 26);
            label9.TabIndex = 0;
            label9.Text = "Increment:";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(3, 50);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(62, 26);
            label10.TabIndex = 0;
            label10.Text = "Decrement:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(3, 76);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(38, 26);
            label11.TabIndex = 0;
            label11.Text = "Reset:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageGeneral);
            this.tabControl.Controls.Add(this.tabPageDisplay);
            this.tabControl.Controls.Add(this.tabPageHotkeys);
            this.tabControl.Location = new System.Drawing.Point(9, 9);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(397, 185);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.tableGeneral);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(389, 159);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // tableGeneral
            // 
            this.tableGeneral.ColumnCount = 2;
            this.tableGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableGeneral.Controls.Add(label1, 0, 0);
            this.tableGeneral.Controls.Add(this.numMax, 1, 0);
            this.tableGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableGeneral.Location = new System.Drawing.Point(3, 3);
            this.tableGeneral.Name = "tableGeneral";
            this.tableGeneral.RowCount = 2;
            this.tableGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableGeneral.Size = new System.Drawing.Size(383, 153);
            this.tableGeneral.TabIndex = 0;
            // 
            // numMax
            // 
            this.numMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMax.Location = new System.Drawing.Point(85, 3);
            this.numMax.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(295, 20);
            this.numMax.TabIndex = 1;
            this.numMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMax.ValueChanged += new System.EventHandler(this.NumMaxOnChanged);
            // 
            // tabPageDisplay
            // 
            this.tabPageDisplay.Controls.Add(this.tableDisplay);
            this.tabPageDisplay.Location = new System.Drawing.Point(4, 22);
            this.tabPageDisplay.Name = "tabPageDisplay";
            this.tabPageDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDisplay.Size = new System.Drawing.Size(389, 159);
            this.tabPageDisplay.TabIndex = 1;
            this.tabPageDisplay.Text = "Display";
            this.tabPageDisplay.UseVisualStyleBackColor = true;
            // 
            // tableDisplay
            // 
            this.tableDisplay.ColumnCount = 2;
            this.tableDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDisplay.Controls.Add(this.colorBackground, 1, 2);
            this.tableDisplay.Controls.Add(label2, 0, 0);
            this.tableDisplay.Controls.Add(this.colorNotDone, 1, 0);
            this.tableDisplay.Controls.Add(label3, 0, 1);
            this.tableDisplay.Controls.Add(this.colorDone, 1, 1);
            this.tableDisplay.Controls.Add(label4, 0, 2);
            this.tableDisplay.Controls.Add(label5, 0, 3);
            this.tableDisplay.Controls.Add(this.fontInput, 1, 3);
            this.tableDisplay.Controls.Add(label6, 0, 4);
            this.tableDisplay.Controls.Add(this.textFormat, 1, 4);
            this.tableDisplay.Controls.Add(this.linkFormatHelp, 0, 5);
            this.tableDisplay.Controls.Add(this.linkGeneralFormatHelp, 1, 5);
            this.tableDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDisplay.Location = new System.Drawing.Point(3, 3);
            this.tableDisplay.Name = "tableDisplay";
            this.tableDisplay.RowCount = 7;
            this.tableDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDisplay.Size = new System.Drawing.Size(383, 153);
            this.tableDisplay.TabIndex = 0;
            // 
            // colorBackground
            // 
            this.colorBackground.BackColor = System.Drawing.Color.Black;
            this.colorBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorBackground.Location = new System.Drawing.Point(103, 51);
            this.colorBackground.Name = "colorBackground";
            this.colorBackground.SelectedColor = System.Drawing.Color.Black;
            this.colorBackground.Size = new System.Drawing.Size(277, 18);
            this.colorBackground.TabIndex = 3;
            this.colorBackground.SelectedColorChanged += new System.EventHandler<System.EventArgs>(this.ColorBackgroundOnChanged);
            // 
            // colorNotDone
            // 
            this.colorNotDone.BackColor = System.Drawing.Color.Black;
            this.colorNotDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorNotDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorNotDone.Location = new System.Drawing.Point(103, 3);
            this.colorNotDone.Name = "colorNotDone";
            this.colorNotDone.SelectedColor = System.Drawing.Color.Black;
            this.colorNotDone.Size = new System.Drawing.Size(277, 18);
            this.colorNotDone.TabIndex = 1;
            this.colorNotDone.SelectedColorChanged += new System.EventHandler<System.EventArgs>(this.ColorNotDoneOnChanged);
            // 
            // colorDone
            // 
            this.colorDone.BackColor = System.Drawing.Color.Black;
            this.colorDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorDone.Location = new System.Drawing.Point(103, 27);
            this.colorDone.Name = "colorDone";
            this.colorDone.SelectedColor = System.Drawing.Color.Black;
            this.colorDone.Size = new System.Drawing.Size(277, 18);
            this.colorDone.TabIndex = 2;
            this.colorDone.SelectedColorChanged += new System.EventHandler<System.EventArgs>(this.ColorDoneOnChanged);
            // 
            // fontInput
            // 
            this.fontInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontInput.Location = new System.Drawing.Point(103, 75);
            this.fontInput.Name = "fontInput";
            this.fontInput.ReadOnly = true;
            this.fontInput.SelectedFont = null;
            this.fontInput.Size = new System.Drawing.Size(277, 20);
            this.fontInput.TabIndex = 4;
            this.fontInput.Text = "(null)";
            this.fontInput.SelectedFontChanged += new System.EventHandler<System.EventArgs>(this.FontInputOnChanged);
            // 
            // textFormat
            // 
            this.textFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textFormat.Location = new System.Drawing.Point(103, 99);
            this.textFormat.Name = "textFormat";
            this.textFormat.Size = new System.Drawing.Size(277, 20);
            this.textFormat.TabIndex = 5;
            this.textFormat.TextChanged += new System.EventHandler(this.TextFormatOnChanged);
            // 
            // linkFormatHelp
            // 
            this.linkFormatHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkFormatHelp.AutoSize = true;
            this.linkFormatHelp.Location = new System.Drawing.Point(3, 120);
            this.linkFormatHelp.Name = "linkFormatHelp";
            this.linkFormatHelp.Size = new System.Drawing.Size(75, 20);
            this.linkFormatHelp.TabIndex = 6;
            this.linkFormatHelp.TabStop = true;
            this.linkFormatHelp.Text = "Format indices";
            this.linkFormatHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkFormatHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkFormatHelpOnLinkClicked);
            // 
            // linkGeneralFormatHelp
            // 
            this.linkGeneralFormatHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkGeneralFormatHelp.AutoSize = true;
            this.linkGeneralFormatHelp.Location = new System.Drawing.Point(103, 120);
            this.linkGeneralFormatHelp.Name = "linkGeneralFormatHelp";
            this.linkGeneralFormatHelp.Size = new System.Drawing.Size(116, 20);
            this.linkGeneralFormatHelp.TabIndex = 7;
            this.linkGeneralFormatHelp.TabStop = true;
            this.linkGeneralFormatHelp.Text = "General formatting help";
            this.linkGeneralFormatHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkGeneralFormatHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGeneralFormatHelpOnLinkClicked);
            // 
            // tabPageHotkeys
            // 
            this.tabPageHotkeys.Controls.Add(this.tableHotkeys);
            this.tabPageHotkeys.Location = new System.Drawing.Point(4, 22);
            this.tabPageHotkeys.Name = "tabPageHotkeys";
            this.tabPageHotkeys.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHotkeys.Size = new System.Drawing.Size(389, 159);
            this.tabPageHotkeys.TabIndex = 2;
            this.tabPageHotkeys.Text = "Hotkeys";
            this.tabPageHotkeys.UseVisualStyleBackColor = true;
            // 
            // tableHotkeys
            // 
            this.tableHotkeys.ColumnCount = 2;
            this.tableHotkeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableHotkeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableHotkeys.Controls.Add(this.hotkeyReset, 1, 3);
            this.tableHotkeys.Controls.Add(this.hotkeyDecrement, 1, 2);
            this.tableHotkeys.Controls.Add(label7, 0, 0);
            this.tableHotkeys.Controls.Add(this.tableDoubleTapPrevention, 1, 0);
            this.tableHotkeys.Controls.Add(label9, 0, 1);
            this.tableHotkeys.Controls.Add(label10, 0, 2);
            this.tableHotkeys.Controls.Add(label11, 0, 3);
            this.tableHotkeys.Controls.Add(this.hotkeyIncrement, 1, 1);
            this.tableHotkeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableHotkeys.Location = new System.Drawing.Point(3, 3);
            this.tableHotkeys.Name = "tableHotkeys";
            this.tableHotkeys.RowCount = 5;
            this.tableHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableHotkeys.Size = new System.Drawing.Size(383, 153);
            this.tableHotkeys.TabIndex = 0;
            // 
            // hotkeyReset
            // 
            this.hotkeyReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotkeyReset.Hotkey = null;
            this.hotkeyReset.Location = new System.Drawing.Point(129, 79);
            this.hotkeyReset.Name = "hotkeyReset";
            this.hotkeyReset.Size = new System.Drawing.Size(251, 20);
            this.hotkeyReset.TabIndex = 4;
            // 
            // hotkeyDecrement
            // 
            this.hotkeyDecrement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotkeyDecrement.Hotkey = null;
            this.hotkeyDecrement.Location = new System.Drawing.Point(129, 53);
            this.hotkeyDecrement.Name = "hotkeyDecrement";
            this.hotkeyDecrement.Size = new System.Drawing.Size(251, 20);
            this.hotkeyDecrement.TabIndex = 3;
            // 
            // tableDoubleTapPrevention
            // 
            this.tableDoubleTapPrevention.ColumnCount = 2;
            this.tableDoubleTapPrevention.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDoubleTapPrevention.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableDoubleTapPrevention.Controls.Add(label8, 1, 0);
            this.tableDoubleTapPrevention.Controls.Add(this.numDoubleTapPrevention, 0, 0);
            this.tableDoubleTapPrevention.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDoubleTapPrevention.Location = new System.Drawing.Point(126, 0);
            this.tableDoubleTapPrevention.Margin = new System.Windows.Forms.Padding(0);
            this.tableDoubleTapPrevention.Name = "tableDoubleTapPrevention";
            this.tableDoubleTapPrevention.RowCount = 1;
            this.tableDoubleTapPrevention.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDoubleTapPrevention.Size = new System.Drawing.Size(257, 24);
            this.tableDoubleTapPrevention.TabIndex = 1;
            // 
            // numDoubleTapPrevention
            // 
            this.numDoubleTapPrevention.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDoubleTapPrevention.Location = new System.Drawing.Point(3, 3);
            this.numDoubleTapPrevention.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numDoubleTapPrevention.Name = "numDoubleTapPrevention";
            this.numDoubleTapPrevention.Size = new System.Drawing.Size(225, 20);
            this.numDoubleTapPrevention.TabIndex = 0;
            // 
            // hotkeyIncrement
            // 
            this.hotkeyIncrement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotkeyIncrement.Hotkey = null;
            this.hotkeyIncrement.Location = new System.Drawing.Point(129, 27);
            this.hotkeyIncrement.Name = "hotkeyIncrement";
            this.hotkeyIncrement.Size = new System.Drawing.Size(251, 20);
            this.hotkeyIncrement.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(9, 197);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSaveOnClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(328, 197);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelOnClick);
            // 
            // ConfigDialog
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(415, 227);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControl);
            this.Name = "ConfigDialog";
            this.Text = "CountAnything: Configuration";
            this.tabControl.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tableGeneral.ResumeLayout(false);
            this.tableGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            this.tabPageDisplay.ResumeLayout(false);
            this.tableDisplay.ResumeLayout(false);
            this.tableDisplay.PerformLayout();
            this.tabPageHotkeys.ResumeLayout(false);
            this.tableHotkeys.ResumeLayout(false);
            this.tableHotkeys.PerformLayout();
            this.tableDoubleTapPrevention.ResumeLayout(false);
            this.tableDoubleTapPrevention.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDoubleTapPrevention)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageDisplay;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TabPage tabPageHotkeys;
        private System.Windows.Forms.TableLayoutPanel tableGeneral;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.TableLayoutPanel tableDisplay;
        private Controls.ColorInput colorNotDone;
        private Controls.ColorInput colorDone;
        private Controls.ColorInput colorBackground;
        private Controls.FontInput fontInput;
        private System.Windows.Forms.TextBox textFormat;
        private System.Windows.Forms.LinkLabel linkFormatHelp;
        private System.Windows.Forms.TableLayoutPanel tableHotkeys;
        private System.Windows.Forms.TableLayoutPanel tableDoubleTapPrevention;
        private System.Windows.Forms.NumericUpDown numDoubleTapPrevention;
        private Controls.HotkeyInput hotkeyIncrement;
        private Controls.HotkeyInput hotkeyReset;
        private Controls.HotkeyInput hotkeyDecrement;
        private System.Windows.Forms.LinkLabel linkGeneralFormatHelp;
    }
}