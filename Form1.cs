using System.Data;
using System.Text.Json;
using System.Xml.Serialization;
namespace Assignment_10._1
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        string jsonpath = @"C:\\Apps\MSSA\appsjson.txt";
        string xmlpath = @"C:\\Apps\MSSA\appsxml.xml";

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentID = Convert.ToInt32(txtID.Text);
            student.FirstName = txtName.Text;
            student.Address = txtAddress.Text;
            student.GPA = Convert.ToSingle(txtGPA.Text);

            students.Add(student);

            MessageBox.Show("Student Created");
        }


        private void btnJSONser_Click(object sender, EventArgs e)
        {
            if (File.Exists(jsonpath))
            {
                File.Delete(jsonpath);
            }
            string json = JsonSerializer.Serialize(students);
            File.WriteAllText(jsonpath, json);
            MessageBox.Show("Students List Serialized to JSON file: " + jsonpath);
        }

        private void btnJSONdeser_Click(object sender, EventArgs e)
        {
            FileStream jsonstream = new FileStream(jsonpath, FileMode.Open, FileAccess.Read);
            var obj = JsonSerializer.Deserialize<List<Student>>(jsonstream);

            string result = "";
            foreach (var student in obj)
            {
                result += $"Student name: {student.FirstName}, " +
                     $"Id: {student.StudentID}, " +
                     $"Address: {student.Address}, " +
                     $"GPA: {student.GPA}\n";
            }
            MessageBox.Show(result);
        }

        private void btnXMLser_Click(object sender, EventArgs e)
        {
            if (File.Exists(xmlpath))
            {
                File.Delete(xmlpath);
            }
            FileStream xmlstream = new FileStream(xmlpath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            xmlSerializer.Serialize(xmlstream, students);
            xmlstream.Close();
            MessageBox.Show("Student Serialized to XML File: " + xmlpath);
        }
        
              private void btnXMLdeser_Click(object sender, EventArgs e)
        {
            FileStream xmlstream = new FileStream(xmlpath, FileMode.OpenOrCreate, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            List<Student> obj = (List<Student>)xmlSerializer.Deserialize(xmlstream);

            string result = "";
            foreach (var student in obj)
            {
                result += $"Student name: {student.FirstName}, " +
                  $"Id: {student.StudentID}, " +
                  $"Address: {student.Address}, " +
                  $"GPA: {student.GPA}\n";
            }
            MessageBox.Show(result);
        }
    }
}
