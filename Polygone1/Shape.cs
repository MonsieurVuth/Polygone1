using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Polygone1
{
    class Shape
    {
        Inference inference;
        public Shape(Inference inf)
        {
            this.inference = inf;
        }

        public void TriangleQuelconque()
        {
            if (inference.Para == "0" && inference.Angle == "0" && inference.Cote == "3" && inference.Longueur == "2" )
            {
                MessageBox.Show("ceci est un triangle quelconque");
            }
         }
 }

    }

