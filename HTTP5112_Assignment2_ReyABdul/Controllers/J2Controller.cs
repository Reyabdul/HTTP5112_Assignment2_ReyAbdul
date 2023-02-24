using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assignment2_ReyABdul.Controllers
{



    public class J2Controller : ApiController
    {
        //Process into solving proble:
        //1. Declare variables for M and N to represent the total side for each of the two dices
        //2. Get values from M and N so that it equals to 10
        //3. Return total combination for both dices to equate to 10.


        /// <summary>
        /// Diana plays a game with two dice which have m sides and n sides.
        /// She is going to add numbers of each side to make the sum 10.
        /// This code determines how many ways Diana can roll the value of 10.
        /// </summary>
        /// <param name="m">How many sides of dice m</param>
        /// <param name="n">How many sides of dice n</param>
        /// <example> Get api/J2/DiceGame/6/8 -> There are 5 total ways to get the sum 10</example>
        /// <example> Get api/J2/DiceGame/12/4 -> There are 4 total ways to get the sum 10</example>
        /// <example> Get api/J2/DiceGame/3/3 -> There are 0 total ways to get the sum 10</example>
        /// <example> Get api/J2/DiceGame/5/5 -> There are 1 total ways to get the sum 10</example>
        /// <returns>The number of ways Diana can roll the value of 10.</returns>
        /// 

        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceRoll(int m, int n)
        {
            //List of variables
            string numSideM = "";
            string numSideN = "";
            int combination = m + n;
            int sum = 10;

            //Looping through dice 'm'
            for (int i = 0; i < m; i++)
            {
                //Looping though dice 'n'
                for (int j = 0; j < n; j++)
                {
                    //check which 'combination' is equal to sum, then add the '.Lenth' to 'i' or 'j' to find total ways 
                    if (combination == sum)
                    {
                        numSideM = numSideM + i.ToString() + ",";
                        numSideN = numSideN + j.ToString() + ",";
                    }
                }
            }
            return $"There are {m} total ways to get the sum {sum} ";
        } 





        
   
    }
}
