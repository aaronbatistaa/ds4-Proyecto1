using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace Proyecto_1
{
    public partial class Form1 : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]     //libreria para poder mover la aplicación libremente mediante el panel de acciones
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        //variables para ingreso de datos
        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void PnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || enterValue) txtDisplay.Text = string.Empty;

            enterValue = false;
            Button but = (Button)sender;
            if (but.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + but.Text;
            }
            else txtDisplay.Text = txtDisplay.Text + but.Text;
        }

        private void btnBasicMathOp_Click(object sender, EventArgs e)
        {
            if (result != 0) btnEqual.PerformClick();
            else result = Double.Parse(txtDisplay.Text);

            Button but = (Button)sender;
            operation = but.Text;
            enterValue = true;
            if (txtDisplay.Text != "0")
            {
                txtDisplayProvi.Text = fstNum = $"{result} {operation}";
                txtDisplay.Text = string.Empty;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secNum = txtDisplay.Text;
            txtDisplayProvi.Text = $"{txtDisplayProvi.Text} {txtDisplay.Text} =";
            if (txtDisplay.Text != string.Empty)
            {
                if (txtDisplay.Text == "0") txtDisplayProvi.Text = string.Empty;
                switch (operation)
                {
                    case "+":
                        txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                        rtBoxHistory.AppendText($"{fstNum} {secNum} = {txtDisplay.Text} \n");
                        break;
                    case "-":
                        txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                        rtBoxHistory.AppendText($"{fstNum} {secNum} = {txtDisplay.Text} \n");
                        break;
                    case "x":
                        txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                        rtBoxHistory.AppendText($"{fstNum} {secNum} = {txtDisplay.Text} \n");
                        break;
                    case "÷":
                        txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                        rtBoxHistory.AppendText($"{fstNum} {secNum} = {txtDisplay.Text} \n");
                        break;
                    default:
                        txtDisplayProvi.Text = $"{txtDisplay.Text} = ";
                        break;
                }

                result = Double.Parse(txtDisplay.Text);    //guarda el resultado para mostrarse en el display provicional de arriba para nuevas operaciones
                operation = string.Empty;         //limpia el resultado
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            PnlHistory.Height = (PnlHistory.Height == 5) ? PnlHistory.Height = 410 : 5;
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            rtBoxHistory.Clear();
            if (rtBoxHistory.Text == string.Empty)
                rtBoxHistory.Text = "No se ha registrado ninguna operación";
        }
    }
}
