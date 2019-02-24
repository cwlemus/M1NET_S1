using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S1EJ2
{
    using  programAtributos= M1NET_S1EJ1.Program;
    class Program
    {
        public  string VarPublico;
        public void PruebaAmbito()
        {
           programAtributos p = new programAtributos();
            VarPublico = p.APublico;
        }
    }

    class DemoAmbito:programAtributos
    {
        public string VarPublico;
        public string VarProtected;
        public string VarProtectedInternal;
        public void PruebaAmbito()
        {
            VarProtected = AProtected;
            VarPublico = APublico;
            VarProtectedInternal = APotectedInternal;
        }
    }
}
