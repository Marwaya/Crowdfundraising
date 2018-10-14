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
        
        public Donor DonorID { get;  }
        public DateTime Date { get; set; }
        public Decimal Amount { get; set; }
        public Project ProjectID { get; }

        #endregion

        #region Constractor
        public Donation(Donor A, Project B)
        {
            DonorID = A;
            ProjectID = B;

        }
        #endregion






    }

}
