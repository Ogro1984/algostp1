using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_Recursivos
{
    public partial class Form1 : Form
    {
        int resultadog { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        // se necesita predecir el numero de personas que utilizaran el tren anualmente. tomando en cuenta los siguientes escenarios
        // 1 suponiendo que cada vagon transporta un promedio de 20x pasajeros en hora pico de mañana, 10x pasajeros en hora intermedia por la tarde y x pasajeros en horario nocturno...
        // 2 la cantidad x de pasajeros depende por cuestiones sociales (cuando un pasajero twitea que el metro esta vacio mucha gente aprovecha y viaja en tren) de la cantidad inicial de pasajeros que viajen en la primera noche del año.
        // 3 ademas la cantidad de pasajeros varia con un factor igual al termino de la serie de fibonacci que corresponde al mes del año en curso (enero es igual al termino 2 de fibonacci febrero al 3 y asi sucesivamente)
        // 4 los dias de la semana que son feriados la cantidad de pasajeros disminuye a la mitad) 

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var pasajeros_iniciales = Int32.Parse(textBox1.Text);

                this.resultadog = 0;

               Calculo_pasajeros(pasajeros_iniciales);

                textBox2.Text = this.resultadog.ToString();
            }
            catch
            {
                MessageBox.Show("numero ingresado incorrecto");

            }
        }

       

        public int  Calculo_pasajeros(int pini, int mes = 12, int semana_del_mes=4,int dia_de_la_semana=7, int momento_del_dia = 3) {



           while (mes > 1 ) {
                {
                    while (semana_del_mes != 0)
                    {
                        while (dia_de_la_semana != 0)
                        {

                            if (dia_de_la_semana == 1 || dia_de_la_semana == 7)
                            {

                                while (momento_del_dia != 0)
                                {
                                    switch (momento_del_dia)
                                    {
                                        case 1:
                                            {
                                                resultadog = resultadog + pini * 10;



                                                break;

                                            }

                                        case 2:
                                            {
                                                resultadog = resultadog + pini * 5;
                                                break;

                                            }
                                        case 3:
                                            {
                                                resultadog = resultadog + pini / 2;
                                                break;

                                            }


                                    }
                                    Calculo_pasajeros(pini, mes, semana_del_mes, dia_de_la_semana, momento_del_dia - 1);
                                }


                            }
                            else
                            {
                                while (momento_del_dia != 0)
                                {
                                    switch (momento_del_dia)
                                    {
                                        case 1:
                                            {
                                                resultadog = resultadog + pini * 20;



                                                break;

                                            }

                                        case 2:
                                            {
                                                resultadog = resultadog + pini * 10;
                                                break;

                                            }
                                        case 3:
                                            {
                                                resultadog = resultadog + pini;
                                                break;

                                            }


                                    }
                                    Calculo_pasajeros(pini, mes, semana_del_mes, dia_de_la_semana, momento_del_dia - 1);
                                }
                            }

                            Calculo_pasajeros(pini, mes, semana_del_mes, dia_de_la_semana - 1);
                        }
                        semana_del_mes = semana_del_mes - 1;
                        Calculo_pasajeros(pini, mes, semana_del_mes);

                    }


                    if (mes == 1) { break; }
                    mes = mes - 1;
                    Calculo_pasajeros(pini, mes);

                }
               
            }

            return 0;
       }
    }

           
        }
    

