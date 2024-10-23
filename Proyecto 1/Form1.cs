using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Diagnostics;

namespace Proyecto_1
{
    public partial class Form1 : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]     //libreria para poder mover la aplicación libremente mediante el panel de acciones
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        //variables para ingreso y manejo de datos
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
            secNum = txtDisplay.Text;       //guarda el último valor
            txtDisplayProvi.Text = $"{txtDisplayProvi.Text} {txtDisplay.Text} =";
            if (txtDisplay.Text != string.Empty)
            {
                if (txtDisplay.Text == "0") txtDisplayProvi.Text = string.Empty;
                switch (operation)        //recibe el valor del texto del botón para saber la operacion
                {
                    case "+":
                        txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();  //muestra como la suma del resultado o primero número con el último ingresado 
                        rtBoxHistory.AppendText($"{fstNum} {secNum} = {txtDisplay.Text} \n");    //guarda el calculo en el historial
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
                        if (txtDisplay.Text != "∞")
                        {
                            rtBoxHistory.AppendText($"{fstNum} {secNum} = {txtDisplay.Text} \n");
                        }
                        break;
                    default:
                        txtDisplayProvi.Text = $"{txtDisplay.Text} = ";
                        break;
                }
                if (txtDisplay.Text == "∞")
                {
                    txtDisplay.Text = "No se puede dividir entre 0";
                } else
                {
                    result = Double.Parse(txtDisplay.Text);    //guarda el resultado para mostrarse en el display provicional de arriba para nuevas operaciones
                }
                operation = string.Empty;         //limpia el resultado
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            PnlHistory.Height = (PnlHistory.Height == 5) ? PnlHistory.Height = 410 : 5;        //actualiza la altura del panel para que se muestre por completo
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            if (rtBoxHistory.Text == string.Empty)
            {
                rtBoxHistory.Text = "No se ha registrado ninguna operación \n";
            }
            else rtBoxHistory.Clear();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)               //si la longitud del text es mayor a 0 quiere decir que hay caracteres
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);     //borra el primer caracter de izquierda a derecha
            }
            if (txtDisplay.Text == string.Empty) txtDisplay.Text = "0";          //si esta vacío generar 0
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";                           //display 0
            txtDisplayProvi.Text = string.Empty;             //vacia el display provicional
            result = 0;                                      //reset 
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";              //display 0
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();      //salir de la aplicación
        }

        private void btnUtp_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://utp.ac.pa/") { UseShellExecute = true });   //al hacer clic al logo dirigir al link referido
        }

        private void btnOtherOps_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            operation = but.Text;
            switch (operation)
            {
                case "√x":
                    txtDisplayProvi.Text = $"√({txtDisplay.Text})";
                    txtDisplay.Text = Convert.ToString(Math.Sqrt(Double.Parse(txtDisplay.Text)));
                    if (txtDisplay.Text == "NaN")
                    {
                        txtDisplay.Text = "No es posible";
                    }
                    break;
                case "x²":
                    txtDisplayProvi.Text = $"({txtDisplay.Text}^2)";
                    txtDisplay.Text = Convert.ToString(Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text));
                    break;
                case "sin":
                    txtDisplayProvi.Text = $"sin({txtDisplay.Text})";
                    txtDisplay.Text = Convert.ToString(Math.Sin(Double.Parse(txtDisplay.Text)));
                    break;
                case "cos":
                    txtDisplayProvi.Text = $"cos({txtDisplay.Text})";
                    txtDisplay.Text = Convert.ToString(Math.Sin(Double.Parse(txtDisplay.Text)));
                    break;
                case "neg":
                    if (txtDisplay.Text != "0")
                    {
                        txtDisplay.Text = Convert.ToString(-1 * Convert.ToDouble(txtDisplay.Text));   //multiplica por -1 para convertir numero a negativo, en caso de ya serlo lo convierte en positivo
                    }
                    break;
                default:
                    break;
            }
            if (txtDisplay.Text != "No es posible")
            {
                rtBoxHistory.AppendText($"{txtDisplayProvi.Text} = {txtDisplay.Text} \n");
            }
        }
    }
}
