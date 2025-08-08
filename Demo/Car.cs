using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Car
    {
        #region Attributes

        private int id;

        private string? model;

        private int speed;






        #endregion

        #region Properties

         public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string? Model
        {
            get { return model; }
            set { model = value; }
        }   
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }



        #endregion


        #region Constructor


        // N longer overloaading the constructor    (Constructor OverLoading)
        public Car(int id, string? model, int speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;

            Console.WriteLine("Constructor 1.");

        }

        public Car(int id, string? model) : this(id ,model , 190) //constructor chain (Call constructore from anthor constructor)
        {
            //this.id = id;
            //this.model = model;
            //this.speed = 190;
            Console.WriteLine("Constructor 2.");

        }

        public Car(int id) : this (id , "tota" , 250)
        {
            //this.id = id;
            //this.model = "tota";
            //this.speed = 250;

            Console.WriteLine("Constructor 3.");    
        }



        #endregion
        #region Fuction

        public override string ToString()
        {
            return $"Car ID: {id}, Model: {model}, Speed: {speed} km/h";    
        }

        #endregion




    }
}
