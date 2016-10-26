using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLoadingAndReading
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            fileName = t_loadName.Text;
        }

        public string[] data;
        DataManager dataHandler = new DataManager();
        string fileName;

        string header = "";

        private void b_loadData_Click(object sender, EventArgs e)
        {
            fileName = t_loadName.Text;
            data = dataHandler.readAllData(fileName);
            //dataHandler.loadAllDataToTextBox(data,t_dataText);
            if (ck_headerInLoad.Checked)
            {
                header = "get header";
            }
            header = dataHandler.loadAllDataToTextBox(data, lb_loadedData, header);//header is loaded here
            t_header.Text = header;
            progressBar1.Maximum = lb_loadedData.Items.Count-1;
            progressBar1.Value = 0;
        }

        private void b_partLoad_Click(object sender, EventArgs e)
        {
            fileName = t_loadName.Text;
            data = dataHandler.readSomeData(fileName, (int)n_start.Value,(int)n_numLines.Value );
      
            //dataHandler.loadAllDataToTextBox(data, t_dataText);
            if (ck_headerInLoad.Checked)
            {
                header = "get header";
            }
            header = dataHandler.loadAllDataToTextBox(data, lb_loadedData, header);//header loaded here
            t_header.Text = header;
            progressBar1.Maximum = lb_loadedData.Items.Count-1;
            progressBar1.Value = 0;
        }

        private void b_save_Click(object sender, EventArgs e)
        {

            //dataHandler.writeAllDataToFile(t_saveName.Text, data);
            dataHandler.writeAllDataToFile(t_saveName.Text, lb_selectedData, header);
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //note that this is the lb_loadData
            if (lb_loadedData.SelectedItem!= null && lb_loadedData.Items.Count>0){
                if (t_voter.Text == "")
                {
                    t_voter.Text = lb_loadedData.SelectedItem.ToString();
                    lb_loadedData.Items.Remove(lb_loadedData.SelectedItem);
                    string[] temp = t_voter.Text.Split(',');
                    t_saveName.Text = temp[0]+temp[1] + ".txt";
                }
                else { 
                    lb_selectedData.Items.Add(lb_loadedData.SelectedItem);
                    lb_loadedData.Items.Remove(lb_loadedData.SelectedItem);
                    progressBar1.Value = lb_selectedData.Items.Count;
                }
                
            }

            //send data to selection

        }
 
        private void lb_selectedData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_selectedData.SelectedItem != null && lb_selectedData.Items.Count > 0)
            {
                t_header.Text = lb_selectedData.SelectedItem.ToString();
                lb_loadedData.Items.Add(lb_selectedData.SelectedItem);
                lb_selectedData.Items.Remove(lb_selectedData.SelectedItem);
                progressBar1.Value = lb_selectedData.Items.Count;
            }
        }

        //needless methods

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void dg_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void t_voter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
