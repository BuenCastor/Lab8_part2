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
    public partial class DiskForm : Form
    {
        public Disk TheDisk;

        public DiskForm(Disk t)
        {
            TheDisk = t;
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                TheDisk.Typ = tbTyp.Text.Trim();
                TheDisk.Country = tbCountry.Text.Trim();
                TheDisk.Speed = int.Parse(tbSpeed.Text.Trim());
                TheDisk.Capacity = int.Parse(tbCapacity.Text.Trim());
                TheDisk.Volume = int.Parse(tbVolume.Text.Trim());
                TheDisk.Sata = tbSata.Text.Trim();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                string err = String.Format("Error number. {0}", ex.Message);
                MessageBox.Show(err, "Conversion error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DiskForm_Load(object sender, EventArgs e)
        {
            if (TheDisk != null)
            {
                tbTyp.Text = TheDisk.Typ;
                tbCountry.Text = TheDisk.Country;
                tbSpeed.Text = TheDisk.Speed.ToString();
                tbCapacity.Text = TheDisk.Capacity.ToString();
                tbVolume.Text = TheDisk.Volume.ToString();
                tbSata.Text = TheDisk.Sata;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbType_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSpeed_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbSpeed.Text, "[^0-9]"))
            {
                MessageBox.Show("Заборонено використання літер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSpeed.Text = tbSpeed.Text.Remove(tbSpeed.Text.Length - 1);
            }
        }

        private void tbCapacity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbCapacity.Text, "[^0-9]"))
            {
                MessageBox.Show("Заборонено використання літер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCapacity.Text = tbCapacity.Text.Remove(tbCapacity.Text.Length - 1);
            }
        }

        private void tbVolume_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbVolume.Text, "[^0-9]"))
            {
                MessageBox.Show("Заборонено використання літер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbVolume.Text = tbVolume.Text.Remove(tbVolume.Text.Length - 1);
            }
        }
    }
}