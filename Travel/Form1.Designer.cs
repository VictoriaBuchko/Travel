namespace Travel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartdateTimePicker = new DateTimePicker();
            EnddateTimePicker2 = new DateTimePicker();
            StartDateLabel = new Label();
            EndDateLabel = new Label();
            PlaneRadioButton = new RadioButton();
            TrainRadioButton2 = new RadioButton();
            BusRadioButton3 = new RadioButton();
            ChoiceTransportLabel = new Label();
            InsuranceCheckBox = new CheckBox();
            ExcursionsCheckBox = new CheckBox();
            AdditionalLuggageCheckBox = new CheckBox();
            AdditionalServicesLabel = new Label();
            DestinationLabel = new Label();
            DestinationComboBox = new ComboBox();
            PlanningButton = new Button();
            SuspendLayout();
            // 
            // StartdateTimePicker
            // 
            StartdateTimePicker.Location = new Point(31, 38);
            StartdateTimePicker.Name = "StartdateTimePicker";
            StartdateTimePicker.Size = new Size(250, 27);
            StartdateTimePicker.TabIndex = 0;
            // 
            // EnddateTimePicker2
            // 
            EnddateTimePicker2.Location = new Point(31, 110);
            EnddateTimePicker2.Name = "EnddateTimePicker2";
            EnddateTimePicker2.Size = new Size(250, 27);
            EnddateTimePicker2.TabIndex = 1;
            // 
            // StartDateLabel
            // 
            StartDateLabel.AutoSize = true;
            StartDateLabel.Location = new Point(31, 9);
            StartDateLabel.Name = "StartDateLabel";
            StartDateLabel.Size = new Size(174, 20);
            StartDateLabel.TabIndex = 2;
            StartDateLabel.Text = "Дата початку подорожу";
            // 
            // EndDateLabel
            // 
            EndDateLabel.AutoSize = true;
            EndDateLabel.Location = new Point(31, 83);
            EndDateLabel.Name = "EndDateLabel";
            EndDateLabel.Size = new Size(154, 20);
            EndDateLabel.TabIndex = 3;
            EndDateLabel.Text = "Дата кінця подорожі";
            // 
            // PlaneRadioButton
            // 
            PlaneRadioButton.AutoSize = true;
            PlaneRadioButton.Location = new Point(43, 191);
            PlaneRadioButton.Name = "PlaneRadioButton";
            PlaneRadioButton.Size = new Size(65, 24);
            PlaneRadioButton.TabIndex = 4;
            PlaneRadioButton.TabStop = true;
            PlaneRadioButton.Text = "Літак";
            PlaneRadioButton.UseVisualStyleBackColor = true;
            // 
            // TrainRadioButton2
            // 
            TrainRadioButton2.AutoSize = true;
            TrainRadioButton2.Location = new Point(43, 221);
            TrainRadioButton2.Name = "TrainRadioButton2";
            TrainRadioButton2.Size = new Size(69, 24);
            TrainRadioButton2.TabIndex = 5;
            TrainRadioButton2.TabStop = true;
            TrainRadioButton2.Text = "Поїзд";
            TrainRadioButton2.UseVisualStyleBackColor = true;
            // 
            // BusRadioButton3
            // 
            BusRadioButton3.AutoSize = true;
            BusRadioButton3.Location = new Point(43, 251);
            BusRadioButton3.Name = "BusRadioButton3";
            BusRadioButton3.Size = new Size(86, 24);
            BusRadioButton3.TabIndex = 6;
            BusRadioButton3.TabStop = true;
            BusRadioButton3.Text = "Автобус";
            BusRadioButton3.UseVisualStyleBackColor = true;
            // 
            // ChoiceTransportLabel
            // 
            ChoiceTransportLabel.AutoSize = true;
            ChoiceTransportLabel.Location = new Point(31, 160);
            ChoiceTransportLabel.Name = "ChoiceTransportLabel";
            ChoiceTransportLabel.Size = new Size(132, 20);
            ChoiceTransportLabel.TabIndex = 7;
            ChoiceTransportLabel.Text = "Вибір транспорту";
            // 
            // InsuranceCheckBox
            // 
            InsuranceCheckBox.AutoSize = true;
            InsuranceCheckBox.Location = new Point(346, 183);
            InsuranceCheckBox.Name = "InsuranceCheckBox";
            InsuranceCheckBox.Size = new Size(106, 24);
            InsuranceCheckBox.TabIndex = 8;
            InsuranceCheckBox.Text = "Страховка ";
            InsuranceCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExcursionsCheckBox
            // 
            ExcursionsCheckBox.AutoSize = true;
            ExcursionsCheckBox.Location = new Point(346, 213);
            ExcursionsCheckBox.Name = "ExcursionsCheckBox";
            ExcursionsCheckBox.Size = new Size(91, 24);
            ExcursionsCheckBox.TabIndex = 9;
            ExcursionsCheckBox.Text = "Екскурсії";
            ExcursionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdditionalLuggageCheckBox
            // 
            AdditionalLuggageCheckBox.AutoSize = true;
            AdditionalLuggageCheckBox.Location = new Point(346, 243);
            AdditionalLuggageCheckBox.Name = "AdditionalLuggageCheckBox";
            AdditionalLuggageCheckBox.Size = new Size(160, 24);
            AdditionalLuggageCheckBox.TabIndex = 10;
            AdditionalLuggageCheckBox.Text = "Додатковий багаж";
            AdditionalLuggageCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdditionalServicesLabel
            // 
            AdditionalServicesLabel.AutoSize = true;
            AdditionalServicesLabel.Location = new Point(346, 160);
            AdditionalServicesLabel.Name = "AdditionalServicesLabel";
            AdditionalServicesLabel.Size = new Size(137, 20);
            AdditionalServicesLabel.TabIndex = 11;
            AdditionalServicesLabel.Text = "Додаткові послуги";
            // 
            // DestinationLabel
            // 
            DestinationLabel.AutoSize = true;
            DestinationLabel.Location = new Point(346, 9);
            DestinationLabel.Name = "DestinationLabel";
            DestinationLabel.Size = new Size(151, 20);
            DestinationLabel.TabIndex = 12;
            DestinationLabel.Text = "Місце призначення ";
            // 
            // DestinationComboBox
            // 
            DestinationComboBox.FormattingEnabled = true;
            DestinationComboBox.Items.AddRange(new object[] { "Париж", "Лондон", "Нью-Йорк" });
            DestinationComboBox.Location = new Point(346, 40);
            DestinationComboBox.Name = "DestinationComboBox";
            DestinationComboBox.Size = new Size(151, 28);
            DestinationComboBox.TabIndex = 13;
            // 
            // PlanningButton
            // 
            PlanningButton.Location = new Point(185, 310);
            PlanningButton.Name = "PlanningButton";
            PlanningButton.Size = new Size(174, 29);
            PlanningButton.TabIndex = 14;
            PlanningButton.Text = "Планувати поїздку";
            PlanningButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 358);
            Controls.Add(PlanningButton);
            Controls.Add(DestinationComboBox);
            Controls.Add(DestinationLabel);
            Controls.Add(AdditionalServicesLabel);
            Controls.Add(AdditionalLuggageCheckBox);
            Controls.Add(ExcursionsCheckBox);
            Controls.Add(InsuranceCheckBox);
            Controls.Add(ChoiceTransportLabel);
            Controls.Add(BusRadioButton3);
            Controls.Add(TrainRadioButton2);
            Controls.Add(PlaneRadioButton);
            Controls.Add(EndDateLabel);
            Controls.Add(StartDateLabel);
            Controls.Add(EnddateTimePicker2);
            Controls.Add(StartdateTimePicker);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker StartdateTimePicker;
        private DateTimePicker EnddateTimePicker2;
        private Label StartDateLabel;
        private Label EndDateLabel;
        private RadioButton PlaneRadioButton;
        private RadioButton TrainRadioButton2;
        private RadioButton BusRadioButton3;
        private Label ChoiceTransportLabel;
        private CheckBox InsuranceCheckBox;
        private CheckBox ExcursionsCheckBox;
        private CheckBox AdditionalLuggageCheckBox;
        private Label AdditionalServicesLabel;
        private Label DestinationLabel;
        private ComboBox DestinationComboBox;
        private Button PlanningButton;
    }
}
