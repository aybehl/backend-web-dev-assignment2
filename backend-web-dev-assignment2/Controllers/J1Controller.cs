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
