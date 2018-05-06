﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyoskWall
{
    class PerMeal
    {
        
        public string Date { get; set; }
        public string Day { get; set; }
        public int Meal { get; set; }
               
        public Tray Tray1 { get; set; }
        public Tray Tray2 { get; set; }
        public Tray Tray3 { get; set; }

        public Schedule schedule1 { get; set; }
        public Schedule schedule2 { get; set; }
        public Schedule schedule3 { get; set; }

        public Image pictuer1 { get; set; }
        public Image pictuer2 { get; set; }
        public Image pictuer3 { get; set; }
                
        public PerMeal(Date Date)
        {
            this.Date = Date.date;
            this.Day = Date.day;
            this.Meal = Date.meal;

        }

    }
}
