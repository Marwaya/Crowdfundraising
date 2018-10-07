using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdfundraising
{
    //Defines all the features of a Donor account
    class Donor
    {
        #region Properties
        public int DonorID { get; set; }
        public string DonorName { get; set; }
        public string Country { get; set; }

        #endregion
    }
}