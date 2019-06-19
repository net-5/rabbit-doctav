using System;
using System.Collections.Generic;
using System.Text;

namespace AppRabbitDoctav
{
    //https://github.com/net-5/rabbit-doctav
    //Model the Rabbit class knowing that:
    //a rabbit can have Blue, Red or Black eyes
    //a rabbit's fur can be white, brown, black or grey
    //it has a gender
    //has a birth date, and based on that you should be able to see how old the rabbit is
    //we also know that a rabbit is a mammal that moves, sleeps and eats
    enum EYES { Blue = 0, Red = 1, Black = 2 };
    enum FUR { White, Brown, Black, Grey };
    enum GENDER { Male, Female };
    class Rabbit
    {

        private EYES eyes;
        private FUR fur;
        private GENDER gender;
        private DateTime birthDate;

        //some fields
        private int numberOfSteps = 0;
        private int numberOfSleepingHours = 0;
        private int numberOfEatenPlates = 0;

        //constructors
        public Rabbit() { }
        public Rabbit(EYES eyes, FUR fur, GENDER gender, DateTime birthDate)
        {
            this.Eyes = eyes;
            this.Fur = fur;
            this.Gender = gender;
            this.BirthDate = birthDate;
        }
        //properties
        public EYES Eyes
        {
            get { return this.eyes; }
            set { this.eyes = value; }
        }

        public FUR Fur
        {
            get { return this.fur; }
            set { this.fur = value; }
        }

        public GENDER Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public DateTime BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }

        public string GetAgeOfTheRabbit
        {
            get
            {
                DateTime currentDate = DateTime.Today;
                //calculate the age
                int age = currentDate.Year - BirthDate.Year;

                if (currentDate.Month < BirthDate.Month || (currentDate.Month == BirthDate.Month && currentDate.Day < BirthDate.Day))
                {
                    age--;
                }
                return ($"Age of the rabbit = {age} years.");
            }
        }

        //some methods
        public void Move(int steps)
        {
            this.numberOfSteps += steps;
        }

        public void Eat(int plates)
        {
            this.numberOfEatenPlates += plates;
        }

        public void Sleep(int hours)
        {
            this.numberOfSleepingHours += hours;
        }

        //a dynamic property to get detailed information about the current rabbit
        public string DetailedInfo
        {
            get { return $"The rabbit slept {this.numberOfSleepingHours} hours, moved {this.numberOfSteps} steps and ate {this.numberOfEatenPlates} plates of food."; }
        }

    }
}
