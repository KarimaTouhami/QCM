using System;
using System.Windows.Forms;

namespace QCM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Display the first question
            DisplayQuestion1();
        }

        private void DisplayQuestion1()
        {
            // Clear previous controls
            ClearControls();

            // Set up the first question
            string question = "Question 1: Allez, Cadeau! Quel était le prénom de Kate Winslet dans Titanic de James Cameron?";
            string[] options = { "Marge", "Rose", "Liz" };

            // Display the question and options
            DisplayQuestion(question, options);
        }

        private void DisplayQuestion2()
        {
            // Clear previous controls
            ClearControls();

            // Set up the second question
            string question = "Question 2: Quel est le plus grand océan du monde?";
            string[] options = { "Océan Pacifique", "Océan Atlantique", "Océan Indien" };

            // Display the question and options
            DisplayQuestion(question, options);
        }

        private void DisplayQuestion3()
        {
            // Clear previous controls
            ClearControls();

            // Set up the third question
            string question = "Question 3: Qui a écrit 'Le Petit Prince'?";
            string[] options = { "Antoine de Saint-Exupéry", "Victor Hugo", "Jules Verne" };

            // Display the question and options
            DisplayQuestion(question, options);
        }

        private void DisplayQuestion(string question, string[] options)
        {
            // Create and display the question label
            Label questionLabel = new Label();
            questionLabel.Text = question;
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(10, 10);
            Controls.Add(questionLabel);

            // Create and display the ComboBox for options
            ComboBox optionsComboBox = new ComboBox();
            optionsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            optionsComboBox.Items.AddRange(options);
            optionsComboBox.Location = new System.Drawing.Point(10, questionLabel.Bottom + 10);
            Controls.Add(optionsComboBox);
        }

        private void ClearControls()
        {
            // Remove all previous controls
            foreach (Control control in Controls)
            {
                control.Dispose();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check which question's ComboBox triggered the event
            if (((ComboBox)sender).Top < 100) // Adjust this value according to your form layout
            {
                // First question's ComboBox
                MessageBox.Show("First question's ComboBox selected: " + ((ComboBox)sender).SelectedItem);
                DisplayQuestion2(); // Move to the next question
            }
            else if (((ComboBox)sender).Top < 200) // Adjust this value according to your form layout
            {
                // Second question's ComboBox
                MessageBox.Show("Second question's ComboBox selected: " + ((ComboBox)sender).SelectedItem);
                DisplayQuestion3(); // Move to the next question
            }
            else
            {
                // Third question's ComboBox
                MessageBox.Show("Third question's ComboBox selected: " + ((ComboBox)sender).SelectedItem);
                MessageBox.Show("End of questions."); // No more questions
            }
        }
    }
}
