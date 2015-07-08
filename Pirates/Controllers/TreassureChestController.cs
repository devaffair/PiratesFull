using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Numerics;

namespace Pirates.Controllers
{
    public class TreassureChestController : ApiController
    {
        // GET api/TreassureChest/5
        public string Get(string pirates)
        {
            int iPirates = 0;

            // in case the input was not a number
            if (!int.TryParse(pirates, out iPirates))
                return "Talk to me in numbers.";

            // in case the number was 0 - invalid operation
            if (iPirates == 0)
                return "Too much rum eh?";

            // in case the number was 1 - invalid operation
            if (iPirates == 1)
                return "All pirates are dead but you. Coincidence?";

            // in case the number is 2 - Two cannot be included in any formula.
            if (iPirates == 2)
                return "31";

            // Once understanding 2 is a special number - the formla is rather simple.
            BigInteger result = BigInteger.Pow(iPirates, iPirates + 1) - (iPirates - 1);
            return result.ToString();
        }
    }
}
