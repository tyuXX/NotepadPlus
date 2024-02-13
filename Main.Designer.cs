namespace NotepadPlus
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            saveAllToolStripMenuItem = new ToolStripMenuItem();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripComboBox1 = new ToolStripComboBox();
            fontToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            pageColorToolStripMenuItem = new ToolStripMenuItem();
            textBoxColorToolStripMenuItem = new ToolStripMenuItem();
            textColorToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            textTabs = new TabControl();
            fDig = new FontDialog();
            sDig = new SaveFileDialog();
            oDig = new OpenFileDialog();
            toolStrip = new ToolStrip();
            toolStripLabel4 = new ToolStripLabel();
            toolStripLabel3 = new ToolStripLabel();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            contextMenuStrip = new ContextMenuStrip(components);
            saveThisToolStripMenuItem = new ToolStripMenuItem();
            saveThisAsToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            cDig = new ColorDialog();
            menuStrip1.SuspendLayout();
            toolStrip.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(661, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator1, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator2, saveAllToolStripMenuItem, closeAllToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(177, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(177, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(174, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(177, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(177, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(174, 6);
            // 
            // saveAllToolStripMenuItem
            // 
            saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            saveAllToolStripMenuItem.Size = new Size(177, 22);
            saveAllToolStripMenuItem.Text = "Save All";
            saveAllToolStripMenuItem.Click += SaveAllToolStripMenuItem_Click;
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(177, 22);
            closeAllToolStripMenuItem.Text = "Close All";
            closeAllToolStripMenuItem.Click += CloseAllToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, fontToolStripMenuItem, toolStripSeparator3, pageColorToolStripMenuItem, textBoxColorToolStripMenuItem, textColorToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem2, toolStripSeparator4, toolStripComboBox1 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "Localization";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(181, 22);
            toolStripMenuItem3.Text = "Refresh";
            toolStripMenuItem3.Click += ToolStripMenuItem3_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(181, 22);
            toolStripMenuItem2.Text = "Add New";
            toolStripMenuItem2.Click += ToolStripMenuItem2_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(178, 6);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            toolStripComboBox1.SelectedIndexChanged += ToolStripComboBox1_SelectedIndexChanged;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(180, 22);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += FontToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // pageColorToolStripMenuItem
            // 
            pageColorToolStripMenuItem.Name = "pageColorToolStripMenuItem";
            pageColorToolStripMenuItem.Size = new Size(180, 22);
            pageColorToolStripMenuItem.Text = "Page Color";
            pageColorToolStripMenuItem.Click += PageColorToolStripMenuItem_Click;
            // 
            // textBoxColorToolStripMenuItem
            // 
            textBoxColorToolStripMenuItem.Name = "textBoxColorToolStripMenuItem";
            textBoxColorToolStripMenuItem.Size = new Size(180, 22);
            textBoxColorToolStripMenuItem.Text = "TextBox Color";
            textBoxColorToolStripMenuItem.Click += TextBoxColorToolStripMenuItem_Click;
            // 
            // textColorToolStripMenuItem
            // 
            textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            textColorToolStripMenuItem.Size = new Size(180, 22);
            textColorToolStripMenuItem.Text = "Text Color";
            textColorToolStripMenuItem.Click += TextColorToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // textTabs
            // 
            textTabs.Dock = DockStyle.Fill;
            textTabs.Location = new Point(0, 24);
            textTabs.Margin = new Padding(3, 2, 3, 2);
            textTabs.Name = "textTabs";
            textTabs.SelectedIndex = 0;
            textTabs.Size = new Size(661, 284);
            textTabs.TabIndex = 1;
            textTabs.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            // 
            // sDig
            // 
            sDig.Title = "Save File";
            // 
            // oDig
            // 
            oDig.Multiselect = true;
            oDig.Title = "Open Files";
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.Bottom;
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel4, toolStripLabel3, toolStripLabel1, toolStripLabel2 });
            toolStrip.Location = new Point(0, 283);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(661, 25);
            toolStrip.TabIndex = 2;
            toolStrip.Text = "toolStrip";
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(63, 22);
            toolStripLabel4.Text = "Operation:";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(54, 22);
            toolStripLabel3.Text = "File:NAN";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(58, 22);
            toolStripLabel1.Text = "Line:NAN";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(79, 22);
            toolStripLabel2.Text = "Column:NAN";
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { saveThisToolStripMenuItem, saveThisAsToolStripMenuItem, closeToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(139, 70);
            contextMenuStrip.Opening += ContextMenuStrip_Opening;
            // 
            // saveThisToolStripMenuItem
            // 
            saveThisToolStripMenuItem.Name = "saveThisToolStripMenuItem";
            saveThisToolStripMenuItem.Size = new Size(138, 22);
            saveThisToolStripMenuItem.Text = "Save This";
            saveThisToolStripMenuItem.Click += SaveThisToolStripMenuItem_Click;
            // 
            // saveThisAsToolStripMenuItem
            // 
            saveThisAsToolStripMenuItem.Name = "saveThisAsToolStripMenuItem";
            saveThisAsToolStripMenuItem.Size = new Size(138, 22);
            saveThisAsToolStripMenuItem.Text = "Save This As";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(138, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 308);
            Controls.Add(toolStrip);
            Controls.Add(textTabs);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            Text = "Notepad+";
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private TabControl textTabs;
        private FontDialog fDig;
        private SaveFileDialog sDig;
        private OpenFileDialog oDig;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem saveThisToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        public ToolStrip toolStrip;
        private ToolStripMenuItem saveThisAsToolStripMenuItem;
        public ToolStripLabel toolStripLabel1;
        public ToolStripLabel toolStripLabel2;
        public ToolStripLabel toolStripLabel3;
        private ToolStripMenuItem closeAllToolStripMenuItem;
        private ToolStripMenuItem pageColorToolStripMenuItem;
        private ToolStripMenuItem textBoxColorToolStripMenuItem;
        private ToolStripMenuItem textColorToolStripMenuItem;
        private ColorDialog cDig;
        private ToolStripLabel toolStripLabel4;
        private ToolStripMenuItem saveAllToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripSeparator toolStripSeparator4;
    }
}