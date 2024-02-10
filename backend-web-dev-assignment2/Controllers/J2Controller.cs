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

        [Route("api/J2/waysToRollTen/{sidesOnDice1}/{sidesOnDice2}")]
        [HttpGet]
        public int waysToRollTen(int sidesOnDice1, int sidesOnDice2) {
            int countWays = 0;
            for (int i = 1; i <= sidesOnDice1; i++) {
                if ((10 - i) >= 1 && (10 - i) <= sidesOnDice2) {
                    countWays++;
                }
            }

            return countWays;
        }
    }
}
