﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.ViewModels.MealVMs
{
    public class MealUpdateVM
    {
        public int Id { get; set; }
        public string MealName { get; set; }
        public DateTime UpdateOn=>DateTime.Now;
    }
}
