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

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
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
            secNum = txtDisplay.Text;       // guarda el último valor
            txtDisplayProvi.Text = $"{txtDisplayProvi.Text} {txtDisplay.Text} =";

            if (txtDisplay.Text != string.Empty)
            {
                if (txtDisplay.Text == "0") txtDisplayProvi.Text = string.Empty;
                string operacion = $"{fstNum} {secNum}";
                decimal resultadoDecimal = 0;

                switch (operation)        // recibe el valor del texto del botón para saber la operacion
                {
                    case "+":
                        resultadoDecimal = (decimal)(result + Double.Parse(txtDisplay.Text));
                        txtDisplay.Text = resultadoDecimal.ToString();
                        rtBoxHistory.AppendText($"{operacion} = {txtDisplay.Text} \n");
                        break;
                    case "-":
                        resultadoDecimal = (decimal)(result - Double.Parse(txtDisplay.Text));
                        txtDisplay.Text = resultadoDecimal.ToString();
                        rtBoxHistory.AppendText($"{operacion} = {txtDisplay.Text} \n");
                        break;
                    case "x":
                        resultadoDecimal = (decimal)(result * Double.Parse(txtDisplay.Text));
                        txtDisplay.Text = resultadoDecimal.ToString();
                        rtBoxHistory.AppendText($"{operacion} = {txtDisplay.Text} \n");
                        break;
                    case "÷":
                        resultadoDecimal = (decimal)(result / Double.Parse(txtDisplay.Text));
                        txtDisplay.Text = resultadoDecimal.ToString();
                        if (txtDisplay.Text != "∞")
                        {
                            rtBoxHistory.AppendText($"{operacion} = {txtDisplay.Text} \n");
                        }
                        break;
                    default:
                        txtDisplayProvi.Text = $"{txtDisplay.Text} = ";
                        break;
                }

                if (txtDisplay.Text == "∞")
                {
                    txtDisplay.Text = "No se puede dividir entre 0";
                }
                else
                {
                    // Guardar el cálculo en la base de datos
                    Conexion conexion = new Conexion();
                    conexion.GuardarCalculo(operacion, resultadoDecimal, operation);
                }

                result = Double.Parse(txtDisplay.Text);    // guarda el resultado para nuevas operaciones
                operation = string.Empty;         // limpia la operación
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
        private void btnShowResults_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnOtherOps_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            operation = but.Text;

            // Captura el valor actual en el display ANTES de realizar la operación
            string valorOriginal = txtDisplay.Text;
            decimal resultadoDecimal = 0;

            switch (operation)
            {
                case "√x":
                    txtDisplayProvi.Text = $"√({valorOriginal})";  // Mostrar en el display lo que estamos haciendo
                    txtDisplay.Text = Convert.ToString(Math.Sqrt(Double.Parse(valorOriginal))); // Realizar la operación
                    if (txtDisplay.Text == "NaN")
                    {
                        txtDisplay.Text = "No es posible";
                    }
                    else
                    {
                        resultadoDecimal = (decimal)Math.Sqrt(Double.Parse(valorOriginal)); // Guardar el resultado correcto
                    }
                    break;
                case "x²":
                    txtDisplayProvi.Text = $"({valorOriginal}^2)"; // Mostrar en el display lo que estamos haciendo
                    txtDisplay.Text = Convert.ToString(Convert.ToDouble(valorOriginal) * Convert.ToDouble(valorOriginal)); // Realizar la operación
                    resultadoDecimal = (decimal)(Convert.ToDouble(valorOriginal) * Convert.ToDouble(valorOriginal)); // Guardar el resultado correcto
                    break;
                case "sin":
                    txtDisplayProvi.Text = $"sin({valorOriginal})"; // Mostrar en el display lo que estamos haciendo
                    txtDisplay.Text = Convert.ToString(Math.Sin(Double.Parse(valorOriginal)));
                    resultadoDecimal = (decimal)Math.Sin(Double.Parse(valorOriginal)); // Guardar el resultado correcto
                    break;
                case "cos":
                    txtDisplayProvi.Text = $"cos({valorOriginal})"; // Mostrar en el display lo que estamos haciendo
                    txtDisplay.Text = Convert.ToString(Math.Cos(Double.Parse(valorOriginal)));
                    resultadoDecimal = (decimal)Math.Cos(Double.Parse(valorOriginal)); // Guardar el resultado correcto
                    break;
                case "neg":
                    if (valorOriginal != "0")
                    {
                        txtDisplay.Text = Convert.ToString(-1 * Convert.ToDouble(valorOriginal)); // Realizar la operación
                        resultadoDecimal = (decimal)(-1 * Convert.ToDouble(valorOriginal)); // Guardar el resultado correcto
                    }
                    break;
                default:
                    break;
            }

            if (txtDisplay.Text != "No es posible")
            {
                rtBoxHistory.AppendText($"{txtDisplayProvi.Text} = {txtDisplay.Text} \n");

                // Guardar el cálculo en la base de datos solo si la operación fue exitosa
                if (!string.IsNullOrEmpty(valorOriginal))
                {
                    Conexion conexion = new Conexion();
                    conexion.GuardarCalculo(txtDisplayProvi.Text, resultadoDecimal, operation); // Guardar la operación con el valor original
                }
            }
        }


    }
}
