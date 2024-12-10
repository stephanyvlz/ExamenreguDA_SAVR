
using Examen2_DA_savr.VM;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Input;
using Xamarin.Forms;

namespace Examen2_DA_savr.VM
{
    public class VMpatron : BaseViewModel
    {
        #region VARIABLES
        double _latidos;
        double _frecuCardiaca;
        string _resultado;

        #endregion
        #region CONSTRUCTOR
        public VMpatron(INavigation navigation)
        {
            Navigation = navigation;
            CommandCalculo = new Command(Calculo);
        }

        #endregion
        #region OBJETOS
        public double latidos
        {
            get { return _latidos; }
            set { SetValue(ref _latidos, value); }
        }
        public double frecuCardiaca
        {
            get { return _frecuCardiaca; }
            set { SetValue(ref _frecuCardiaca, value); }
        }

        public string resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }

        #endregion

        #region PROCESOS
        public void Calculo()
        {
            
            double latidos = _latidos;
            double frecuCardiaca = _frecuCardiaca;
            frecuCardiaca = latidos * 4;

                if (frecuCardiaca < 60)
                {
                    resultado = $"{frecuCardiaca} es frecuencia cardiaca baja.";
                }
                else if (frecuCardiaca > 100)
                {
                    resultado = $"{frecuCardiaca} es frecuencia cardiaca alta.";
                }
                else if (frecuCardiaca > 60 || frecuCardiaca < 100)
                {
                    resultado = $"{frecuCardiaca} es frecuencia cardiaca normal.";
                }
            


        }

        #endregion
        #region COMANDOS
        public ICommand CommandCalculo { get; }
        #endregion
    }
}

