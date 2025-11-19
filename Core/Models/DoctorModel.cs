using System;

namespace ClinicOS.Models
{
    public class DoctorModel
    {
        public decimal FirstVisitFee { get; set; }
        public decimal FollowUpFee { get; set; }
        public int FollowUpLimitWeeks { get; set; }
    }
}