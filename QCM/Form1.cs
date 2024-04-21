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
            DisplayQuestion1();
        }

        private void DisplayQuestion1()
        {
            ClearControls();

            string question = "Question 1: Allez, Cadeau! Quel était le prénom de Kate Winslet dans Titanic de James Cameron?";
            string[] options = { "Marge", "Rose", "Liz" };

            DisplayQuestion(question, options);
        }

        private void DisplayQuestion2()
        {
            ClearControls();

            string question = "Question 2: Quel est le plus grand océan du monde?";
            string[] options = { "Océan Pacifique", "Océan Atlantique", "Océan Indien" };

            DisplayQuestion(question, options);
        }

        private void DisplayQuestion3()
        {
            ClearControls();

            string question = "Question 3: Qui a écrit 'Le Petit Prince'?";
            string[] options = { "Antoine de Saint-Exupéry", "Victor Hugo", "Jules Verne" };

            DisplayQuestion(question, options);
        }

        private void DisplayQuestion(string question, string[] options)
        {
            Label questionLabel = new Label();
            questionLabel.Text = question;
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(10, 10);
            Controls.Add(questionLabel);

            ComboBox optionsComboBox = new ComboBox();
            optionsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            optionsComboBox.Items.AddRange(options);
            optionsComboBox.Location = new System.Drawing.Point(10, questionLabel.Bottom + 10);
            Controls.Add(optionsComboBox);
        }

        private void ClearControls()
        {
            foreach (Control control in Controls)
            {
                control.Dispose();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).Top < 100)
            {
                MessageBox.Show("First question's ComboBox selected: " + ((ComboBox)sender).SelectedItem);
                DisplayQuestion2();
            }
            else if (((ComboBox)sender).Top < 200)
            {
                MessageBox.Show("Second question's ComboBox selected: " + ((ComboBox)sender).SelectedItem);
                DisplayQuestion3();
            }
            else
            {
                MessageBox.Show("Third question's ComboBox selected: " + ((ComboBox)sender).SelectedItem);
                MessageBox.Show("End of questions."); // No more questions
            }
        }
    }
}
