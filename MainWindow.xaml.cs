using System;
using System.Collections;
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

namespace hashTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>   
    public partial class MainWindow : Window
    {
        Hashtable testHashTable;
        public MainWindow()
        {
            InitializeComponent();
            testHashTable = new Hashtable();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Add
            //Hashtable จะคล้ายกับ Array List แต่มีโครงสร้างแบบ Key:Value โดย key ใน Hashtable จะต้องห้ามซ้ำกันกับที่มีอยู่แล้ว
            testHashTable.Add(txtKey.Text,txtValue.Text);
            MessageBox.Show("Add Key : " + txtKey.Text + "-and Add Value :" + txtValue.Text + "- Complete");
            txtKey.Clear();
            txtValue.Clear();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            //Remove
            testHashTable.Remove(txtKey.Text);//ต่างจาก Array List ตรงที่เราเลือก key เพื่อลบข้อมูล
            MessageBox.Show("Delete Key : " + txtKey.Text + "- Complete");
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = testHashTable.Keys; //จะทำการดึง Key ทั้งหมดไปใส่ไว้ในตัวแปร icollection เพราะไม่ได้ใช้ Index แบบ ArrayList แต่จะดึงแค่ Keys ไม่ดึง Value
            //ShowAll
            foreach (string hashKey in icollection) //ดึง key จากใน hashtable เพื่อมาแสดงผล
            {
                MessageBox.Show(testHashTable[hashKey].ToString());//เพราะการเก้บข้อมูลใน hashtable จะเก็บเป็น object เวลาแสดงผลต้องแปลงให้เป็นประเภทข้อมูลที่เราต้องการแสดง ผลที่แสดงออกมาจะดึงค่า Value ของ Keys นั้นๆมาแสดง
            }
        }
    }
}
