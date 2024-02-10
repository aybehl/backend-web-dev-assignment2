using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace backend_web_dev_assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        private Boolean isInvalidInstruction(Char c) {
            if ((c >= 'A' && c <= 'T') || (c == '+') || (c == '-')) {
                return false;
            }

            return true;
        }


        [Route("api/J3/harpTuning/{instructions}")]
        [HttpGet]
        public  IEnumerable<string> harpTuning(string instructions)
        {
            List<string> listOfTuningInstructions = new List<string>();
            int lenOfInstructions = instructions.Length;
            StringBuilder tempStr = new StringBuilder();
            int i = 0;
            while (i < lenOfInstructions) {
                char c = instructions[i];
                if (isInvalidInstruction(c)) { 
                    return new List<string>();
                }
                //todo

            }
            return listOfTuningInstructions;
        }
    }
}
