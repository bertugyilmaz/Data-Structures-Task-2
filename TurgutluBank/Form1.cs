using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurgutluBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CircularArrayTypedQueue circular = new CircularArrayTypedQueue(20);
        PriorityQueue priority = new PriorityQueue(20);

        CircularArrayTypedQueue circular2 = new CircularArrayTypedQueue(20);
        PriorityQueue priority2 = new PriorityQueue(20);

        List<Customer> customers = new List<Customer>();

        int average1, average2;

        private void Form1_Load(object sender, EventArgs e)
        {
            int total = 0;
            Random r = new Random();
            for (int i = 1; i <= 20; i++)
            {
                Customer c = new Customer();
                c.customerNumber = i;
                c.taskTime = r.Next(60, 601);
                total += c.taskTime;
                c.standbyTime = total;

                priority.Insert(c);
                circular.Insert(c);
                customers.Add(c);
                circular2.Insert(c);
                priority2.Insert(c);
            }
        }

        private void circularButton_Click(object sender, EventArgs e)
        {
            int average = 0;
            for (int i = 1; i <= 20; i++)
            {
                Customer c = (Customer)circular.Remove();
                circularTextBox.Text += c.customerNumber + ": " + c.taskTime + " Bekleme Süresi" + c.standbyTime + Environment.NewLine;
                average += c.standbyTime;
            }
            circularTextBox.Text += "Ortalama süresi : " + (average / 20).ToString();
            average1 = average / 20;
        }

        private void priorityButton_Click(object sender, EventArgs e)
        {
            int total = 0;
            int average = 0;
            for (int i = 1; i <= 20; i++)
            {
                Customer c = (Customer)priority.Remove();
                total += c.taskTime;
                c.PriorityStandbytime = total;
                priorityTextBox.Text += c.customerNumber + " " + c.taskTime + "Bekleme süreniz" + c.PriorityStandbytime + Environment.NewLine;
                average += c.PriorityStandbytime;
            }
            priorityTextBox.Text += "Ortalama süreniz : " + (average / 20).ToString();
            average2 = average / 20;
        }

        private void timeButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                Customer c = (Customer)priority2.Remove();
                if (c.PriorityStandbytime < customers[c.customerNumber -1].standbyTime)
                {
                    timeTextBox.Text += c.customerNumber + "- " + c.standbyTime + " - " + c.PriorityStandbytime + Environment.NewLine;
                }
            }
            int ort_fark = average1 - average2;
            float yuzdelik = 100 * ort_fark / average1;
            timeTextBox.Text += "Ortalama zaman farkı : " + (ort_fark).ToString() + Environment.NewLine;
            timeTextBox.Text += "Ortalama yüzdelik : %" + (yuzdelik).ToString();
        }
    }
}
