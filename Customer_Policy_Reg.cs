using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEL
{
    public class Customer_Policy_Reg
    {
        public int Customer_id { get; set; }
        public string Policy_name { get; set; }
        public string Policy_company { get; set; }
        public DateTime Date_of_booking { get; set; }
        public long Sum_assured { get; set; }
        public string Payment_mode { get; set; }
        public long Agent_Id { get; set; }
        public DateTime Date_of_birth { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Identification_mark { get; set; }
        public string Nominee_name { get; set; }
        public string Nominee_relationship { get; set; }
        public DateTime Nominee_date_of_birth { get; set; }
        public long Contact_no { get; set; }
        public string Appointment_id { get; set; }
    }
}
