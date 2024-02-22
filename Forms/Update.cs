namespace NotepadPlus.Forms
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {

        }

        private void Update_Load( object sender, EventArgs e )
        {
            string Version = new HttpClient().GetStringAsync( "" ).ToString() ?? string.Empty;
            label1.Text += Version.buildVersion;
            label2.Text += new HttpClient().GetStringAsync("");
        }
    }
}
