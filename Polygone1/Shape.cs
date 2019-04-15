﻿using System;
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
            if ( this.inference.Para == "0"){
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
                                if (this.inference.Longueur == "0" && this.inference.Angle == "0")
                                {
                                    forme += " quelconque";

                                }
                                else
                                {
                                    if(this.inference.Longueur == "3")
                                    {
                                        forme += " equilatéral";
                                    }        
                                }        
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
                if (this.inference.Longueur == "2" && this.inference.Para == "2" && this.inference.Angle == "0")
                {
                    forme += " Trapèze";
                }
                if (this.inference.Longueur == "4" && this.inference.Para == "4" && this.inference.Angle == "0")
                {
                    forme += " Parallèlogramme";
                }
                if (this.inference.Para == "0")
                {
                forme += "Quadrilatère quelconque";
                }
            return forme;
        }
    }
}



