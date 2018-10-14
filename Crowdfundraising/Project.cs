using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdfundraising
{

    class Project
    /// <summary>
    /// Defines the type of the project needed (Surgery, medications, physicaltherapy,Intensive Care unit Accomodation
    /// </summary>

    {
        public static int lastprojectno = 0;


        #region Properties
        public int ProjectID { get;}
        public String Name { get;  }
        public string Description { get; set; }
        public Patient Patient { get; }
        #endregion

        #region Constractor
        /// <summary>
        /// This constractor creates the object of project class 
        /// </summary>
        /// <param name="Patient"></param>

        public Project(Patient Patient, String name)
        {
            this.Patient = Patient;
            this.Name = name;
            ProjectID = lastprojectno + 1;
            

        }


    #endregion


    }



}
