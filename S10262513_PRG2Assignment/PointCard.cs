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
    class PointCard
    {

        public int Points { get; set; }

        public int PunchCard { get; set; }

        public string Tier { get; set; }

        public PointCard()
        {
            
        }

        public PointCard(int ps,int pc)
        {
            Points = ps;
            PunchCard = pc;
        }

        public void AddPoints(int amt)
        {
            
            Points =Convert.ToInt32(Math.Floor(amt * 0.72));
            
            if (Points >= 100 && Tier== "Silver")
            {
                Tier = "Gold";
            }
            else if (Points >= 50 && Tier== "Ordinary")
            {
                Tier = "Silver";
            }
            else
            {// can jump over 1 tier?
                Tier = "Ordinary";
            }
        }

        public void RedeemPoints(int ps) 
        {
            if (Points>=ps)
            {
                Points -= ps;
            }
            else
            {
                Console.WriteLine("Not enough points");
            }
        }

        public void Punch() 
        {
            PunchCard+= 1;
            if(PunchCard>10)
            {
                PunchCard=0;
                Console.WriteLine("yay! free iceCream");
            }
            
        }

        public override string ToString()
        {
            return "Points: "+Points+"\tPunchCard: "+PunchCard+"\tTier: "+Tier;
        }

    }
}
