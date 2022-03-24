using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace TSystem_SerializationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.DeptID = Convert.ToInt32(txtDeptID.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                FileStream fs = new FileStream(@"D:\Department.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added Sucessfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
           FileStream fs = new FileStream(@"D:\Department.json", FileMode.Open, FileAccess.Read);
                dept = JsonSerializer.Deserialize<Department>(fs);
                txtDeptID.Text=dept.DeptID.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.DeptID = Convert.ToInt32(txtDeptID.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                FileStream fs = new FileStream(@"D:\DepartmentXmlFile.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                xml.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added Sucessfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"D:\DepartmentXmlFile.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                dept = (Department)xml.Deserialize(fs);
                txtDeptID.Text = dept.DeptID.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //1 . store data into the object
                Department dept = new Department();
                dept.DeptID = Convert.ToInt32(txtDeptID.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                //2. Create a file & open in write mode 
                FileStream fs = new FileStream(@"D:\DeptbinaryFile.dat", FileMode.Create, FileAccess.Write);
                //3. use serliaze method 
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"D:\DeptbinaryFile.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                dept = (Department)bf.Deserialize(fs);
                txtDeptID.Text = dept.DeptID.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //1 . store data into the object
                Department dept = new Department();
                dept.DeptID = Convert.ToInt32(txtDeptID.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                //2. Create a file & open in write mode 
                FileStream fs = new FileStream(@"D:\DeptsoapFile.soap", FileMode.Create, FileAccess.Write);
                //3. use serliaze method 
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"D:\DeptsoapFile.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                dept = (Department)sf.Deserialize(fs);
                txtDeptID.Text = dept.DeptID.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
