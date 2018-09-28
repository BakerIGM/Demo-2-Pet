using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Pet
    {
        protected string name;
        protected string furColor;
        protected string foodType;
        protected string breed;

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public String FurColor
        {
            get
            {
                return furColor;
            }
            set
            {
                furColor = value;
            }
        }

        public String FoodType
        {
            get
            {
                return foodType;
            }
            set
            {
                foodType = value;
            }
        }

        public String Breed
        {
            get
            {
                return breed;
            }
            set
            {
                breed = value;
            }
        }

        public Pet()
        {
            name = "Animal";
            furColor = "None";
            foodType = "ANything";
            breed = "None";
        }

        public Pet(string p_name, string color, string food, string p_breed)
        {
            name = p_name;
            furColor = color;
            foodType = food;
            breed = p_breed;
        }

        public void Print()
        {
            Console.WriteLine("Name: {0}\nColor: {1}\nFood: {2}\nBreed: {3}", name, furColor, foodType, breed);
        }

        public void LevelOfCare()
        {
            //  do something
        }
    }
}
