using System.Windows.Forms;

namespace WFApp
{
    public partial class Form1 : Form
    {
        private const string myDbPath = "C:\\myNewDb";

        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Nmae", "Name");
            dataGridView1.Columns.Add("Surname", "Surname");
            dataGridView1.Rows.Add("1", "M", "R");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listViewStudent.Columns.Clear();
            //listViewStudent.Items.Clear();
            //listViewStudent.Columns.Add("#", "#");
            //listViewStudent.Columns.Add("Id", "Id");
            //listViewStudent.Columns.Add("Name", "Name");
            var index = 1;
            var listViewItem = new ListViewItem($"{index}");
            var subItem1 = new ListViewItem.ListViewSubItem(listViewItem, "1");
            var subItem2 = new ListViewItem.ListViewSubItem(listViewItem, "M");
            index++;

            var listViewItem1 = new ListViewItem($"{index}");
            var subItem3 = new ListViewItem.ListViewSubItem(listViewItem1, "5");
            var subItem4 = new ListViewItem.ListViewSubItem(listViewItem1, "X");
            listViewItem.SubItems.Add(subItem1);
            listViewItem.SubItems.Add(subItem2);
            //listViewItem.SubItems.Add(subItem1);
            //listViewItem.SubItems.Add(subItem1);

            // listViewStudent.Items.Add(listViewItem);




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var directory = new DirectoryInfo(myDbPath);
            var lastFile = directory.GetFiles().OrderByDescending(f => f).Select(f => f.Name).FirstOrDefault();
            var studentId = 0;
            if (lastFile == null)
            {
                studentId = 1;
            }
            else
            {
                studentId = int.Parse(Path.GetFileNameWithoutExtension(lastFile));
                studentId++;
            }

            var fileText = $"Name: {textBox1.Text}\n\n  $Surname: {textBox2.Text}";
            var filePath = Path.Combine(myDbPath, $"{studentId}.txt");
            File.WriteAllText(filePath, fileText);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    this.openFileDialog1.ShowDialog();
        //    pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
        //    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        //}


    }
}