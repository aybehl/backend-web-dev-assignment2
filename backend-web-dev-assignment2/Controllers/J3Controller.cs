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
        ///<link>https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2022/ccc/juniorEF.pdf</link>
		///<problem-type>J3</problem-type>
		///<problem-name>Harp Tuning</problem-name>
        ///<summary>
        ///Method takes one string input containing instructions and after processing it returns an array of strings containing legible instructions
        ///</summary>
        ///<param name="instructions">A string input</param>
        ///<example>
        ///GET api/J3/harpTuning/AFB+8HC-4 -> ["AFB tighten 8", "HC loosen 4"]
        ///</example>
        ///<example>
        ///GET api/J3/harpTuning/AFB+8SC-4H-2GDPE+9 -> ["AFB tighten 8", "SC loosen 4", "H loosen 2", "GDPE tighten 9"]
        ///</example>
        ///<returns>An array of legible instructions</returns>
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

            //For the last instruction, store the result in the list
            if(hasSeenANumber)
            {
                listOfTuningInstructions.Add(tempStr.ToString());
                tempStr.Clear();
            }

            return listOfTuningInstructions;
        }
    }
}
