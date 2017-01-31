using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HttpUtils;
using Newtonsoft.Json;

namespace cSharpMeteo
{
    public partial class FrmMeteo : Form
    {
        Rootobject regionResponse = new Rootobject();
        public FrmMeteo()
        {
            InitializeComponent();
            cbxLocalite.Items.Add("Neuchâtel");
            cbxLocalite.Items.Add("la-chaux-de-fonds");
            cbxLocalite.Items.Add("Berne");
            cbxLocalite.Items.Add("Lausanne");
            cbxLocalite.Items.Add("Oceania");
        }

        private void cbxLocalite_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string endPoint = @"http://www.prevision-meteo.ch/services/json/" + cbxLocalite.Text;
              //  string endPoint = @"http://restcountries.eu/rest/v1/region/" + cbxLocalite.Text;

                var client = new RestClient(endPoint);
                var json = client.MakeRequest();

//                object objResponse = JsonConvert.DeserializeObject(json, typeof(List<Country>));

                object objResponse = JsonConvert.DeserializeObject(json, typeof(Rootobject));

                regionResponse = (Rootobject)objResponse;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
