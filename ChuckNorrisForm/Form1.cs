using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisAPI;
using static ChuckNorrisAPI.ChuckNorrisClient;

namespace ChuckNorrisForm
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private async void NewJokeBtn_ClickAsync(object sender, EventArgs e)
        {
            Joke joke = await GetRandomJoke();
            
            string result = joke.JokeText;
            rtbResults.Clear();
            rtbResults.Text = result;
        }

        private async void MainFrm_Load(object sender, EventArgs e)
        {

            var categories = await GetCategories();

            foreach (string category in categories)
            {
                CategoryCmb.Items.Add(category);
            }

        }

        private void GetJokeByCategoryBtn_Click(object sender, EventArgs e)
        {
            //Mis-read homework and created button click
        }
    }
}
