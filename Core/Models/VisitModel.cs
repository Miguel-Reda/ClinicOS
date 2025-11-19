using System;

namespace ClinicOS.Models
{
    public class VisitModel
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int QueueNumber { get; set; }
        public decimal ActualFee { get; set; }
        public string Status { get; set; }
        public string VisitType { get; set; }
    }
}