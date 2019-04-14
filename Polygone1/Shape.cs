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
        String forme;
        public Shape(Inference inf)
        {
            this.inference = inf;
        }

        public String Triangle()
        {
            if (this.inference.Cote == "3" && this.inference.Para == "0"){
                this.forme = "Triangle";
                if(this.inference.Angle == "1")
                {
                    forme += " rectangle";
                }
                else
                {
                    if (this.inference.Longueur == "2")
                    {
                        this.forme = " Triangle";
                        forme += " isocèle";
                    }
                    else
                    {
                        try
                        {
                            int result = Int32.Parse(this.inference.Longueur);
                            if (result > 3)
                            {
                                MessageBox.Show("Forme introuvable, vérifiez les paramètres");
                                return null;
                            }
                            else
                            {
                                forme += " equilatéral";
                            }                        
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Problème de parse");
                        }
                    }
                }
            }
            return forme;
        }
        public string FourSide()
        {
            string forme = String.Empty;
            return forme;
        }
    }
}



