using System.ComponentModel;
using System.Diagnostics;

namespace NotepadPlus
{
    public partial class Main : Form
    {
        public Font font = new( "Monospaced", 11, FontStyle.Regular );
        public Color TextBoxColor = Color.White;
        public Color TextColor = Color.Black;
        public Main()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int i = 1;
            foreach(TabPage tp in textTabs.TabPages)
            {
                if (tp.Text.Contains(i.ToString()) && tp.Text.Contains("Untitled"))
                {
                    i++;
                }
            }
            SpecTabPage tabPage = new( this )
            {
                Tag = "Untitled",
                Text = "Untitled " + i
            };
            textTabs.TabPages.Add( tabPage );
        }

        private void saveToolStripMenuItem_Click( object sender, EventArgs e )
        {
            SetOp("Saving");
            if (File.Exists( textTabs.SelectedTab.Tag!.ToString() ))
            {
                File.WriteAllText( textTabs.SelectedTab.Tag!.ToString(), textTabs.SelectedTab.Controls[0].Text );
                textTabs.SelectedTab.Text = textTabs.SelectedTab.Text.Replace("*",string.Empty);
                SetOp( "Ready" );
            }
            else
            {
                saveAsToolStripMenuItem_Click(this,e);
            }
        }

        private void OpenToolStripMenuItem_Click( object sender, EventArgs e )
        {
            SetOp( "Opening" );
            if (oDig.ShowDialog() == DialogResult.OK)
            {
                foreach(string str in oDig.FileNames)
                {
                    SpecTabPage tabPage = new( this )
                    {
                        Tag = str,
                        Text = str
                    };
                    tabPage.richTextBox.Text = File.ReadAllText(str);
                    textTabs.TabPages.Add( tabPage );
                }
            }
            SetOp( "Ready" );
        }

        private void TabControl1_SelectedIndexChanged( object sender, EventArgs e )
        {
            if(textTabs.TabPages.Count > 0)
            {
                toolStripLabel3.Text = $"File:{textTabs.SelectedTab.Tag}";
                Text = $"Notepad+ [{textTabs.SelectedTab.Text}]";
            }
        }

        private void Main_Load( object sender, EventArgs e )
        {
            textTabs.ContextMenuStrip = contextMenuStrip;
            NewToolStripMenuItem_Click(this,e);
            SetOp( "Ready" );
        }

        private void CloseToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if (textTabs.SelectedTab != null)
            {
                textTabs.TabPages.Remove( textTabs.SelectedTab );
            }
        }

        private void SaveThisToolStripMenuItem_Click( object sender, EventArgs e )
        {
            saveToolStripMenuItem_Click(this,e);
        }

        private void saveAsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            SetOp( "Saving" );
            if (sDig.ShowDialog() == DialogResult.OK)
            {
                textTabs.SelectedTab.Tag = sDig.FileName;
                textTabs.SelectedTab.Text = sDig.FileName;
                File.WriteAllText( sDig.FileName, textTabs.SelectedTab.Controls[0].Text );
            }
            SetOp( "Ready" );
        }

        private void FontToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if (fDig.ShowDialog() == DialogResult.OK)
            {
                font = fDig.Font;
                foreach (TabPage tabPage in textTabs.TabPages)
                {
                    if (tabPage is SpecTabPage tpsTab)
                    {
                        tpsTab.richTextBox.Font = font;
                    }
                }
            }
        }

        private void CloseAllToolStripMenuItem_Click( object sender, EventArgs e )
        {
            SetOp( "Closing" );
            textTabs.TabPages.Clear();
            NewToolStripMenuItem_Click(this,e);
            SetOp( "Ready" );
        }

        private void ContextMenuStrip_Opening( object sender, CancelEventArgs e )
        {
            Point p = textTabs.PointToClient( Cursor.Position );
            for (int i = 0; i < textTabs.TabCount; i++)
            {
                if (textTabs.GetTabRect( i ).Contains( p ))
                {
                    textTabs.SelectedIndex = i;
                    return;
                }
            }
            e.Cancel = true;
        }

        private void PageColorToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if (cDig.ShowDialog()==DialogResult.OK)
            {
                BackColor = cDig.Color;
                toolStrip.BackColor = cDig.Color;
                menuStrip1.BackColor = cDig.Color;
                foreach (TabPage tabPage in textTabs.TabPages)
                {
                    tabPage.BackColor = cDig.Color;
                }
            }
        }

        private void TextBoxColorToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if (cDig.ShowDialog() == DialogResult.OK)
            {
                foreach (SpecTabPage tabPage in textTabs.TabPages)
                {
                    tabPage.richTextBox.BackColor = cDig.Color;
                }
                TextBoxColor = cDig.Color;
            }
        }

        private void TextColorToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if (cDig.ShowDialog() == DialogResult.OK)
            {
                foreach (SpecTabPage tabPage in textTabs.TabPages)
                {
                    tabPage.richTextBox.ForeColor = cDig.Color;
                }
                TextColor = cDig.Color;
            }
        }
        private void SetOp(string str )
        {
            toolStripLabel4.Text = "Operation:" + str;
        }
    }
    public class SpecTabPage : TabPage
    {
        public Main mainform;
        public RichTextBox richTextBox = new();
        public SpecTabPage( Main mf )
        {
            mainform = mf;
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.Text = "";
            richTextBox.Font = mainform.font;
            richTextBox.Select();
            richTextBox.TextChanged += new EventHandler( RichTextBox_TextChanged );
            richTextBox.SelectionChanged += new EventHandler( RichTextBox_SelectionChanged );
            richTextBox.LinkClicked += new LinkClickedEventHandler( RichTextBox_LinkClicked );
            richTextBox.BackColor = mainform.TextBoxColor;
            richTextBox.ForeColor = mainform.TextColor;
            richTextBox.BorderStyle = BorderStyle.None;
            Controls.Add( richTextBox );
            BackColor = mainform.BackColor;
        }

        private void RichTextBox_TextChanged( object? sender, EventArgs e )
        {
            if (!Text.Contains( '*' ))
            {
                Text += '*';
            }
        }

        private void RichTextBox_SelectionChanged( object? sender, EventArgs e )
        {
            int sel = richTextBox.SelectionStart;
            int line = richTextBox.GetLineFromCharIndex( sel ) + 1;
            int col = sel - richTextBox.GetFirstCharIndexFromLine( line - 1 ) + 1;
            mainform.toolStripLabel1.Text = "Line : " + line.ToString();
            mainform.toolStripLabel2.Text = "Col : " + col.ToString();
        }

        private void RichTextBox_LinkClicked( object? sender, LinkClickedEventArgs e )
        {
            Process.Start( new ProcessStartInfo 
            { 
                FileName = e.LinkText, 
                UseShellExecute = true
            });
        }
    }
}