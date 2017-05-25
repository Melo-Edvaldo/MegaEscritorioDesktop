using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MegaEscritorioDesktop.Program;

namespace MegaEscritorioDesktop
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        double width;
        double depth;
        double materialCost;
        double orderTime;
        double quote;

        decimal drawers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int quoteCount = DeskQuote.countQuotes();
            DateTime now = DateTime.Now;
            quoteDate.Text = now.ToString("d");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void day5RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void laminateRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void width_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void depth_TextChanged(object sender, EventArgs e)
        {

        }

        private void clickCalculate_Click(object sender, EventArgs e)
        {
            // Calculate

            width = (double)deskWidth.Value;
            depth = (double)deskDepth.Value;

            double area = Desk.deskArea(width, depth);

            deskArea.Text = area.ToString();
            drawers = drawerNumber.Value;

            int drawerInt = Desk.drawersToInt(drawers);

            double basePrice = 200;
            double drawerCost = drawerInt * 50;
            double deskAreaSize = area - 1000;

            if (deskAreaSize < 0) deskAreaSize = 0;

            string material;
            
            if (pineMaterial.Checked)
            {
                materialCost = 50.0;
                material = "Pine";
            }

            else if (laminateMaterial.Checked)
            {
                materialCost = 100.0;
                material = "Laminate";
            }

            else
            {
                materialCost = 200.0;
                material = "Oak";
            }

            int orderDays;

            if (dayThree.Checked)
            {
                if (area < 1000) orderTime = 60;
                else if ((area >= 1001) && (area <= 1999)) orderTime = 70;
                else orderTime = 80;
                orderDays = 3;
            }

            else if (dayFive.Checked)
            {
                if (area < 1000) orderTime = 40;
                else if ((area >= 1000) && (area <= 1999)) orderTime = 50;
                else orderTime = 60;
                orderDays = 5;
            }

            else if (daySeven.Checked)
            {
                if (area < 1000) orderTime = 30;
                else if ((area >= 1001) && (area <= 1999)) orderTime = 30;
                else orderTime = 40;
                orderDays = 7;
            }

            else
            {
                orderTime = 0;
                orderDays = 14;
            }

            quote = DeskQuote.makeQuote(basePrice, deskAreaSize, drawerCost, materialCost, orderTime);

            Desk newDesk = new Desk(width, depth, drawerInt, material, orderDays, quote);
            Console.WriteLine(newDesk);

            priceQuote.Text = "$" + quote.ToString() + ".00";
        }

        private void deskWidth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void priceQuote_Click(object sender, EventArgs e)
        {

        }
    }
}
