using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdfundraising
{
    class Project
    // Defines the type of the project needed (Surgery, medications, physicaltherapy,Intensive Care unit Accomodation)

    {
        #region Properties
        public int ProjectID { get; set; }
        public String Name { get; set; }
        public string Description { get; set; }
        public int PatientID { get; set; }
        #endregion

    }
}
