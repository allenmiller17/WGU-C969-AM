using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WGU_C969_AM
{
    class appointmentException : ApplicationException
    {
        public void outsideOfBusinessHours()
        {
            MessageBox.Show("An Exception has occured! The appointment is outside of normal business hours!");
        }

        public void appointmentOverlap()
        {
            MessageBox.Show("An Exception has occured! An appointment is already scheduled for desired time! Please select a new time!");
        }
    }
}
