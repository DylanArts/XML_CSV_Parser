using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XML_to_CSV_form
{
    public partial class XMLtoCSVParser : Form
    {
        public XMLtoCSVParser()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OpenBtn.FlatAppearance.BorderColor = Color.Black;
            ParseBtn.FlatAppearance.BorderColor = Color.Black;
            SaveCSVBtn.FlatAppearance.BorderColor = Color.Green;
        }

        private string xmlFilePath = string.Empty;                              //File path of XML dataset
        private string xmlName = string.Empty;                                  //File name of XML dataset file
        private string csvFilePath = string.Empty;                              //File path where CSV file will be downloaded
        private List<string> csvString = new List<string>();                    //CSV string that will be filled with the parsed data

        private void OpenBtn_Click(object sender, EventArgs e)               
        {
            SaveCSVBtn.Visible = false;
            richTextBox1.Text = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())        //Open File Dialog where you can pick a XML dataset
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "XML Files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)             //If File is picked set parameters
                {
                    try
                    {
                        //Get the path of specified file
                        xmlFilePath = openFileDialog.FileName;
                        xmlName = openFileDialog.SafeFileName;
                        xmlName = xmlName.Substring(0, xmlName.Length - 4);

                        textBox1.Text = xmlFilePath;
                    }
                    catch(Exception exc)
                    {
                        richTextBox1.Text += "Check if your file isn't corrupt" + "\r\n";
                    }
                }
            }
        }

        private void ParseBtn_Click(object sender, EventArgs e)
        {
            XDocument xml;

            try
            {
                xml = XDocument.Load(xmlFilePath);

                string value = "";

                int count = 0;

                foreach (var node in xml.DescendantNodes())                     //For each node in the XML elements
                {
                    if (node is XText && ((XText)node).Value != $"\",\"")       //Check for values and check for the end of a line
                    {
                        if (value.Length > 0)
                        {
                            value += ";" + ((XText)node).Value;
                        }
                        else
                        {
                            value += ((XText)node).Value;
                        }
                    }
                    else if (node is XText)                                     //If it is a value and not a end of a line add the value to a line
                    {
                        count++;
                        csvString.Add(value);
                        value = "";
                    }
                }

                richTextBox1.Text += "Parsed XML" + "\r\n";
                richTextBox1.Text += "Read " + count + " lines!" + "\r\n";

                SaveCSVBtn.Visible = true;                                      //Enable save button for CSV dataset download                        
            }
            catch(Exception exc)                                                //Check if XML file isn't corrupt
            {
                richTextBox1.Text += "ERROR:" + e + "\r\n";
                richTextBox1.Text += "Check if your file isn't corrupt" + "\r\n";
            }
                  

        }

        private void SaveCSVBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pick a directory to save the CSV file in");

            using (FolderBrowserDialog dialog = new FolderBrowserDialog())      //Open Folder Dialog to pick folder where CSV file will be saved
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    csvFilePath = dialog.SelectedPath + "/" + xmlName + ".csv";

                    if (CheckFileExists(csvFilePath))
                    {
                        WriteCSVLine(csvString);
                    }
                }
            }
        }
        
        private bool CheckFileExists(string path)
        {
            if (File.Exists(path))                                              //Check if file is already present
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete the present file?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)                           //If user wants to delete the file
                {
                    try
                    {
                        File.Delete(path);
                        richTextBox1.Text += "Deleted existing file" + "\r\n";
                        return true;
                    }
                    catch (Exception ex)
                    {
                        richTextBox1.Text += "ERROR: Something went wrong while deleting the present file!" + "\r\n";
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    richTextBox1.Text += "Canceled CSV save!" + "\r\n";
                }
            }

            return false;
        }

        private void WriteCSVLine(List<string> lines)
        {
            richTextBox1.Text += "Writing CSV" + "\r\n";

            int count = 0;

            try
            {
                using (StreamWriter file = new StreamWriter(csvFilePath, true))
                {
                    foreach (string s in lines)
                    {
                        count++;
                        file.WriteLine(s);                                  //Write CSV file for each CSV data in parameter
                    }
                }
            }
            catch (Exception e)
            {
                richTextBox1.Text +="ERROR: Another process is probably using the document provided" + "\r\n";
                Console.ReadLine();
            }

            richTextBox1.Text += "Saved the csv file to > " + xmlFilePath + @"\" + xmlName + ".csv";
        }
    }
}
