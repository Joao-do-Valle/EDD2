using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Filas_Atendimento
{
    internal class Guiches
    {
        private List<Guiche> listaGuiches;
        internal List<Guiche> ListaGuiches { get => listaGuiches; set => listaGuiches = value; }
        public Guiches()
        {
            ListaGuiches = new List<Guiche>();
        }
        public void adicionar(Guiche guiche)
        {
            ListaGuiches.Add(guiche);
        }
    }
}
