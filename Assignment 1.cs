using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Address
    {
        public string street;
        public string city;
        public string zipcode;
        public Address(string valuename, string valueName, string ValuenAme)
        {
            street = valuename;
            city = valueName;
            zipcode = ValuenAme;
        }
    }
    class TShirt
    {
        public string size;
        public string color;
        public float price;
        public TShirt(string valuename, string valueColor, float valueid)
        {
            size = valuename;
            color = valueColor;
            price = valueid;
        }
    }
    class User
    {
        public string name;
        public string email;
        public int Q;
        private ShoppingCart ShoppingCart;
        public User(string valuename,string valueemail,int Quan)
        {
            name = valuename;
            email = valueemail;
            Q = Quan;
        }
        
    }
    class ShoppingCart
    {
        public string name;
        public float totalprice =0;
        private List<TShirt> orderTShirt;
        private List<Address> address;
        public ShoppingCart()
        {
            orderTShirt = new List<TShirt>();
            address = new List<Address>();
        }
        public void addList(Address aDdress)
        {
            address.Add(aDdress);
        }
        public void addList(TShirt tShirt)
        {
            orderTShirt.Add(tShirt);
        }
        public void getorder()
        {
            foreach (TShirt tShirt in orderTShirt)
            {
                Console.WriteLine(" Size : {0}",tShirt.size);
                Console.WriteLine(" Color : {0}", tShirt.color);
                Console.WriteLine(" Price : {0}", tShirt.price);
            }
        }
        public void Totalprices()
        {
            foreach (TShirt tShirt in orderTShirt)
            {
                totalprice += tShirt.price;
            }
            Console.WriteLine(" Total price : {0}",totalprice);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User jame = new User("Jame Watson", "jame@gmail.com",3);
            ShoppingCart Totalcost = new ShoppingCart();
            TShirt one = new TShirt(" L", "Red", 500);
            TShirt two = new TShirt(" M", "Black", 750);
            TShirt three = new TShirt(" S", "Black", 625);
            Address James = new Address(" 131/75", " Phutthamonthon road ,Nakhon Pathom", " 10180");

            Totalcost.addList(one);
            Totalcost.addList(two);
            Totalcost.addList(three);

            Console.WriteLine(" Name: {0} ", jame.name);
            Console.WriteLine(" Email : {0} ", jame.email);
            Console.Write(James.street);
            Console.Write(James.city);
            Console.Write(James.zipcode);
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------");
            Totalcost.getorder();
            Console.WriteLine("-------------------------------------------------");
            Totalcost.Totalprices();
            //Console.WriteLine(" Total cost : {0}",one.price + two.price + three.price);
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
