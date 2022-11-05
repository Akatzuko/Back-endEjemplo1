using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back_endEjemplo1.Models
{
    public class Garaje:List<Coche>
    {
        public Garaje()
        {
            this.Add(new Coche(1, "Tesla", "Roadster", "Domingo Garcia"));
            this.Add(new Coche(2, "Toyota", "Yaris", "Juan Antonio Leon"));
            this.Add(new Coche(3, "Honda", "Civic", "Carlos Reynoso"));
            this.Add(new Coche(4, "Nissan", "Tsuru", "Arturo Sanchez"));



        }
    }
}