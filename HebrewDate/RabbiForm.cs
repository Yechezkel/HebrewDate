using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HebrewDate
{
    public partial class RabbiForm : Form
    {
        string _path;
        XDocument _doc; 


        public RabbiForm(string path)
        {
            InitializeComponent();
            initComboBox_dayName();
            initComboBox_dayNum();
            initComboBox_month();
            initComboBox_year();
            _path = path;
            _doc = XDocument.Load(path);
        }

        private void initComboBox_dayNum()
        {
            for (int i = 1; i < 31; i++)
            {
                comboBox_dayNum.Items.Add("" + i);
            }
        }

        private void initComboBox_dayName()
        {
            comboBox_dayName.Items.Add("ראשון");
            comboBox_dayName.Items.Add("שני");
            comboBox_dayName.Items.Add("שלישי");
            comboBox_dayName.Items.Add("רביעי");
            comboBox_dayName.Items.Add("חמישי");
            comboBox_dayName.Items.Add("שישי");
        }

        private void initComboBox_month()
        {
            comboBox_month.Items.Add("תשרי");
            comboBox_month.Items.Add("חשוון");
            comboBox_month.Items.Add("כסלו");
            comboBox_month.Items.Add("טבת");
            comboBox_month.Items.Add("שבט");
            comboBox_month.Items.Add("אדר א");
            comboBox_month.Items.Add("אדר ב");
            comboBox_month.Items.Add("ניסן");
            comboBox_month.Items.Add("אייר");
            comboBox_month.Items.Add("סיון");
            comboBox_month.Items.Add("תמוז");
            comboBox_month.Items.Add("אב");
            comboBox_month.Items.Add("אלול");
        }

        private void initComboBox_year()
        {
            foreach (string year in _years.Keys)
            {
                comboBox_year.Items.Add(year);
            }

        }


        




        private static Dictionary<string, string> _years = new Dictionary<string, string>
        {
            { "תשפ\"ד", "חמשת אלפים ושבע מאות שמונים וארבע" },
            { "תשפ\"ה", "חמשת אלפים ושבע מאות שמונים וחמש" },
            { "תשפ\"ו", "חמשת אלפים ושבע מאות שמונים ושש" },
            { "תשפ\"ז", "חמשת אלפים ושבע מאות שמונים ושבע" },
            { "תשפ\"ח", "חמשת אלפים ושבע מאות שמונים ושמונה" },
            { "תשפ\"ט", "חמשת אלפים ושבע מאות שמונים ותשע" },
            { "תש\"ץ", "חמשת אלפים ותשע מאות" },
            { "תשצ\"א", "חמשת אלפים ותשע מאות ואחת" },
            { "תשצ\"ב", "חמשת אלפים ותשע מאות ושתיים" },
            { "תשצ\"ג", "חמשת אלפים ותשע מאות ושלוש" },
            { "תשצ\"ד", "חמשת אלפים ותשע מאות וארבע" }
        };


        private static Dictionary<int, string> _dayNums = new Dictionary<int, string>
        {
            { 1, "אחד" },
            { 2, "שניים" },
            { 3, "שלושה" },
            { 4, "ארבעה" },
            { 5, "חמישה" },
            { 6, "שישה" },
            { 7, "שבעה" },
            { 8, "שמונה" },
            { 9, "תשעה" },
            { 10, "עשרה" },
            { 11, "אחד עשר" },
            { 12, "שניים עשר" },
            { 13, "שלושה עשר" },
            { 14, "ארבעה עשר" },
            { 15, "חמישה עשר" },
            { 16, "שישה עשר" },
            { 17, "שבעה עשר" },
            { 18, "שמונה עשר" },
            { 19, "תשעה עשר" },
            { 20, "עשרים" },
            { 21, "עשרים ואחד" },
            { 22, "עשרים ושניים" },
            { 23, "עשרים ושלושה" },
            { 24, "עשרים וארבעה" },
            { 25, "עשרים וחמישה" },
            { 26, "עשרים ושישה" },
            { 27, "עשרים ושבעה" },
            { 28, "עשרים ושמונה" },
            { 29, "עשרים ותשעה" },
            { 30, "שלושים" }
        };

        private void button_result_Click(object sender, EventArgs e)
        {
            string dayName = comboBox_dayName.Text.Trim();
            string dayNum = comboBox_dayNum.Text.Trim();
            int dayNumIndex = int.Parse(comboBox_dayNum.Text.Trim());
            string year = comboBox_year.Text.Trim();
            string month = comboBox_month.Text.Trim();
            if (dayName == "" || comboBox_dayNum.Text.Trim() == "" || year == "" || month == "")//לא הספקתי לעשות בדיקה שכל הערכים שהוכנסו הם חוקיים והמשתמש לא יכניס טקסט שהוא לא חודש וכדומה
            {
                MessageBox.Show("אנא הכנס פרטים מלאים");
                return;
            }
            string result = $"ב{dayName} בשבת יום {_dayNums[dayNumIndex]} לחודש {month} שנת {_years["" + year]} לבריאת העולם";
            if (dayNumIndex == 30 && month != "אלול")
            {
                int currentIndex = comboBox_month.SelectedIndex;
                string nextMonth = comboBox_month.Items[currentIndex + 1].ToString();
                result = $"ב{dayName} בשבת יום שלושים לחודש {month} שהוא ראש חודש {nextMonth} שנת {_years["" + year]} לבריאת עולם";
                
            }

                
                   


            MessageBox.Show(result);

            AddQuery(dayName, dayNum, month, year, result);

            comboBox_dayName.Text = "";
            comboBox_dayNum.Text = "";
            comboBox_year.Text = "";
            comboBox_month.Text = "";
        }














        private void AddQuery(string dayName, string dayNum, string month, string year, string result)
        {
            XElement dayNameX = new XElement("dayName", dayName);
            XElement dayNumX = new XElement("dayNum", dayNum);
            XElement monthX = new XElement("month", month);
            XElement yearX = new XElement("year", year);
            XElement resultX = new XElement("result", result);

            XElement queryX = new XElement("query", dayNameX, dayNumX, monthX, yearX, resultX);

            _doc.Root.Add(queryX);
            _doc.Save(_path);
        }

        
    }
}
