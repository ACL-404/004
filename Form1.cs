using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            double douCM; //宣告一個double變數，變數名稱叫douCM

            douCM = Convert.ToDouble(txtCM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtM.Text = string.Format("{0:0.##########}", douCM / 100);
            txtKM.Text = string.Format("{0:0.##########}", douCM / 100000);
            txtIn.Text = string.Format("{0:0.##########}", douCM / 2.54);
            txtFt.Text = string.Format("{0:0.##########}", douCM / 30.48);
            txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44);
        }
        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM; //宣告一個double變數，變數名稱叫douCM
            douM = Convert.ToDouble(txtM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtCM.Text = string.Format("{0:0.##########}", douM * 100);
            txtKM.Text = string.Format("{0:0.##########}", douM / 100000);
            txtIn.Text = string.Format("{0:0.##########}", douM * 39.3700787);
            txtFt.Text = string.Format("{0:0.##########}", douM / 3.2808399);
            txtYard.Text = string.Format("{0:0.##########}", douM / 1.0936133);
        }
     private void txtKM_KeyUp(object sender, KeyEventArgs e)
        { 
            double douKM; //宣告一個double變數，變數名稱叫douCM
            douKM = Convert.ToDouble(txtKM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtCM.Text = string.Format("{0:0.##########}", douKM * 100000);
            txtM.Text = string.Format("{0:0.##########}", douKM / 1000);
            txtIn.Text = string.Format("{0:0.##########}", douKM * 39370.0787);
            txtFt.Text = string.Format("{0:0.##########}", douKM / 3280.8399);
            txtYard.Text = string.Format("{0:0.##########}", douKM / 1093.6133);

        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            double douIn; //宣告一個double變數，變數名稱叫douCM
            douIn = Convert.ToDouble(txtIn.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtCM.Text = string.Format("{0:0.##########}", douIn * 2.54);
            txtM.Text = string.Format("{0:0.##########}", douIn * 0.0254);
            txtKM.Text = string.Format("{0:0.##########}", douIn * 0.0000254);
            txtFt.Text = string.Format("{0:0.##########}", douIn / 12);
            txtYard.Text = string.Format("{0:0.##########}", douIn / 36);

        }
        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            double douFt;
            douFt = Convert.ToDouble(txtFt.Text);
            txtCM.Text = string.Format("{0:0.##########}", douFt * 30.48);
            txtM.Text = string.Format("{0:0.##########}", douFt * 0.3048);
            txtKM.Text = string.Format("{0:0.##########}", douFt * 0.0003048);
            txtIn.Text = string.Format("{0:0.##########}", douFt * 12);
            txtYard.Text = string.Format("{0:0.##########}", douFt / 3);

        }
        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            double douYard;
            douYard = Convert.ToDouble(txtYard.Text);
            txtCM.Text = string.Format("{0:0.##########}", douYard * 91.44);
            txtM.Text = string.Format("{0:0.##########}", douYard * 0.9144);
            txtKM.Text = string.Format("{0:0.##########}", douYard * 0.0009144);
            txtIn.Text = string.Format("{0:0.##########}", douYard * 36);
            txtFt.Text = string.Format("{0:0.##########}", douYard * 3);
        }
        private void BT2_Click(object sender, EventArgs e)
        {
            txtInfo.Text = "WHAT?";
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
           
        }
    }
}
