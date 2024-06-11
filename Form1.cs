using StringSorter.Scripts;
using StringSorter.Scripts.Utilities;

namespace StringSorter
{
    public partial class frmMain : Form
    {
        private SortType sortType;

        public TextBox InputTextBox { get => txtStringInput; } 
        public ComboBox SortTypeComboBox { get => cmbSortType; } 
        public Label OutputLabel { get => lblOutputString; } 

        public frmMain()
        {
            InitializeComponent();
        }

        public string GetInputString() => txtStringInput.Text;

        public SortType GetSelectedSortType() => sortType;

        public void DisplaySortedString(string sortedString) => lblOutputString.Text = $"Output: {sortType}\n{sortedString}";

        public SortType SortTypeConverter(string selectSortType)
        {
            SortType tempSortType = SortType.Bubble;

            switch (selectSortType)
            {
                case "Bubble Sort": tempSortType = SortType.Bubble; break;
                case "Quick Sort": tempSortType = SortType.Quick; break;
                case "Merge Sort": tempSortType = SortType.Merge; break;
                    default: MessageBox.Show("Select Sort type first.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);break;
            }

            return tempSortType;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            if (cmbSortType.Text.NullOrEmpty() || txtStringInput.Text.NullOrEmpty())
            {
                MessageBox.Show("Please input a string.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStringInput.Focus();
                return;
            }

            SortController.Instance.Sorted();
        }

        private void cmbSortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Extension.ClearControls(new Control[] { lblOutputString, txtStringInput});
            Extension.EnableControls(new Control[] { txtStringInput, btnSort }, true);
            sortType = SortTypeConverter(cmbSortType.SelectedItem?.ToString());
        }
    }
}
