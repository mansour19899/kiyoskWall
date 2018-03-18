﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyoskWall
{
    class ListDate
    {
        private int _worksheet;
        public ListDate(int WorkSheet)
        {
            
            _worksheet = WorkSheet;
            
        }

        public List<Date> GetList()
        {
            var db = new PoonehEntities1();
            List<Date> q;
            string dtnow = "1396/12/26";
            //string dtnow = DateTime.Now.ToPersianDateString();
            q = (from p in db.Schedules
                where p.SDate.CompareTo(dtnow) == 1
                select new Date { date = p.SDate } 
                ).Distinct().OrderBy(o => o.date).ToList();

            if (_worksheet == (int)Shift.Rozkar)
            {
               List<Date> qq = (from pp in db.HoliDays
                    where pp.HolidayDate.CompareTo(dtnow) == 1
                    select new Date { date = pp.HolidayDate,meal = 1}).Distinct().ToList();

                for (int i = 0; i < qq.Count; i++)
                {
                    var ee = q.Where(p => p.date == qq.ElementAt(i).date).FirstOrDefault();
                    q.Remove(ee);
                }

                foreach (var item in q)
                {
                    item.day = item.date.ToPersianday();
                    item.meal = 1;
                }
                return q;
            }

            else if (_worksheet == (int)Shift.A8)
            {
                return ShiftFilter(q, 0);
            }
            else if (_worksheet == (int)Shift.B8)
            {
                return ShiftFilter(q, 4);
            }
            else if (_worksheet == (int)Shift.C8)
            {
                return ShiftFilter(q, 8);
            }
            else if (_worksheet == (int)Shift.D8)
            {
                return ShiftFilter(q, 12);
            }

            else
            {
                return q;
            }


        }

        private List<Date> ShiftFilter(List<Date> d, int skip)
        {
            int x = 0;

            string datee = "1396/10/27".AddDaysToShamsiDate(skip);
            List<Date> qqq=new List<Date>();
            for (int i = 0; i < d.Count; i++)
               
            {
                x = d.ElementAt(i).date.DiffDaysShamsi(datee);
                x = x %16;
                if (x >=0 & x < 4)
                {
                    d.ElementAt(i).meal = 1;
                    qqq.Add(d.ElementAt(i));
                }

                if (x >=4 & x < 8)
                {
                    d.ElementAt(i).meal = 2;
                    qqq.Add(d.ElementAt(i));
                }

            }

            foreach (var item in qqq)
            {
                item.day = item.date.ToPersianday();
            }
            return qqq;
        }

    }
}
