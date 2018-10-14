using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdfundraising
{
    class Patient

    {
        public static int lastpatientno = 0;

        #region Properties
        public int PatientID { get; }
        public string Name { get; set; }
        public Decimal Age { get; set; }
        public string Gender { get; set; }
        public Donor PatientDonor { get;  }

        #endregion

        #region Constractor
        public Patient(Donor inputDonor)

        {
            PatientDonor = inputDonor;
            PatientID = lastpatientno + 1;

        }
        #endregion

    }
}
