using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceChallengeSolution
{
    interface IGenerateRandomNumber
    {
        int RandomNumber { get; set; }

        void GenerateRandomNumber();
        int ReturnRandomNumber();
        


    }
}
