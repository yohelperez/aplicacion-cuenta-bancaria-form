using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_8
{
    public partial class Form1 : Form
    {
        
        Cuenta cuenta = new Cuenta();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saldoLabel_Click(object sender, EventArgs e)
        {

        }

        private void saldoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void consultarButton_Click(object sender, EventArgs e)
        {
            nombreTextBox.Text = cuenta.Name;
            idTextBox.Text = cuenta.ID;
            saldoTextBox.Text = cuenta.Saldo.ToString();
 
            depositoTextBox.Clear();
            retiroTextBox.Clear();
        }

        private void nDepositosLabel_Click(object sender, EventArgs e)
        {

        }

        private void nDepositosLabel1_Click(object sender, EventArgs e)
        {

        }

        private void nRetirosLabel_Click(object sender, EventArgs e)
        {

        }

        private void nRetirosLabel1_Click(object sender, EventArgs e)
        {

        }

        private void operacionesLabel_Click(object sender, EventArgs e)
        {

        }

        private void vDepositoLabel_Click(object sender, EventArgs e)
        {

        }

        private void depositoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void depositarButton_Click(object sender, EventArgs e)
        {
            cuenta.Depositar = double.Parse(depositoTextBox.Text);

            string msj = "Transacción realizada correctamente";
            string caption = "Result";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(msj, caption, button);

            int contador = int.Parse(nDepositosLabel1.Text) + 1;
            nDepositosLabel1.Text = contador.ToString();

            saldoTextBox.Clear();
            retiroTextBox.Clear();    
        }

        private void vRetiroLabel_Click(object sender, EventArgs e)
        {

        }

        private void retiroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void retirarButton_Click(object sender, EventArgs e)
        {
            if(cuenta.Saldo >= double.Parse(retiroTextBox.Text))
            {
                cuenta.Retirar = double.Parse(retiroTextBox.Text);  //realiza el cambio en la cuenta

                string msj = "Transacción realizada correctamente"; //mensaje que va a tener el MessageBox
                string caption = "Result";                          //encabezado del MessageBox     
                MessageBoxButtons button = MessageBoxButtons.OK;    //tipo de MessageBox (botones que tendrá)
                MessageBox.Show(msj, caption, button);

                int contador = int.Parse(nRetirosLabel1.Text) + 1;
                nRetirosLabel1.Text = contador.ToString();

            }
            else
            {
                string msj = "Saldo insuficiente";                  //mensaje que va a tener el MessageBox
                string caption = "Error Detected in Input";         //encabezado del MessageBox     
                MessageBoxButtons button = MessageBoxButtons.OK;    //tipo de MessageBox (botones que tendrá)
                MessageBox.Show(msj, caption, button);
                retiroTextBox.Clear();
            }

            saldoTextBox.Clear();
            depositoTextBox.Clear();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            string msj = "Cuenta creada correctamente";
            string caption = "Result";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(msj, caption, button);
            cuenta.Name = nombreTextBox.Text;
            cuenta.ID = idTextBox.Text;

            if(saldoTextBox.Text != "")
            {
                cuenta.Saldo = double.Parse(saldoTextBox.Text);
            }
            
            saldoTextBox.Clear();
            depositoTextBox.Clear();
            retiroTextBox.Clear();
        }
    }
}
