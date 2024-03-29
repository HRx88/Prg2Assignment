﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10262513_PRG2Assignment
{
    //==========================================================
    // Student Number : S10262513
    // Student Name : Tan Hong Rong
    // Partner Name : Jayden Toh Xuan Ming
    //==========================================================
    class Flavour
    {
        public string Type { get; set; }

        public bool Premium { get; set; }
        public int Quantity { get; set; }

        public Flavour()
        {
            
        }

        public Flavour(string t,bool p,int q=1)
        {
            Type = t;
            Premium = p;
            Quantity = q;
        }
        public override string ToString()
        {
            return "Type: "+Type+"\tPremium: "+Premium+"\tQuantity: "+Quantity;
        }
    }
}
