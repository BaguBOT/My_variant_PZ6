using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        public WeatherDatabase _weather;

        public WeatherForm()
        {
            InitializeComponent();

            _weather = new WeatherDatabase();
            _weather.Initialize();

            Studentdate.DataSource = _weather.Atest.ToList();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            List<Atest> _Find = _weather.Atest.Where(x => x.CityName.ToLower().Contains(textBox1.Text.ToLower()) ).ToList();
            Studentdate.DataSource = _Find;

        }

        private void comboBox1_SelectionChangeCommitted(object sender, System.EventArgs e) {
            
            //string a = comboBox1.Text;
            //    List<Atest> _MeasureUnits = _weather.Atest.Where(x => x.Atest.ToString() ==a ).ToList(); ;
            //    Studentdate.DataSource = _MeasureUnits;

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Studentdate.DataSource = _weather.Atest.ToList();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            List<Atest> _Temp = _weather.Atest.Where(x => x.Temperature >0).ToList();
            Studentdate.DataSource = _Temp;
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            List<Atest> _Temp = _weather.Atest.OrderBy(x => x.Temperature).ToList();
            Studentdate.DataSource = _Temp;
        }
    }
    
}