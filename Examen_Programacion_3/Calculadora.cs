using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Programacion_3
{
    public partial class Calculadora : Form
    {
        private int tipo_ope = 0;
        private double primer_num = 0;
        private double segundo_num = 0;

        public Calculadora()
        {
            InitializeComponent();
        }


        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Clear();
        }

        private void btn_uno_Click(object sender, EventArgs e)
        {
            if (tipo_ope == -1) {
                txtPantalla.Clear();
                tipo_ope = 0;
            }
              
            txtPantalla.Text += "1";

        }

        private void btn_dos_Click(object sender, EventArgs e)
        {
            if (tipo_ope == -1)
            {
                txtPantalla.Clear();
                tipo_ope = 0;
            }
            txtPantalla.Text += "2";
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            if (tipo_ope == -1)
            {
                txtPantalla.Clear();
                tipo_ope = 0;
            }
            txtPantalla.Text += "3";
        }

        private void btn_cuatro_Click(object sender, EventArgs e)
        {
            if (tipo_ope == -1)
            {
                txtPantalla.Clear();
                tipo_ope = 0;
            }
            txtPantalla.Text += "4";
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            if (tipo_ope == -1)
            {
                txtPantalla.Clear();
                tipo_ope = 0;
            }
            txtPantalla.Text += "5";
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            if (tipo_ope == -1)
            {
                txtPantalla.Clear();
                tipo_ope = 0;
            }
            txtPantalla.Text += "6";
        }

        private void btn_siete_Click(object sender, EventArgs e)
        {
            if (tipo_ope == -1)
            {
                txtPantalla.Clear();
                tipo_ope = 0;
            }
            txtPantalla.Text += "7";
        }

        private void btn_ocho_Click(object sender, EventArgs e)
        {
            if (tipo_ope == -1)
            {
                txtPantalla.Clear();
                tipo_ope = 0;
            }
            txtPantalla.Text += "8";
        }

        private void btn_nueve_Click(object sender, EventArgs e)
        {
            if (tipo_ope == -1)
            {
                txtPantalla.Clear();
                tipo_ope = 0;
            }
            txtPantalla.Text += "9";
        }

        private void btn_cero_Click(object sender, EventArgs e)
        {
            if (tipo_ope == -1)
            {
                txtPantalla.Clear();
                tipo_ope = 0;
            }
            txtPantalla.Text += "0";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
       
            try
            {
                if (!txtPantalla.Text.Equals(""))
                {
                    double resultado = 0;
                    segundo_num = double.Parse(this.txtPantalla.Text);
                    switch (tipo_ope)
                    {
                        case 1:
                            resultado = primer_num + segundo_num;
                            this.txtPantalla.Text = resultado.ToString();
                            break;
                        case 2:
                            resultado = primer_num - segundo_num;
                            this.txtPantalla.Text = resultado.ToString();
                            break;
                        case 3:
                            resultado = primer_num * segundo_num;
                            this.txtPantalla.Text = resultado.ToString();
                            break;
                        case 4:
                            if (segundo_num != 0)
                            {
                                resultado = primer_num / segundo_num;
                                this.txtPantalla.Text = resultado.ToString();
                            }else
                            {
                                this.txtPantalla.Text = "¡ERROR!, DIVISIÓN ENTRE 0";
                            }
                            break;
                        default:
                            this.txtPantalla.Text = "¡ERROR EN OPERACIÓN!";
                            break;
                    }
                    
                    //tipo_ope = -1;

                }
                else
                {
                    Console.Write("Faltan operadores\n");
                }

            }catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPantalla.Text.Equals(""))
                {
                    primer_num = double.Parse(txtPantalla.Text);
                    tipo_ope = 1; //identificador de la suma
                    txtPantalla.Clear();

                }
                else
                {
                    Console.Write("Campo vacio\n");
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPantalla.Text.Equals(""))
                {
                    primer_num = double.Parse(txtPantalla.Text);
                    tipo_ope = 2; //identificador de la resta
                    txtPantalla.Clear();

                }
                else
                {
                    Console.Write("Campo vacio\n");
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPantalla.Text.Equals(""))
                {
                    primer_num = double.Parse(txtPantalla.Text);
                    tipo_ope = 3; //identificador de la multiplicación
                    txtPantalla.Clear();

                }
                else
                {
                    Console.Write("Campo vacio\n");
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPantalla.Text.Equals(""))
                {
                    primer_num = double.Parse(txtPantalla.Text);
                    tipo_ope = 4; //identificador de la división
                    txtPantalla.Clear();

                }
                else
                {
                    Console.Write("Campo vacio\n");
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
