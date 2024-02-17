namespace NotepadPlus.Forms
{
    public partial class AddLang : Form
    {
        public AddLang()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem!);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string str = $"[{textBox1.Text},{textBox2.Text}]";
            if (!listBox1.Items.Contains(str))
            {
                listBox1.Items.Add(str);
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            File.WriteAllBytes(textBox3.Text, ""u8.ToArray());
            foreach (string str in listBox1.Items)
            {
                File.AppendAllText(textBox3.Text, str + '\n');
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox4.Text))
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(File.ReadAllLines(textBox4.Text));
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
