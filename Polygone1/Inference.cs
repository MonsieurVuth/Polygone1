﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Polygone1
{
    class Inference
    {
        private string cote;
        private string angle;
        private string para;
        private string longueur;

        public Inference(string side, string angle, string para, string longe)
        {
            this.Cote = side;
            this.Angle = angle;
            this.Para = para;
            this.Longueur = longe;
        }

        public string Cote { get => cote; set => cote = value; }        public string Para { get => para; set => para = value; }

        public string Angle { get => angle; set => angle = value; }
        public string Longueur { get => longueur; set => longueur = value; }

        public void CheckRegles()
        {
            Shape forme = new Shape(this);
            BaseFait labase = new BaseFait(this);
            if(this.cote == "3")
            {
                if(labase.getShape() == string.Empty)
                {
                    if(forme.Triangle() != null)
                    {
                        labase.AddShape(forme.Triangle());
                    }
                    else
                    {
                        MessageBox.Show("Forme inconnue");
                    }
                }
                else
                {
                    MessageBox.Show(labase.getShape());
                }
            }

            if(this.cote == "4")
            {
                if(labase.getShape() == string.Empty)
                {
                    if(forme.FourSide() != null)
                    {
                        labase.AddShape(forme.FourSide());
                    }
                    else
                    {
                        MessageBox.Show("Forme inconnue");
                    }         
                }
                else
                {
                    MessageBox.Show("La base de fait relève la forme : "+ labase.getShape());
                }
            }


            if(this.cote == "5")
            {
                if(labase.getShape() == string.Empty)
                {
                    if(forme.Pentagone() != null)
                    {
                        labase.AddShape(forme.Pentagone());
                    }
                    else
                    {
                        MessageBox.Show("Forme inconnue");
                    }
                }
                else
                {
                    MessageBox.Show("La base de fait relève la forme : " + labase.getShape());
                }
            }
        }

        public void EmptyBase()
        {
            BaseFait labase = new BaseFait(this);
            labase.DeleteBase();
        }
    }

}
