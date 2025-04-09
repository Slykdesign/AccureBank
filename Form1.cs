using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccureBank2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int startP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (startP < 100)
            {
                startP += 1;
                Progress.Value = startP;
            }
            else
            {
                Progress.Value = 0;
                timer1.Stop();
                startP = 0; // Reset startP to 0 after reaching 100
                Login Obj = new Login();
                Obj.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
