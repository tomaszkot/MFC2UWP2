using System.Windows.Forms;
using WUX = Windows.UI.Xaml;

namespace ManagedLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void SetMessageText(string message)
        {
            txtMessage.Text = message + " windowsXamlHost!";

        }

       

        private void MyButton_Click(object sender, WUX.RoutedEventArgs e)
        {
            MessageBox.Show("clicked btn from winUI!");
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
        }
    }
}
