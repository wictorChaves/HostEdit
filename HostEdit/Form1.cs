using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HostEdit
{
    public partial class Form1 : Form
    {
        private string _path = @"C:\Windows\System32\drivers\etc\hosts";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] readText = File.ReadAllLines(_path);
            foreach (string s in readText)
            {
                if (_isValid(s))
                    listBox1.Items.Add(_formatString(s));
            }
        }

        private object _formatString(string s)
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            string[] arrayString = regex.Replace(s, " ").Split(' ');
            if (arrayString.Length <= 1) return arrayString[0];
            return regex.Replace(s, " ").Split(' ')[1];
        }

        private bool _isValid(string s)
        {
            if (s.Trim().Length <= 0) return false;
            return s.Trim()[0] != '#';
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (txt.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Favor entrar com algum valor");
                return;
            }
            listBox1.Items.Add(txt.Text.Trim());
        }

        private void rm_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox1);
            selectedItems = listBox1.SelectedItems;

            if (listBox1.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    listBox1.Items.Remove(selectedItems[i]);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string[] newText = listBox1.Items.Cast<string>().ToArray();
            var newTextFormatted = newText.Select(n => "127.0.0.1 " + n).ToArray();
            File.WriteAllLines(_path, newTextFormatted);
        }
    }
}
