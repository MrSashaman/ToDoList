using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList;

public partial class Form1 : Form
{
    private int taskCount = 0;

    public Form1()
    {
        InitializeComponent();
        label1.Text = $"Current tasks: {taskCount}";

    }
    
    
    private void AddTask_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NameTask.Text))
        {
            MessageBox.Show("Поле не может быть пустым!");
            return;
        }
        
        string searchItem = NameTask.Text;
        if (listBox.Items.Contains(searchItem))
        {
            MessageBox.Show("Такое задание существует!");
            return;

        }

        else
        {
            listBox.Items.Add(NameTask.Text); 
            taskCount++;
            label1.Text = $"Current tasks: {taskCount}";
            NameTask.Clear();
        }
        



    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (listBox.SelectedIndex != -1) 
        {
            listBox.Items.Remove(listBox.SelectedItem);
            taskCount -= 1;
            label1.Text = $"Current tasks: {taskCount}";
        }

    }

    private void editbtn_Click(object sender, EventArgs e)
    {   
        
        if (listBox.SelectedIndex != -1)
        {
            editextpanel.Visible = true;
            edittext.Visible = true;
            SetNewName.Visible = true;
            //---------------------------
            AddTask.Visible = false;
            button1.Visible = false;

        }
    }

    private void SetNewName_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(edittext.Text))
        {
            MessageBox.Show("Поле не может быть пустым!");
            return;
        }
        
        string searchItem = edittext.Text;
        if (listBox.Items.Contains(searchItem))
        {
            MessageBox.Show("Такое задание существует!");
        }
        
        listBox.Items[listBox.SelectedIndex] = edittext.Text;
        editextpanel.Visible = false;
        edittext.Visible = false;
        SetNewName.Visible = false;
        //---------------------------
        AddTask.Visible = true;
        button1.Visible = true;
    }


    private void canceledit_Click(object sender, EventArgs e)
    {
        editextpanel.Visible = false;
        edittext.Visible = false;
        SetNewName.Visible = false;
        //---------------------------
        AddTask.Visible = true;
        button1.Visible = true;
    }

    private void save_Click(object sender, EventArgs e)
    {
        List<string> itemsList = listBox.Items.Cast<string>().ToList();
        string json = JsonConvert.SerializeObject(itemsList, Formatting.Indented);
        File.WriteAllText("listbox_data.json", json);
        MessageBox.Show("Файл сохранён!");

    }

    private void load_Click(object sender, EventArgs e)
    {
        if (File.Exists("listbox_data.json"))
        {
            string json = File.ReadAllText("listbox_data.json");
            List<string> itemsList = JsonConvert.DeserializeObject<List<string>>(json);
            listBox.Items.Clear();
            listBox.Items.AddRange(itemsList.ToArray());
        }
    }
}