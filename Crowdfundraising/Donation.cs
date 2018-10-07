using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdfundraising
{
    // Defines all the donation features
    class Donation
    {
        #region properties
        
        public int DonorID { get; set; }
        public DateTime Date { get; set; }
        public Decimal Amount { get; set; }
        public int ProjectID { get; set; }
        
        #endregion
    }

}
