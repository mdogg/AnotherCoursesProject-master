﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesLibrary
{
    public class CourseCategory
    {
        public string Title { get; internal set; }

        public string Description { get; internal set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
