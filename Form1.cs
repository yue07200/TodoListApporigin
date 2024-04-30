using System.Windows.Forms;

namespace TodoListApp
{
    public partial class Form1 : Form
    {
        private TodoList todoList;
        private string filePath = "todolist.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string itemName = listBox1.SelectedItem.ToString();
                MessageBox.Show(itemName + "³Q¿ï¤F!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            todoList = new TodoList();
            todoList.LoadFromFile(filePath);
            listBox1.DataSource = todoList.GetItems();
        }
    }
}
