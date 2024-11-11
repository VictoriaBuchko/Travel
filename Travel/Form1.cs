namespace Travel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PlanningButton.Click += new EventHandler(PlanningButton_Click);
        }

        private void PlanningButton_Click(object sender, EventArgs e)
        {
            if (EnddateTimePicker2.Value.Date < StartdateTimePicker.Value.Date)
            {
                MessageBox.Show("���� ���������� ������� �� ���� ���� ����� ���� �������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string transport = PlaneRadioButton.Checked ? "˳���" :
                               TrainRadioButton2.Checked ? "����" :
                               BusRadioButton3.Checked ? "�������" : "�� �������";

            string services = "";
            if (InsuranceCheckBox.Checked) services += "���������; ";
            if (ExcursionsCheckBox.Checked) services += "�������; ";
            if (AdditionalLuggageCheckBox.Checked) services += "���������� �����; ";
            if (string.IsNullOrEmpty(services)) services = "���� ���������� ������";

            string destination = DestinationComboBox.SelectedItem?.ToString() ?? "�� �������";

            string summary = $"���� ������� �������: {StartdateTimePicker.Value:dd/MM/yyyy}; " +
                             $"���� ���������� �������: {EnddateTimePicker2.Value:dd/MM/yyyy}\n" +
                             $"���������: {transport}; ̳��� �����������: {destination}\n" +
                             $"�������� �������: {services}";

            MessageBox.Show(summary, "ϳ������ ����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
