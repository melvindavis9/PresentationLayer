using BusinessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {

        private PodcastController podcastController;

        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Podcast> listOfPodcasts = podcastController.GetPodcasts;
            dataGridViewP.DataSource = listOfPodcasts;

            dataGridViewP.SelectionChanged += new EventHandler(DataGridViewP_SelectionChanged);
        }

        private void listBoxC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxC.SelectedIndex != -1)
            {
                textBoxC.Text = listBoxC.SelectedItem.ToString();
            }
            else
            {
                textBoxC.Clear();
            }
        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewC_Click(object sender, EventArgs e)
        {
            //validering
            if (!String.IsNullOrEmpty(textBoxC.Text))
            {
                listBoxC.Items.Add(textBoxC.Text);
                comboBoxCategory.Items.Add(textBoxC.Text);
                textBoxC.Clear();
            }

        }

        private void btnRemoveC_Click(object sender, EventArgs e)
        {
            listBoxC.Items.Remove(listBoxC.SelectedItem);
        }

        private void btnSaveC_Click(object sender, EventArgs e)
        {
            //validering
            if (!String.IsNullOrEmpty(textBoxC.Text))
            {
                if (listBoxC.SelectedIndex != -1)
                {
                    if (textBoxC.Text != null)
                    {
                        string s = textBoxC.Text;
                        int i = listBoxC.SelectedIndex;
                        listBoxC.Items[i] = s;
                    }
                }
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridViewP_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewP.CurrentRow;
            Podcast podcast = (Podcast)row.DataBoundItem;
            textBoxNameP.Text = podcast.Namn;

        }

    }
}
