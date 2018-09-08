using System;

namespace InterfaceChallengeSolution
{
    internal class randomNumberGenerator : IGenerateRandomNumber
    {
        private int minValue = 1;
        private int maxValue = 100;
        public int RandomNumber { get; set; }

        public randomNumberGenerator()
        {
            GenerateRandomNumber();
        }
        public void GenerateRandomNumber()
        {
            
            Random rndNumber = new Random();
            this.RandomNumber = rndNumber.Next(minValue, maxValue);

        }

        public int ReturnRandomNumber()
        {
            return RandomNumber;
        }
    }
}