using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        List<string[]> data = new List<string[]>();
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Дата", 100);
            listView1.Columns.Add("Заголовок", 100);
            listView1.Columns.Add("Текст", 550);
            string filePath = "data.json";

            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);

                // Десериализуем данные из JSON
                List<DataItem> dataItems = JsonSerializer.Deserialize<List<DataItem>>(jsonString);

                // Заполняем ListView данными
                foreach (DataItem item in dataItems)
                {
                    ListViewItem newItem = new ListViewItem(item.Date);
                    newItem.SubItems.Add(item.Name);
                    newItem.SubItems.Add(item.Text);
                    listView1.Items.Add(newItem);
                }
                data = new List<string[]>();
                foreach (ListViewItem item in listView1.Items)
                {
                    string[] rowData = new string[item.SubItems.Count];

                    // Заполняем массив данными из каждого подэлемента (столбца)
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        rowData[i] = item.SubItems[i].Text;
                    }
                    // Добавляем массив данных в список
                    data.Add(rowData);
                }
            }
            }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textdate.Text != "" && textdate.Text != "Заполните поле")
            {
                if (textboxGlav.Text != "" && textboxGlav.Text != "Заполните поле")
                {
                    if (textBox3.Text != "" && textBox3.Text != "Заполните поле")
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { $"{textdate.Text}", $"{textboxGlav.Text}", $"{textBox3.Text}" }));
                    }
                    else
                        textBox3.Text = "Заполните поле";
                }
                else
                    textboxGlav.Text = "Заполните поле";
            }
            else
                textdate.Text = "Заполните поле";
            data = new List<string[]>();
            foreach (ListViewItem item in listView1.Items)
            {
                string[] rowData = new string[item.SubItems.Count];

                // Заполняем массив данными из каждого подэлемента (столбца)
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    rowData[i] = item.SubItems[i].Text;
                }
                // Добавляем массив данных в список
                data.Add(rowData);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                if (textdate.Text != "" && textdate.Text != "Заполните поле")
                {
                    if (textboxGlav.Text != "" && textboxGlav.Text != "Заполните поле")
                    {
                        if (textBox3.Text != "" && textBox3.Text != "Заполните поле")
                        {
                            selectedItem.SubItems[0].Text = textdate.Text;
                            selectedItem.SubItems[1].Text = textboxGlav.Text;
                            selectedItem.SubItems[2].Text = textBox3.Text;
                        }
                        else
                            textBox3.Text = "Заполните поле";
                    }
                    else
                        textboxGlav.Text = "Заполните поле";
                }
                else
                    textdate.Text = "Заполните поле";
            }
            data = new List<string[]>();
            foreach (ListViewItem item in listView1.Items)
            {
                string[] rowData = new string[item.SubItems.Count];

                // Заполняем массив данными из каждого подэлемента (столбца)
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    rowData[i] = item.SubItems[i].Text;
                }
                // Добавляем массив данных в список
                data.Add(rowData);
            }
        }

        private void Click(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            textdate.Text = selectedItem.Text;
            textboxGlav.Text = selectedItem.SubItems[1].Text;
            textBox3.Text = selectedItem.SubItems[2].Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                listView1.Items.Remove(selectedItem);
                data = new List<string[]>();
                foreach (ListViewItem item in listView1.Items)
                {
                    string[] rowData = new string[item.SubItems.Count];

                    // Заполняем массив данными из каждого подэлемента (столбца)
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        rowData[i] = item.SubItems[i].Text;
                    }
                    // Добавляем массив данных в список
                    data.Add(rowData);
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox6.Text.ToLower();

            // Фильтруем элементы ListView
            listView1.Items.Clear();
            if (searchText == "") // Проверка на пустое поле
            {
                // Если поле пустое, отображаем все данные
                foreach (string[] row in data)
                {
                    ListViewItem newItem = new ListViewItem(row[0]);
                    for (int i = 1; i < row.Length; i++)
                    {
                        newItem.SubItems.Add(row[i]);
                    }
                    listView1.Items.Add(newItem);
                }
            }
            else
            {
                // Если поле не пустое, выполняем фильтрацию
                foreach (string[] row in data)
                {
                    bool matchFound = false;
                    for (int i = 0; i < row.Length; i++)
                    {
                        if (row[i].ToLower().Contains(searchText))
                        {
                            matchFound = true;
                            break;
                        }
                    }

                    if (matchFound)
                    {
                        ListViewItem newItem = new ListViewItem(row[0]);
                        for (int i = 1; i < row.Length; i++)
                        {
                            newItem.SubItems.Add(row[i]);
                        }
                        listView1.Items.Add(newItem);
                    }
                }
            }

            // ОБНОВЛЕНИЕ ListView
            listView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<DataItem> dataItems = new List<DataItem>();
            foreach (string[] row in data)
            {
                dataItems.Add(new DataItem
                {
                    Date = row[0],
                    Name = row[1],
                    Text = row[2]
                });
            }

            // Сериализуем данные в JSON
            string jsonString = JsonSerializer.Serialize(dataItems);

            // Сохраняем JSON-строку в файл
            string filePath = "data.json"; // Путь к файлу
            File.WriteAllText(filePath, jsonString);
        }
    }
    }
    
