using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMWidgetForms
{
    public partial class MoreInfo : Form
    {
        public MoreInfo()
        {
            InitializeComponent();
            titleLabel.Text = this.Text;
            var ds = new DataSet();
            string url = @"https://www.cbr-xml-daily.ru/daily.xml";
            ds.ReadXml(url);
            dataGridView1.DataSource = ds.Tables["Valute"];
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                if (column.Name == "ID" || column.Name == "NumCode")
                    column.Visible = false;
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

        private void SettingsButtonOnClick(object sender, EventArgs e)
        {
            OptionsForm options = new OptionsForm(this);
            options.Show();
        }
    }
}
