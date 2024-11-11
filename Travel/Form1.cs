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
                MessageBox.Show("Дата завершення подорожі не може бути раніше дати початку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string transport = PlaneRadioButton.Checked ? "Літак" :
                               TrainRadioButton2.Checked ? "Поїзд" :
                               BusRadioButton3.Checked ? "Автобус" : "Не вибрано";

            string services = "";
            if (InsuranceCheckBox.Checked) services += "Страховка; ";
            if (ExcursionsCheckBox.Checked) services += "Екскурсії; ";
            if (AdditionalLuggageCheckBox.Checked) services += "Додатковий багаж; ";
            if (string.IsNullOrEmpty(services)) services = "Немає додаткових послуг";

            string destination = DestinationComboBox.SelectedItem?.ToString() ?? "Не вибрано";

            string summary = $"Дата початку подорожі: {StartdateTimePicker.Value:dd/MM/yyyy}; " +
                             $"Дата завершення подорожі: {EnddateTimePicker2.Value:dd/MM/yyyy}\n" +
                             $"Транспорт: {transport}; Місце призначення: {destination}\n" +
                             $"Додаткові послуги: {services}";

            MessageBox.Show(summary, "Підсумок планування", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
