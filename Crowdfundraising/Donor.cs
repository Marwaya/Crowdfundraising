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
        public static int LastDonorNO= 0;
        #region Properties
        public int DonorID { get;  }
        public string DonorName { get; set; }
        public string Country { get; set; }

        #endregion

        #region constractor


        public Donor()
        {
            DonorID = LastDonorNO + 1;

        }
        #endregion




    }



}