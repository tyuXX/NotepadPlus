using NotepadPlus.Forms;
using System.ComponentModel;
using System.Diagnostics;
using static NotepadPlus.Localizer;
using static NotepadPlus.Extra;

namespace NotepadPlus
{
    public partial class Main : Form
    {
        public Font font = new("Monospaced", 11, FontStyle.Regular);
        public Color TextBoxColor = Color.White;
        public Color TextColor = Color.Black;
        public Main()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (TabPage tp in textTabs.TabPages)
            {
                if (tp.Text.Contains(i.ToString()) && tp.Text.Contains(currentLang.GetString("untitled")))
                {
                    i++;
                }
            }
            TextedTabPage tabPage = new(this)
            {
                Tag = currentLang.GetString("untitled"),
                Text = currentLang.GetString("untitled") + ' ' + i
            };
            textTabs.TabPages.Add(tabPage);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTabPage((TextedTabPage)textTabs.SelectedTab);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetOp("opening");
            if (oDig.ShowDialog() == DialogResult.OK)
            {
                foreach (string str in oDig.FileNames)
                {
                    TextedTabPage tabPage = new(this)
                    {
                        Tag = str,
                        Text = str
                    };
                    tabPage.richTextBox.Text = File.ReadAllText(str);
                    textTabs.TabPages.Add(tabPage);
                }
            }
            SetOp("ready");
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textTabs.TabPages.Count > 0)
            {
                toolStripLabel3.Text = $"{currentLang.GetString("file")}:{textTabs.SelectedTab.Tag}";
                Text = $"Notepad+ [{textTabs.SelectedTab.Text}]";
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem3_Click(sender, e);
            SetLang("en-us");
            toolStripComboBox1.Text = "en-us";
            textTabs.ContextMenuStrip = contextMenuStrip;
            NewToolStripMenuItem_Click(this, e);
            SetOp("ready");

        }
        internal static void SetLang(string lang)
        {
            currentLang = GetLang(lang);
            if (currentLang != default)
            {

            }
            //todo load all stuff
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textTabs.SelectedTab != null)
            {
                textTabs.TabPages.Remove(textTabs.SelectedTab);
            }
        }

        private void SaveThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToolStripMenuItem_Click(this, e);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTabPageAs((TextedTabPage)textTabs.SelectedTab);
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fDig.ShowDialog() == DialogResult.OK)
            {
                font = fDig.Font;
                foreach (TabPage tabPage in textTabs.TabPages)
                {
                    if (tabPage is TextedTabPage tpsTab)
                    {
                        tpsTab.richTextBox.Font = font;
                    }
                }
            }
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetOp("closing");
            textTabs.TabPages.Clear();
            NewToolStripMenuItem_Click(this, e);
            SetOp("ready");
        }

        private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            Point p = textTabs.PointToClient(Cursor.Position);
            for (int i = 0; i < textTabs.TabCount; i++)
            {
                if (textTabs.GetTabRect(i).Contains(p))
                {
                    textTabs.SelectedIndex = i;
                    return;
                }
            }
            e.Cancel = true;
        }

        private void PageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cDig.ShowDialog() == DialogResult.OK)
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

        private void TextBoxColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cDig.ShowDialog() == DialogResult.OK)
            {
                foreach (TextedTabPage tabPage in textTabs.TabPages)
                {
                    tabPage.richTextBox.BackColor = cDig.Color;
                }
                TextBoxColor = cDig.Color;
            }
        }

        private void TextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cDig.ShowDialog() == DialogResult.OK)
            {
                foreach (TextedTabPage tabPage in textTabs.TabPages)
                {
                    tabPage.richTextBox.ForeColor = cDig.Color;
                }
                TextColor = cDig.Color;
            }
        }
        private void SetOp(string str)
        {
            toolStripLabel4.Text = currentLang.GetString("operation") + ':' + currentLang.GetString(str);
        }

        private void SaveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TextedTabPage ttp in textTabs.TabPages)
            {
                SaveTabPage(ttp);
            }
        }
        private void SaveTabPage(TextedTabPage tabPage)
        {
            if (tabPage.Tag is not null && File.Exists(tabPage.Tag.ToString()))
            {
                SetOp("saving");
#pragma warning disable CS8604 // Olasý null baþvuru baðýmsýz deðiþkeni.
                File.WriteAllText(tabPage.Tag.ToString(), tabPage.richTextBox.Text);
#pragma warning restore CS8604 // Olasý null baþvuru baðýmsýz deðiþkeni.
                tabPage.Text = tabPage.Text.Replace("*", string.Empty);
                SetOp("ready");
            }
            else
            {
                SaveTabPageAs(tabPage);
            }
        }
        private void SaveTabPageAs(TextedTabPage tabPage)
        {
            SetOp("saving");
            if (sDig.ShowDialog() == DialogResult.OK)
            {
                tabPage.Tag = sDig.FileName;
                tabPage.Text = sDig.FileName;
                File.WriteAllText(sDig.FileName, textTabs.SelectedTab.Controls[0].Text);
            }
            SetOp("ready");
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            LoadAll(@".\langs");
            foreach (string str in _langs.Keys)
            {
                toolStripComboBox1.Items.Add(str);
            }
        }

        private void ToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLang(toolStripComboBox1.SelectedItem.ToString());
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if(form is AddLang)
                {
                    return;
                }
            }
            OpenForm<AddLang>();
        }
    }
    public class TextedTabPage : TabPage
    {
        public Main mainform;
        public RichTextBox richTextBox = new();
        public TextedTabPage( Main mf )
        {
            mainform = mf;
            richTextBox.Dock = DockStyle.Fill;
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
            mainform.toolStripLabel1.Text = currentLang.GetString("line") + ": " + line.ToString();
            mainform.toolStripLabel2.Text = currentLang.GetString("column") + ": " + col.ToString();
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