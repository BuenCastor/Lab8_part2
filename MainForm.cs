using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class MainForm : Form
    {
        private BindingList<Disk> disks;

        public MainForm()
        {
            InitializeComponent();
            disks = new BindingList<Disk>();
            listBox1.DisplayMember = "Typ";
            listBox1.DataSource = disks;
            listBox1.SelectedIndexChanged += new EventHandler(ListBox1_SelectedIndexChanged);
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            Disk disk = new Disk();
            DiskForm af = new DiskForm(disk);
            if (af.ShowDialog() == DialogResult.OK)
            {
                disks.Add(disk);
            }
        }

        void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Disk disk = (Disk)listBox1.SelectedItem;
            MessageBox.Show("Тип: " + disk.Typ + "\n" +
                "Країна: " + disk.Country + "\n" +
                "Швидкість: " + disk.Speed + "\n" +
                "Ємність: " + disk.Capacity + "\n" +
                "Об'єм: " + disk.Volume + "\n" +
                "Інтерфейс: " + disk.Sata,
                "Інформація про диск", MessageBoxButtons.OK);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Прекратить роботу?", "Завершение работы", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
