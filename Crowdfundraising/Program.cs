using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdfundraising
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance => object
            var first_donor = new Donor();
            var first_patient = new Patient(first_donor);

            // create a new project
            var first_project = new Project(first_patient, "first project");
            var Y = new Donation(first_donor, first_project);

            // create another project
            var second_project = new Project(first_patient, "second project");

            Console.WriteLine($"Patient No: { first_patient.PatientID}, Project Type: {first_project.Name}, Donor NO:{first_donor.DonorID}");           
            
            
        }
    }
}
