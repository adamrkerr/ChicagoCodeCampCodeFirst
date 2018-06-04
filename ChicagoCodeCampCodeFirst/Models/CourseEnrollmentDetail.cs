using System;
using System.Collections.Generic;
using System.Text;

namespace ChicagoCodeCampCodeFirst.Models
{
    public class CourseEnrollmentDetail
    {
        public Guid StudentId { get; set; }

        public Decimal FinalGrade { get; set; }

        public StudentDetail Student { get; set; }
    }
}
