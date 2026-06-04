using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStaffAuditLogs
    {
        public int StaffID { get; set; }
        public string Action { get; set; }
        public DateTime Timestamped { get; set; }
        public string PerformedBy { get; set; }

        public void AuditLogs()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.AddParameter("@Action", Action);
            DB.AddParameter("@Timestamped", Timestamped);
            DB.AddParameter("@PerformedBy", PerformedBy);
            DB.Execute("sproc_tblStaffAuditLogs_Insert");
        }
    }
}