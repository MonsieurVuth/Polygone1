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
                MessageBox.Show("Impossible d'avoir des cotés parralèle");
                return null;
            }
            return forme;
        }
        public string FourSide()
        {

                    if (inference.Para == "4" && inference.Angle == "4")
                    {
                        if (this.inference.Longueur == "4")
                        {
                            forme = " Carré";
                        }
                        else
                        {
                            if (inference.Longueur == "2")
                            {
                                forme = " Rectange";
                            }
                        }

                    }
                    else
                    {
                        if (this.inference.Angle == "0")
                        {
                            forme = " Quadrilatère quelconque";
                            if (this.inference.Longueur == "4" && this.inference.Para == "4")
                            {
                                forme = " Parallèlogramme";
                            }
                            if (this.inference.Para == "2")
                            {
                                forme = " Trapèze";
                            }
                            if (inference.Longueur == "4" && inference.Para == "4")
                            {
                                forme = " Losange";
                            }
                        }
                    }            
            return forme;
        }
        public String Pentagone()
        {
            if(this.inference.Angle == "2" || this.inference.Angle == "0")
            {
                if(this.inference.Para == "2" || this.inference.Para == "0")
                {
                    this.forme = " Pentagone";
                }
            }
            return this.forme;
        }
    }
}



