using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreKonsoliTestiDemo
{
    public class Laskuri
    {
        public double kerro(string kaava)
        {
            double eka = double.Parse(kaava.Split("*")[0]);
            double toka = double.Parse(kaava.Split("*")[1]);
            return (eka * toka);
        }
    }
}
