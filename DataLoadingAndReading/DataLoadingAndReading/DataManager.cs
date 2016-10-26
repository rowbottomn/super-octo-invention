using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DataLoadingAndReading
{
    class DataManager
    {
        public string[] readAllData(string fileName)
        {
            try
            {
                return File.ReadAllLines(@fileName);
            }
            catch (Exception e)
            {
                if (fileName.Contains(".csv"))
                {
                     fileName += ".csv";
                }
                else if (fileName.Contains(".txt"))
                {
                    fileName += ".txt";
                }
                return File.ReadAllLines(fileName);
            }
        }

        public string[] readSomeData(string fileName, int start, int num)
        {
            StreamReader reader = new StreamReader(fileName);
           //data array, yo
            string[] data = new string[num];
            string dataLine = "";
            int i;

            for (i = 0; i < start; i++)
            {
                if (reader.ReadLine() != null) ;
            }

            for (int j = 0; j < num ; j++){
                dataLine = reader.ReadLine();
                if (dataLine == null) {
                    reader.Close();
                    return data; 
                }
                data[j] = dataLine;
            }
            reader.Close();
            return data; 
        }

        public void loadAllDataToTextBox(string[] data, TextBox box, TextBox test)
        {
            box.Clear();
            for (int i = 0; i <data.Length; i++){
            
                test.Text += "" + i;
                box.AppendText(data[i]+"\n");
                //box.AppendText();
                
            }
        }

        public void loadAllDataToTextBox(string[] data, TextBox box)
        {
            box.Clear();
            for (int i = 0; i < data.Length; i++)
            {
                box.AppendText(data[i]);
            }
        }

        public string loadAllDataToTextBox(string[] data, ListBox listBox, string header)
        {
            
            listBox.Items.Clear();
            int i = 0;
            if (header == "get header")
            {
                header = data[0];
                i = 1;
            }
            for (; i < data.Length; i++)
            {
                listBox.Items.Add(data[i]);
            }
            return header;
        }

        public void writeAllDataToFile(string fileName, string[] data)
        {
            var writer = new StreamWriter(fileName);

            foreach (string d in data)
            {
               writer.WriteLine(d);
            }

            writer.Close();
        }

        public void writeAllDataToFile(string fileName, ListBox list, string header)
        {
            var writer = new StreamWriter(fileName);

            int i = 0;
            if (header != "")
            {
                writer.WriteLine(header);
                i = 1;
            }
            for (; i < list.Items.Count; i++)
            {
                writer.WriteLine(list.Items[i].ToString());
            }

            writer.Close();
        }

    }
}
