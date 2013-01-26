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
            this.components = new System.ComponentModel.Container();
            this.textCounter = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.incrementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decrementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stayonTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textCounter
            // 
            this.textCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCounter.AutoSize = true;
            this.textCounter.ContextMenuStrip = this.contextMenuStrip;
            this.textCounter.Location = new System.Drawing.Point(58, 36);
            this.textCounter.Name = "textCounter";
            this.textCounter.Size = new System.Drawing.Size(103, 13);
            this.textCounter.TabIndex = 0;
            this.textCounter.Text = "tape1 is the greatest";
            this.textCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incrementToolStripMenuItem,
            this.decrementToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.setValueToolStripMenuItem,
            this.toolStripSeparator1,
            this.configureToolStripMenuItem,
            this.stayonTopToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 214);
            // 
            // incrementToolStripMenuItem
            // 
            this.incrementToolStripMenuItem.Name = "incrementToolStripMenuItem";
            this.incrementToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.incrementToolStripMenuItem.Text = "&Increment";
            this.incrementToolStripMenuItem.Click += new System.EventHandler(this.MenuIncrementOnClick);
            // 
            // decrementToolStripMenuItem
            // 
            this.decrementToolStripMenuItem.Name = "decrementToolStripMenuItem";
            this.decrementToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decrementToolStripMenuItem.Text = "&Decrement";
            this.decrementToolStripMenuItem.Click += new System.EventHandler(this.MenuDecrementOnClick);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.MenuResetOnClick);
            // 
            // setValueToolStripMenuItem
            // 
            this.setValueToolStripMenuItem.Name = "setValueToolStripMenuItem";
            this.setValueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.setValueToolStripMenuItem.Text = "&Set value...";
            this.setValueToolStripMenuItem.Click += new System.EventHandler(this.MenuSetValueOnClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configureToolStripMenuItem.Text = "&Configure...";
            // 
            // stayonTopToolStripMenuItem
            // 
            this.stayonTopToolStripMenuItem.CheckOnClick = true;
            this.stayonTopToolStripMenuItem.Name = "stayonTopToolStripMenuItem";
            this.stayonTopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stayonTopToolStripMenuItem.Text = "Stay &on top";
            this.stayonTopToolStripMenuItem.CheckedChanged += new System.EventHandler(this.MenuStayOnTopOnCheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.MenuAboutOnClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.MenuExitOnClick);
            // 
            // CounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 78);
            this.Controls.Add(this.textCounter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "CounterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CountAnything";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textCounter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem incrementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decrementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stayonTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}