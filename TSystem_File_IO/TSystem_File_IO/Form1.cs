using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TSystem_File_IO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblLocation_Click(object sender, EventArgs e)
        {

        }

        private void lblDeptID_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string path = @"D:\Test";
            if(Directory.Exists(path))
            {
                MessageBox.Show("Folder Already Exist!");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Folder Created Sucessfully!...");
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"D:\Test\Testfile.txt";
            if (File.Exists(path))
            {
                MessageBox.Show("File Already Exist!");
            }
            else
            {
                File.Create(path);
                MessageBox.Show("File Created Sucessfully!...");
            }
        }

            FileStream fs;
            BinaryWriter bw;
        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                 fs = new FileStream(@"D:\Test\Dept.txt", FileMode.Create, FileAccess.Write);
                 bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtDeptID.Text));
                bw.Write(txtName.Text);
                bw.Write(txtLocation.Text);
                MessageBox.Show("Data Saved Sucessfully!...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                bw.Close();
                fs.Close();
            }

        }

            
            BinaryReader br;
        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                 fs = new FileStream(@"D:\Test\Dept.txt", FileMode.Open, FileAccess.Read);
                 br = new BinaryReader(fs);
               txtDeptID.Text= br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
               txtLocation.Text = br.ReadString();
                MessageBox.Show("Data Read Sucessfully!...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                br.Close();
                fs.Close();
            }
        }
    }
}
