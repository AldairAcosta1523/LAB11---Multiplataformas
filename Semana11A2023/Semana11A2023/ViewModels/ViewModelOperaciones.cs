using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Semana11A2023.ViewModels
{
    public class ViewModelOperaciones : ViewModelBase 
    {

        double valorA;
        public double ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }


        double valorB;
        public double ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }


        double resultadoResta;
        public double ResultadoResta
        {
            get { return resultadoResta; }
            set
            {
                if (resultadoResta != value)
                {
                    resultadoResta = value;
                    OnPropertyChanged();
                }
            }
        }
        double resultadoSuma;
        public double ResultadoSuma
        {
            get { return resultadoSuma; }
            set
            {
                if (resultadoSuma != value)
                {
                    resultadoSuma = value;
                    OnPropertyChanged();
                }
            }
        }
        double resultadoMultplicacion;
        public double ResultadoMultiplicar
        {
            get { return resultadoMultplicacion; }
            set
            {
                if (resultadoMultplicacion != value)
                {
                    resultadoMultplicacion = value;
                    OnPropertyChanged();
                }
            }
        }
        double resultadoDividir;
        public double ResultadoDividir
        {
            get { return resultadoDividir; }
            set
            {
                if (resultadoDividir != value)
                {
                    resultadoDividir = value;
                    OnPropertyChanged();
                }
            }
        }
        private string mensajeError;
        public string MensajeError
        {
            get { return mensajeError; }
            set
            {
                mensajeError = value;
                OnPropertyChanged(nameof(MensajeError));
            }
        }
        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Multiplicar { protected set; get; }
        public ICommand Dividir { protected set; get; }



        public ViewModelOperaciones()
        {
            Restar = new Command(() =>
            {
                ResultadoResta = ValorA - ValorB;
            });
            Sumar = new Command(() =>
            {
                ResultadoSuma = ValorA + ValorB;
            });
            Multiplicar = new Command(() =>
            {
                ResultadoMultiplicar = ValorA * ValorB;
            });
            Dividir = new Command(() =>
            {
                if (ValorB != 0 && ValorA != 0)
                {
                    ResultadoDividir = ValorA / ValorB;
                    MensajeError = string.Empty; ;
                }
                else
                {
                    MensajeError = "Error: No se puede dividir entre cero.";
                }
            })
            {

            };
        }
    }
}
