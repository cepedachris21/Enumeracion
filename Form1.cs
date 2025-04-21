using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploEnumeracion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);

            ConfigurarInterfaz();

            // Cargar enum en ComboBox 
            cmbEstado.DataSource = Enum.GetValues(typeof(EstadoPedido));
        }
        private void ConfigurarInterfaz()
        {
            // Configuración básica del formulario
            this.Text = "Seguimiento de Pedidos";
            this.ClientSize = new Size(400, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            // ComboBox
        
            cmbEstado.Location = new Point(50, 50);
            cmbEstado.Size = new Size(300, 30);
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            //this.Controls.Add(cmbEstado);

            // Botón
          
            btnMostrar.Text = "Mostrar";
            btnMostrar.Location = new Point(150, 100);
            btnMostrar.Size = new Size(100, 40);
            btnMostrar.Click += btnMostrar_Click;
            //this.Controls.Add(btnMostrar);

            // Label
            
           
            lblResultado.Location = new Point(50, 160);
            lblResultado.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblResultado.Size = new Size(300, 30);
            //this.Controls.Add(lblResultado);
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Obtener valor seleccionado del ComboBox 
            EstadoPedido estadoSeleccionado = (EstadoPedido)cmbEstado.SelectedItem;


            switch (estadoSeleccionado)
            {
                case EstadoPedido.Pendiente:
                    lblResultado.Text = "⏳ Tu pedido está pendiente de procesamiento.";
                    lblResultado.ForeColor = Color.Orange;
                    break;

                case EstadoPedido.Procesando:
                    lblResultado.Text = "🔍 Estamos verificando tu pedido.";
                    lblResultado.ForeColor = Color.Blue;
                    break;

                case EstadoPedido.Enviado:
                    lblResultado.Text = "🚚 Pedido enviado! N° de seguimiento: ABC-123";
                    lblResultado.ForeColor = Color.DarkBlue;
                    break;

                case EstadoPedido.Entregado:
                    lblResultado.Text = "✅ Pedido entregado satisfactoriamente.";
                    lblResultado.ForeColor = Color.Green;
                    break;

                case EstadoPedido.Cancelado:
                    lblResultado.Text = "❌ Pedido cancelado. Contacta a soporte.";
                    lblResultado.ForeColor = Color.Red;
                    break;

                default:
                    lblResultado.Text = "Estado no reconocido";
                    lblResultado.ForeColor = Color.Gray;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {

        }
    }
}