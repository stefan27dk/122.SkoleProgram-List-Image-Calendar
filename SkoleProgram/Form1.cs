using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
namespace SkoleProgram
{
    public partial class Form1 : Form
    {
        string path = "C://t.txt";////Sve path

        public Form1()
        {
            InitializeComponent();

        }




        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }






        private void StuderendeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();


            //this.IsMdiContainer = true;
            //Form Form2 = new Form();
            //Form2.MdiParent = this;
            //Form2.Show();





            //this.Hide();
            //var form2 = new Form2();
            //form2.Closed += (s, args) => this.Close();
            //form2.Show();
        }





        private void UnderviserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }







        private void KlasserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }






        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)////////Date time Picker and Reader from file :::START::
        {
            
          

            richTextBox1.Clear();//////Clears the Notebox
            richTextBox1.Focus();///Focusing the Notebox
            
            Reader();


        }

        ////////Date time Picker and Reader from file :::END::






            private void Reader()
          {
            DateTime pickedDate = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);///The picked Date


            using (Stream stream = File.Open(path, FileMode.Open)) // reopen, all the time
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                try
                {


                    while (true)
                    {
                        var c = (Notebox)binaryFormatter.Deserialize(stream); // var == Notebox


                        string noteboxcheck = Convert.ToString(c.noteboxtext);

                        string datesaved = Convert.ToString(c.date);
                        string dateformat = "dd-MM-yyyy";//Format of the string date

                        DateTime dateTimesaved = DateTime.ParseExact(datesaved, dateformat, CultureInfo.InvariantCulture);///The string date

                        if (pickedDate == dateTimesaved)

                        {
                            richTextBox1.Text = noteboxcheck;

                        }


                    }

                }


                catch (Exception)
                {
                    long length = new System.IO.FileInfo(path).Length;

                }
            }
        }








        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled = true;
    

         
        }







        private void Button1_Click(object sender, EventArgs e)
        {

            Makeobject();

        }







        /////Object maker::START:::
        private void Makeobject()

        {
            DateTime pickedDate = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);///The picked Date

            string noteboxtext = richTextBox1.Text;
            string date = pickedDate.ToShortDateString();


            Notebox newNote = new Notebox(date, noteboxtext);


            WriteToBinaryFile<Notebox>(path, newNote);


        }
        /////Object maker::END:::










            ///////////WRITE To FIle :::START:::
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)////// Binary Writer - Create file with the object content
        {
            //append? FileMode.Append: FileMode.Create:

            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Append))
            {
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }
        ///////////WRITE To FIle :::END:::








        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(33, 30, 28);
        }



        private void Savebutton_Click(object sender, EventArgs e)
        {
            Makeobject();
        }
    }
}
