using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S1EJ1
{
    public class Program
    {
        public string APublico = "Ambito publico";
        private string APrivate = "Ambito privado";
        protected internal string APotectedInternal = "Ambito con herencia y en todo el proyecto";
        internal string AInternal = "Ambito interno";
        protected string AProtected = "Ambito protected";
        static void Main(string[] args)
        {
          
        }
    }
}

namespace M1NET_S1EJ2
{
    using M1NET_S1EJ1;

    class DemoAmbito2
    {
        //variables a las cuales podemos acceder
        internal string VarInternal;
        public string VarPublic;
        public void PruebaAmbito()
        {
            Program prog = new Program();
            VarInternal = prog.AInternal;
            VarPublic = prog.APublico;
            
        }
    }

    class DemoAmbito1:Program
    {
        //variables a las cuales podemos acceder
        internal string VarInternal;
        public string VarPublic;
        protected string VarProtected;
        public void PruebaAmbito()
        {
            VarInternal = AInternal;
            VarPublic = APublico;
            VarProtected = AProtected;
           
        }
    }
}



