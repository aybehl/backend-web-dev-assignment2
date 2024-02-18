using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace backend_web_dev_assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        ///<link>https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2022/ccc/juniorEF.pdf</link>
		///<problem-type>J1</problem-type>
        ///<problem-name>Cupcake Party</problem-name>
        ///<summary>
        ///Method takes two input parameters 1. # of Regular Boxes 2. # of Small Boxes and returns # of left over Cupcakes
        ///</summary>
        ///<param name="noOfRegularBoxes">An integer input</param>
		///<param name="noOfSmallBoxes">An integer input</param>
        ///<example>
        ///GET /api/J1/leftOverCupcakes/2/5 -> 3
        ///</example>
        ///<example>
        ///GET /api/J1/leftOverCupcakes/2/4 -> 0
        ///</example>
        ///<returns>The number of cupcakes that are left over</returns>
        [Route("api/J1/leftOverCupcakes/{noOfRegularBoxes}/{noOfSmallBoxes}")]
        [HttpGet]
        public int getLeftOverCupcakes(int noOfRegularBoxes, int noOfSmallBoxes) {
            int noOfStudentsInClass = 28;
            int capacityOfRegularBox = 8;
            int capacityOfSmallBox = 3;

            int totalCupcakes = capacityOfRegularBox * noOfRegularBoxes + capacityOfSmallBox * noOfSmallBoxes;
            int leftOverCupcakes = totalCupcakes % noOfStudentsInClass;

            return leftOverCupcakes;        
        }
    }
}
