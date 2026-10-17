using System;

namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_4_9
{
    public class Appointment
    {
        public string AppointmentId { get; set; }
        public string PatientName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string DoctorName { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }

        public Appointment() { }

        public Appointment(string id, string name, string phone, DateTime date, string doctor, string reason, string status)
        {
            AppointmentId = id;
            PatientName = name;
            PhoneNumber = phone;
            AppointmentDate = date;
            DoctorName = doctor;
            Reason = reason;
            Status = status;
        }
    }
}