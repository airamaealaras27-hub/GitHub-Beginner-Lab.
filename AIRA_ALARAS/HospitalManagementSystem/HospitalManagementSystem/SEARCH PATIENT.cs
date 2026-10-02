using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class frmSearchPatient : Form
    {
        public frmSearchPatient()
        {
            InitializeComponent();
        }

        private void lblPatientID_Click(object sender, EventArgs e)
        {

        }

        private void frmSearchPatient_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtPatientID.Text == "")
            {
                MessageBox.Show("Please enter a Patient ID.");
                return;
            }

            if (txtPatientID.Text == PatientData.PatientID)
            {
                lblPatient.Text = "Patient Name: " +
                    PatientData.LastName + " " +
                    PatientData.FirstName + " " +
                    PatientData.MiddleName;

                lblPatientAge.Text = "Age: " + PatientData.Age;
                lblPatientGender.Text = "Gender: " + PatientData.Gender;
                lblPatientContactNumber.Text = "Contact Number: " + PatientData.ContactNumber;
            }
            else
            {
                MessageBox.Show("Patient not found.");
            }        
    
        }
    }
    
}
