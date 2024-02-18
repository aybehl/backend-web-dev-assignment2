using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace backend_web_dev_assignment2.Controllers
{

    public class J2Controller : ApiController
    {
        ///<link>https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2006/stage1/juniorEn.pdf</link>
		///<problem-type>J2</problem-type>
        ///<problem-name>Roll the dice</problem-name>
        ///<summary>
        ///Method takes two input parameters a. # of Sides on Dice 1 b. # of Sides on Dice 2 and return a string containing the # of ways to roll 10 with the two dices
        ///</summary>
        ///<param name="sidesOnDice1">An integer input</param>
		///<param name="sidesOnDice2">An integer input</param>
        ///<example>
        ///GET /api/J2/waysToRollTen/6/8 -> "There are 5 ways to get the sum 10"
        ///</example>
        ///<example>
        ///GET /api/J1/leftOverCupcakes/12/4 -> "There are 4 ways to get the sum 10"
        ///</example>
        ///<returns>The program prints out the number of ways 10 may be rolled on these two dice</returns>
        [Route("api/J2/waysToRollTen/{sidesOnDice1}/{sidesOnDice2}")]
        [HttpGet]
        public string waysToRollTen(int sidesOnDice1, int sidesOnDice2) {
            int countWays = 0;
            for (int i = 1; i <= sidesOnDice1; i++) {
                if ((10 - i) >= 1 && (10 - i) <= sidesOnDice2) {
                    countWays++;
                }
            }

            string outputStr = string.Empty;
            if (countWays == 1)
            {
                outputStr = "There is 1 way to get the sum 10.";
            }
            else {
                outputStr = "There are " + countWays + " ways to get the sum 10.";
            }

            return outputStr;
        }
    }
}
