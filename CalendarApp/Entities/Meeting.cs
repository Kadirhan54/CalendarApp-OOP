﻿using CalendarApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Entities
{
    internal class Meeting : Event
    {
        public List<string> Guests { get; set; }

    }
}
