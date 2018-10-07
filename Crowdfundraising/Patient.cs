using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdfundraising
{
    class Patient

    {
        #region Properties
        public int PatientID { get; set; }
        public string Name { get; set; }
        public Decimal Age { get; set; }
        public string Gender { get; set; }
        public int DonorID { get; set; }

        #endregion

    }
}
