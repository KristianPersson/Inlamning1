using _01_Inlamning.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.Json;

namespace _01_Inlamning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<Contacts> contacts = new List<Contacts>();   
        

        public MainWindow()
        {
           
            InitializeComponent();
            if(contacts.Count > 0)
                lvContacts.ItemsSource = contacts;
          
        }
        
        
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
           
            if (!string.IsNullOrEmpty(firstName.Text) && !string.IsNullOrEmpty(lastName.Text) && !string.IsNullOrEmpty(email.Text))
            {
                string path = @"C:\\AAAA\\TextFile.txt";
                string Space = "\n";
                string Tab = "\t";
                contacts.Add(new Contacts
                {
                    Id = Guid.NewGuid(),
                    FirstName = firstName.Text,
                    LastName = lastName.Text,
                    Email = email.Text,
                  
            });
                
               //string filePath = @"C:\Users\KPKri\OneDrive\Documents\Text.txt";
                //List<string> lines = new List<string>();
                //lines = File.WriteAllText(filePath, json);
                lvContacts.ItemsSource = new List<Contacts>();
                lvContacts.ItemsSource = contacts;

                File.ReadAllText(path);
                File.AppendAllText(path, firstName.Text);
                File.AppendAllText(path, Tab);
                File.AppendAllText(path, lastName.Text);
                File.AppendAllText(path, Tab);
                File.AppendAllText(path, email.Text);
                File.AppendAllText(path, Space);


            }
            

        }

        private void btnCode_Click(object sender, RoutedEventArgs e)
        {
            code.Text = "2022";
        }
    
    
    
    }
}
