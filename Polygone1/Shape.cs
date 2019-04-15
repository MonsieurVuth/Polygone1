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
            if ( this.inference.Para == "0" )
            {
                this.forme = " Triangle";
                if(this.inference.Angle == "1")
                {
                    forme += " rectangle";
                }
                else
                {
                    if(Int32.Parse(this.inference.Angle) > 1)
                    {
                        MessageBox.Show("Impossible d'avoir plus q'un angle droit");
                        return null;
                    }
                    if (this.inference.Longueur == "2")
                    {
                        this.forme = " Triangle";
                        forme += " isocèle";
                    }
                    else
                    {                   
                            int result = Int32.Parse(this.inference.Longueur);
                            if (result > Int32.Parse(this.inference.Cote))
                            {
                                MessageBox.Show("Impossible d'avoir plus de trois longueurs identiques");
                                return null;
                            }
                            else
                            {
                                if (this.inference.Longueur == "0" && this.inference.Angle == "0")
                                {
                                    forme += " quelconque";

                                }
                                else
                                {
                                    if(this.inference.Longueur == "3" && this.inference.Angle == "0")
                                    {
                                        forme += " equilatéral";
                                    }        
                                }        
                            }                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Erreur de paramètre");
                return null;
            }
            return forme;
        }
        public string FourSide()
        {
            string forme = String.Empty;
                if (inference.Longueur == "4" && inference.Para == "4" && inference.Angle == "4")
                {
                    forme += " Carré";
                }

                if (inference.Longueur == "2" && inference.Para == "4" && inference.Angle == "4")
                {
                    forme += " Rectange";
                }

                if (inference.Longueur == "4" && inference.Para == "4" && inference.Angle == "0")
                {
                    forme += " Losange";
                }
                if ( this.inference.Para == "2" && this.inference.Angle == "0")
                {
                    forme += " Trapèze";
                }
                else
                {
                if (this.inference.Para == "0")
                {
                    forme += "Quadrilatère quelconque";
                }
                }
                if (this.inference.Longueur == "4" && this.inference.Para == "4" && this.inference.Angle == "0")
                {
                    forme += " Parallèlogramme";
                }              
            return forme;
        }
    }
}



