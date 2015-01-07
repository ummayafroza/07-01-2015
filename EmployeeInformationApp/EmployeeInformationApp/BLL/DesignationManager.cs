using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInformationApp.DAL.DAO;
using EmployeeInformationApp.DAL.DBGetway;

namespace EmployeeInformationApp.BLL
{
   public class DesignationManager
    {
       const  int MIN_LENGTH_OF_CODE= 3;
        public string Save(Designation aDesignation)
        {
            if (aDesignation.Code.Length >=MIN_LENGTH_OF_CODE )
            {
                DesignationDbGetway aDesignationDbGetway = new DesignationDbGetway();
                aDesignationDbGetway.Save(aDesignation);
                return "saved";

            }
            else
            {
                return "code must be in" + MIN_LENGTH_OF_CODE + " char long";

            }
        }
    }
}
