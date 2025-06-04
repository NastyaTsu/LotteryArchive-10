using LotteryArchive.Model.Core;
using Model;
using System.Windows.Forms;

namespace LotteryArchive

{
    public partial class LotteryMain : Form
    {
        public LotteryMain()
        {
            InitializeComponent();

        }
        private static string _selectedItem;
        public static string SelectedItem => _selectedItem;

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form open in Application.OpenForms)
            {
                if (open is CozdatLottery)
                {
                    open.Focus();
                    return;
                }
            }
            CozdatLottery obj = new CozdatLottery();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form open in Application.OpenForms)
            {
                if (open is Participant)
                {
                    open.Focus();
                    return;
                }
            }
            Participant obj = new Participant();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var statsForm = new Statistic();
            statsForm.ShowDialog();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedItem = comboBox1.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e) { }
    }
}
