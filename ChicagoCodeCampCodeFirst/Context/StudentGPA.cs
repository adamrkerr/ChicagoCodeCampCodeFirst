﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChicagoCodeCampCodeFirst.Context
{
    public class StudentGPA: IIdentified<Guid>
    {
        public Guid Id { get; set; }

        public decimal? GPA { get; set; }

        public int CoursesEnrolled { get; set; }
    }
}
