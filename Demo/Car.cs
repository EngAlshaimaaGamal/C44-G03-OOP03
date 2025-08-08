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
        public Car(int id, string? model, int speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;
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
