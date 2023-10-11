using Survey_Task_V2.Models;
using System.Windows.Forms;

namespace Survey_Task_V2
{
    public partial class Form1 : Form
    {

        List<Anket> ankets = new List<Anket>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Anket newAnket = new(nameTxtbox.Text, surnameTxtbox.Text, EmailTxtbox.Text, phoneTextbox.Text, BirthdatePicker.Value);
            ankets.Add(newAnket);
            Ankets.Items.Add(newAnket.name);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1;
            if (result.ShowDialog() == DialogResult.OK)
                JsonHandling.WriteAnketToJson(folderBrowserDialog1.SelectedPath + "/", ankets[Ankets.SelectedIndex]);
            else
                MessageBox.Show("Something went wrong");

        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {

            var result = openFileDialog1;
            openFileDialog1.Filter = "Json Files|*.json";
            if (result.ShowDialog() == DialogResult.OK)
            {
                Anket anket = JsonHandling.ReadAnketFromJson(openFileDialog1.FileName);
                Ankets.Items.Add(anket.name);
                ankets.Add(anket);
            }
            else
                MessageBox.Show("Something went wrong");

        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (Ankets.SelectedIndex != -1)
            {
                Anket anket = ankets[Ankets.SelectedIndex];
                nameTxtbox.Text = anket.name;
                surnameTxtbox.Text = anket.surname;
                EmailTxtbox.Text = anket.email;
                phoneTextbox.Text = anket.phoneNumber;
                BirthdatePicker.Text = anket.birthDate.ToShortDateString();
            }
            else
                MessageBox.Show("Select any survey from listbox");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loada basdiqda file secirsiniz secdiyiniz file listboxa elave edilir\nSave a basdiqda listboxda secili olan elementi istediyiniz foldere save edir\nAdd basdiqda listboxa elave olunur\nChange basdiqda listboxdan secdimiz elementde deyisiklik ede bilerik\n\t\tHormetle Huseyn!\t\t", "About");
        }
    }
}