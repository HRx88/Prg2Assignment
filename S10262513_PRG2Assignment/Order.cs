﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace S10262513_PRG2Assignment
{
    //==========================================================
    // Student Number : S10262513
    // Student Name : Tan Hong Rong
    // Partner Name : Jayden Toh Xuan Ming
    //==========================================================
    class Order
    {

        public int Id { get; set; }

        public DateTime TimeReceived { get; set; }

        public DateTime ? TimeFulfilled { get; set; }

        public List<IceCream> IceCreamList { get; set; }= new List<IceCream>();

        
        public Order()
        {
            
        }

        public Order(int id,DateTime tr)
        {
            Id = id;
            TimeReceived = tr;
            
            
            
        }
        public void ModifyIceCream(int id)  // to be confirmed if it works or not
        {
           

            Console.WriteLine("[1]choose an existing ice cream object to modify");
            Console.WriteLine("[2] add an entirely new ice cream object to the order");
            Console.WriteLine("[3] choose an existing ice cream object to delete from the order");
            Console.WriteLine("Enter 'X' to end");
            Console.WriteLine("Enter your Choice: ");





        }

        public void AddIceCream(IceCream iceCream)
        {
            IceCreamList.Add(iceCream);
           
        }
        public void DeleteIceCream(int index)
        {
            if (index >= 0 && index < IceCreamList.Count)
            {
                IceCreamList.RemoveAt(index);
                
                Console.WriteLine($"Ice cream with index {index} successfully deleted.");
            }
            else
            {
                Console.WriteLine($"Invalid index: {index}. Please enter a valid index.");
            }
        }
        public double CalculateTotal() 
        {
            double total = 0;
            for (int i = 0; i < IceCreamList.Count; i++)
            {
                IceCream iceCream = IceCreamList[i];
                if(iceCream is Cup)
                {
                    Cup cp = (Cup)iceCream;
                    total += cp.CalculatePrice();
                }
                else if(iceCream is Cone)
                {
                    Cone ce = (Cone)iceCream;
                    total += ce.CalculatePrice();
                }
                else if (iceCream is Waffle)
                {
                    Waffle w= (Waffle)iceCream;
                    total += w.CalculatePrice();
                }
            }
            return total;
        }

        public override string ToString() 
        {
            return "Id: "+Id+ "\tTimeReceived: "+TimeReceived+ "\tTimeFulfilled: "+TimeFulfilled;
        }
    }
}
