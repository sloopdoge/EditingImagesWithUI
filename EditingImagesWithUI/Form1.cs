using System.Windows.Forms;
using EditingImagesWithUI;
using EditingImagesWithUI.entity;

namespace EditingImagesWithUI
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        int imagesAmount;
        int crewSize;
        double totalTime;
        List<Person> crew = new List<Person>();


        private void imagesAmountInput_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(imagesAmountInput.Text, out imagesAmount) && imagesAmountInput.Text != "")
            {
                new Error().ShowDialog();
            }
        }

        private void crewSizeInput_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(crewSizeInput.Text, out crewSize) && crewSizeInput.Text != "")
            {
                new Error().ShowDialog();
            }

            // Clear previously created TextBoxes
            foreach (var control in Controls.OfType<TextBox>().ToList())
            {
                if (control.Name != imagesAmountInput.Name && control.Name != crewSizeInput.Name)
                {
                    Controls.Remove(control);
                    control.Dispose();
                }
            }

            // Create textboxes to specifie every person's rate
            for (int i = 0; i < crewSize; i++)
            {

                TextBox personRateInput = new TextBox();
                personRateInput.Size = new Size(140, 20);
                personRateInput.Location = new Point(160, 12 + i * 30); // Adjust the location as needed
                personRateInput.PlaceholderText = i + 1 + " person rate";
                Controls.Add(personRateInput);

                personRateInput.TextChanged += (sender, e) =>
                {
                    int personRate = 0;

                    if (!int.TryParse(personRateInput.Text, out personRate) && personRateInput.Text != "")
                    {
                        new Error().ShowDialog();
                    }
                    crew.Add(new Person(1.0 / personRate));
                };
            }
        }

        private void calculateTime_Click(object sender, EventArgs e)
        {
            double totalRate = 0;
            foreach (Person person in crew)
            {
                totalRate += person.Rate;
            }
            totalTime = imagesAmount / totalRate;

            totalTimeOutput.Text = totalTime.ToString();
        }
    }
}