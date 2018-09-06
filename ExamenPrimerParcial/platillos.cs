using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class platillos
    {

        public string identificadorPlatillos { get; set; }
        public string nombrePlatillo { get; set;}
        public string descripcionPlatillo { get; set; }
        public float precioPlatillo { get; set; }

        public List<platillos> Platillos;

        platillos()
        {
            if (precioPlatillo < 50.00)
            {
                precioPlatillo = 50;

            }

        }






    }
}
