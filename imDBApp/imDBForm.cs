using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using System.Threading;

namespace imDBApp
{
    public partial class imDBForm : Form
    {
        public imDBForm()
        {
            InitializeComponent();
        }

        async private void bt_search_Click(object sender, EventArgs e)
        {
            string desc;
            string name;

            pb_spinner.Visible = true;
            pb_image.Visible = true;

            bt_search.Enabled = false;
            tb_search.Enabled = false;

            pb_image.Image = null;
            tb_name.Text = string.Empty;
            tb_description.Text = string.Empty;

            tb_name.ReadOnly = true;
            tb_description.ReadOnly = true;

            try
            {
                dynamic data = await Task.Run<dynamic>(
                    ()=>
                    {
                        return this.GetData(this.tb_search.Text);
                    }
                );
                if (data == null)
                    return;

                name = data.Title;
                desc = data.Plot;
                pb_image.Image = GetImage((string)data.Poster);
                tb_name.Text = name;
                tb_search.Text = name;
                tb_description.Text = desc;
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error occured", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pb_spinner.Visible = false;
            bt_search.Enabled = true;
            tb_search.Enabled = true;
        }

        private dynamic GetData(string name)
        {
            var webClient = new WebClient();
            string nameFormated = Uri.EscapeDataString(name);
            return JsonConvert.DeserializeObject<dynamic>(webClient.DownloadString("http://www.omdbapi.com/?t=" + nameFormated + "&apikey=2efa58af").Trim());
        }

        private Image GetImage(string image_url)
        {
            using (var Client = new WebClient())
            {
                var st = Client.OpenRead(image_url);
                return Bitmap.FromStream(st);
            }
        }
        
    }
}
