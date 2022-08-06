namespace GPL_APP
{
    partial class GplApplication
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
            this.cmdLine = new System.Windows.Forms.TextBox();
            this.console = new System.Windows.Forms.TextBox();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.error_label = new System.Windows.Forms.Label();
            this.cmdText = new System.Windows.Forms.RichTextBox();
            this.fillcolor_label = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.displayWindow = new System.Windows.Forms.PictureBox();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLine
            // 
            this.cmdLine.AccessibleName = "commandTextBox";
            this.cmdLine.BackColor = System.Drawing.Color.LightGray;
            this.cmdLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdLine.ForeColor = System.Drawing.Color.Lime;
            this.cmdLine.Location = new System.Drawing.Point(575, 472);
            this.cmdLine.Name = "cmdLine";
            this.cmdLine.Size = new System.Drawing.Size(180, 30);
            this.cmdLine.TabIndex = 1;
            this.cmdLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdLine_KeyDown);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.Black;
            this.console.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.Color.LimeGreen;
            this.console.Location = new System.Drawing.Point(12, 469);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(551, 65);
            this.console.TabIndex = 6;
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.RosyBrown;
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(838, 30);
            this.menuBar.TabIndex = 5;
            this.menuBar.Text = "menuBar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFile,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFile
            // 
            this.loadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(224, 26);
            this.loadFile.Text = "Load";
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "Clear";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.MenuClearClick);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.MenuResetClick);
            // 
            // error_label
            // 
            this.error_label.BackColor = System.Drawing.SystemColors.InfoText;
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(12, 414);
            this.error_label.Name = "error_label";
            this.error_label.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.error_label.Size = new System.Drawing.Size(547, 52);
            this.error_label.TabIndex = 8;
            this.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdText
            // 
            this.cmdText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmdText.ForeColor = System.Drawing.Color.Black;
            this.cmdText.Location = new System.Drawing.Point(575, 42);
            this.cmdText.Name = "cmdText";
            this.cmdText.Size = new System.Drawing.Size(251, 424);
            this.cmdText.TabIndex = 9;
            this.cmdText.Text = "";
            // 
            // fillcolor_label
            // 
            this.fillcolor_label.BackColor = System.Drawing.Color.MistyRose;
            this.fillcolor_label.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillcolor_label.ForeColor = System.Drawing.Color.Black;
            this.fillcolor_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fillcolor_label.Location = new System.Drawing.Point(305, 414);
            this.fillcolor_label.Name = "fillcolor_label";
            this.fillcolor_label.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.fillcolor_label.Size = new System.Drawing.Size(254, 51);
            this.fillcolor_label.TabIndex = 10;
            this.fillcolor_label.Text = "Fill : ❌ / Color : Black";
            this.fillcolor_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_run
            // 
            this.btn_run.BackColor = System.Drawing.Color.Tomato;
            this.btn_run.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_run.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_run.ForeColor = System.Drawing.Color.Black;
            this.btn_run.Location = new System.Drawing.Point(761, 472);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(65, 26);
            this.btn_run.TabIndex = 3;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.textCompile);
            // 
            // displayWindow
            // 
            this.displayWindow.BackColor = System.Drawing.Color.MistyRose;
            this.displayWindow.Location = new System.Drawing.Point(12, 42);
            this.displayWindow.Name = "displayWindow";
            this.displayWindow.Size = new System.Drawing.Size(548, 369);
            this.displayWindow.TabIndex = 2;
            this.displayWindow.TabStop = false;
            this.displayWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.displayWindow_Paint);
            // 
            // GplApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(838, 536);
            this.Controls.Add(this.fillcolor_label);
            this.Controls.Add(this.cmdText);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.console);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.displayWindow);
            this.Controls.Add(this.cmdLine);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Salmon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuBar;
            this.Name = "GplApplication";
            this.Text = " ";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cmdLine;
        private System.Windows.Forms.PictureBox displayWindow;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFile;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.RichTextBox cmdText;
        private System.Windows.Forms.Label fillcolor_label;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}

