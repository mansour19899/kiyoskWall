﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiyoskWall
{
    public partial class KeyPad : Form
    {
        public KeyPad()
        {
            InitializeComponent();
            
        }
        public KeyPad(bool weekk)
        {
            InitializeComponent();
            week = weekk;
        }
        StringBuilder sb = new StringBuilder();
        PoonehEntities1 db;
        bool week = false;
        private void KeyPad_Load(object sender, EventArgs e)
        {
            db = new PoonehEntities1();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowNumber("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowNumber("2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowNumber("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowNumber("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowNumber("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowNumber("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowNumber("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowNumber("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowNumber("9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ShowNumber("0");
        }
        public void ShowNumber(string s)
        {
            lbNumber.ForeColor = Color.Black;
            if(sb.Length<10)
            sb.Append(s);

            lbNumber.Text = sb.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbNumber_Click(object sender, EventArgs e)
        {
            sb.Remove(sb.Length-1, 1);
            lbNumber.Text = sb.ToString();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            string t = sb.ToString();
            var q = db.People.SingleOrDefault(p => p.NationalCode.Equals(t));
            if (q == null)
            {
                var qq = db.People.SingleOrDefault(p => p.PersonelNo.Equals(t));
                if(qq==null)
                {
                    sb.Clear();
                    lbNumber.ForeColor = Color.Red;
                    lbNumber.Text = "شخص مورد نظر ثبت نمی باشد";
                }
              
                else
                {
                    if (week)
                    {
                        ReserveFoodQuickly frm = new ReserveFoodQuickly(qq);
                        frm.Show();
                        this.Close();
                    }
                    else
                    {
                        Form1 frm = new Form1(qq);
                        frm.Show();
                        this.Close();
                    }
                    sb.Clear();
                    lbNumber.Text = "";
                }

            }
            else
            {
                if(week)
                {
                    ReserveFoodQuickly frm = new ReserveFoodQuickly(q);
                    frm.Show();
                    this.Close();
                }
                else
                {
                    Form1 frm = new Form1(q);
                    frm.Show();
                    this.Close();
                }
               
                sb.Clear();
                lbNumber.Text = "";
            }
        }
    }
}