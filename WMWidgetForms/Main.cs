using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WMWidgetForms
{
    public partial class Main : Form
    {
        /// <summary>
        /// Адрес стартовой страници
        /// </summary>
        private const string url = @"https://www.cbr-xml-daily.ru/daily.xml";
        public Main()
        {
            InitializeComponent();
            titleLabel.Text = this.Text;
            //ViewrichTextBoxOutData();
            var ds = new DataSet();
            ds.ReadXml(url);
            dataGridView1.DataSource = ds.Tables["Valute"];
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                if (dataGridView1[1, i].Value.ToString() != "USD" && dataGridView1[1, i].Value.ToString() != "EUR")
                {
                    dataGridView1.Rows.RemoveAt(i);
                    i--;
                }

            /*foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
            }*/
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                if (column.Name == "ID" || column.Name == "NumCode")
                    column.Visible = false;
            /*WebClient _webClient = new WebClient { Encoding = Encoding.UTF8 };
            _webClient.Headers["User-Agent"] = "Mozilla/5.0";
            var devices = _webClient.DownloadString("https://www.cbr.ru/scripts/XML_daily.asp?date_req=22/02/2022");*/
            /*WebClient client = new WebClient();
            var xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
            XDocument xdoc = XDocument.Parse(xml);
            var el = xdoc.Element("ValCurs").Elements("Valute");
            string dollar = el.Where(x => x.Attribute("ID").Value == "R01235").Select(x => x.Element("Value").Value).FirstOrDefault();
            string eur = el.Where(x => x.Attribute("ID").Value == "R01239").Select(x => x.Element("Value").Value).FirstOrDefault();
            MessageBox.Show($"Евро: {eur} Доллар: {dollar}");*/
        }

        private void navPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        Point lastPoint;
        private void navPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Отображение данных
        /// </summary>
        private void ViewrichTextBoxOutData()
        {
            var items = GetExchangeRates();
            int n = 0;
            int m = 0;
            int h = 4;
            while (n != items.Count)
            {
                for (int i = m; i < h; i++)
                {
                    //dataGridView1.Rows.Add(items);
                    m++;
                    n++;
                }
                h += 4;
            }
            for (int i = 0; i < items.Count; i++)
            {
                if (i % 4 == 0)
                {
                    
                        //dataGridView1.Rows.Add(items[i]);
                    
                }
                if (i % 3 == 0)
                {

                    //dataGridView1.Rows.Add(items[i]);

                }
            }

         for (int i = 0; i < items.Count; i++)
         {
             /*if(i % 4 == 0)
             {
                 // в первый столбец помеаем items[i]
                 dataGridView1.Rows[0].Cells[0].Value = items[i];
             }
             else if (i % 4 == 1)
             {
                 // в второй столбец помеаем items[i]

             }
             else if (i % 4 == 2)
             {
                 // в второй столбец помеаем items[i]

             }
             else if (i % 4 == 3)
             {
                 // в второй столбец помеаем items[i]

             }*/
         }
        foreach (var it in items)
        {
        //richTextBoxOutData.Text += it;
        //this.dataGridView1.Rows.Add(it);
        /*foreach (var i in items)
        {
            this.dataGridView1.Rows.Add(it);
            dataGridView1.Rows[it].Cells[j] ;
        }*/
        }
        }

        /// <summary>
        /// Курсы валют
        /// </summary>
        /// <returns></returns>
        static public List<string> GetExchangeRates()
        {
        List<String> data = new List<string>();
        DataSet ds = new DataSet();
        string url = "https://www.cbr.ru/scripts/XML_daily.asp?date_req=22/02/2022";
        ds.ReadXml(url);
        DataTable currency = ds.Tables["Valute"];
        foreach (DataRow row in currency.Rows)
        {
            data.Add(row["CharCode"].ToString());
            data.Add(row["Nominal"].ToString());
            data.Add(row["Name"].ToString());
            data.Add(row["Value"].ToString());
            /*if (row["CharCode"].ToString() == CharCode)//Ищу нужный код валюты
            {
                data.Add(row["CharCode"].ToString());
                data.Add(row["Nominal"].ToString());
                data.Add(row["Name"].ToString());
                data.Add(row["Value"].ToString());
            }*/
        }
        return data;
        }

        private void SettingsButtonOnClick(object sender, EventArgs e)
        {
            OptionsForm options = new OptionsForm(this);
            options.Show();
            this.Hide();
        }
    }
}
