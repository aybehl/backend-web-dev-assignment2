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
        [Route("api/J3/harpTuning/{instructions}")]
        [HttpGet]
        public IEnumerable<string> harpTuning(string instructions)
        {
            List<string> listOfTuningInstructions = new List<string>();
            int lenOfInstructions = instructions.Length;
            StringBuilder tempStr = new StringBuilder();
            int i = 0;
            Boolean hasSeenANumber = false;
            while (i < lenOfInstructions) {
                char c = instructions[i];

                if (c >= 'A' && c <= 'T')
                {
                    if (!hasSeenANumber)
                    {
                        tempStr.Append(c);
                    }
                    else {
                        listOfTuningInstructions.Add(tempStr.ToString());
                        hasSeenANumber = false;
                        tempStr.Clear();
                        tempStr.Append(c);
                    }
                }
                else if (c >= '0' && c <= '9')
                {
                    tempStr.Append(c);
                    hasSeenANumber = true;
                }
                else if (c == '+' || c == '-')
                {
                    tempStr.Append(" ");
                    if (c == '+')
                    {
                        tempStr.Append("tighten");
                    }
                    else {
                        tempStr.Append("loosen");
                    }
                    tempStr.Append(" ");
                }
                else {
                    return new string[] {"Invalid characters in instructions"};
                }

                i++;
            }

            if(hasSeenANumber)
            {
                listOfTuningInstructions.Add(tempStr.ToString());
                tempStr.Clear();
            }

            return listOfTuningInstructions;
        }
    }
}
