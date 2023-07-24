using System.Windows.Forms;
using EditingImagesWithUI;
using EditingImagesWithUI.entity;
using EditingImagesWithUI.methods;
using EditingImagesWithUI.errors;

namespace EditingImagesWithUI
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        ErrorHandler errorHandler = new ErrorHandler();

        int imagesAmount;
        int crewSize;
        double totalTime;
        /*List<Person> crew = new List<Person>();*/


        private void imagesAmountInput_TextChanged(object sender, EventArgs e)
        {
            imagesAmount = errorHandler.intErrorHandler(imagesAmountInput);
        }

        private void crewSizeInput_TextChanged(object sender, EventArgs e)
        {
            crewSize = errorHandler.intErrorHandler(crewSizeInput);

            clearValues();

            // Create textboxes to specifie every person's rate
            for (int i = 0; i < crewSize; i++)
            {

                TextBox personRateInput = new TextBox();
                personRateInput.Size = new Size(140, 20);
                personRateInput.Location = new Point(160, 12 + i * 30);
                personRateInput.Name = "personRateInput" + i + 1;
                personRateInput.PlaceholderText = i + 1 + " person rate";
                Controls.Add(personRateInput);

                personRateInput.TextChanged += (sender, e) =>
                {
                    int personRate = errorHandler.intErrorHandler(personRateInput);                                  
                };
            }
        }

        private void calculateTime_Click(object sender, EventArgs e)
        {
            /*totalTime = Calculation.Calculate(imagesAmount, crew);

            totalTimeOutput.Text = totalTime.ToString();*/

            List<double> crewRate = new List<double>();
            bool noEmptyFields = true;

            foreach (var control in Controls.OfType<TextBox>().ToList())
            {
                noEmptyFields = errorHandler.emptyValueErrorHandler(control);

                if (!noEmptyFields) break;

                if (control.Name != imagesAmountInput.Name && control.Name != crewSizeInput.Name)
                {
                    crewRate.Add(1.0 / int.Parse(control.Text));
                }
            }
            if (noEmptyFields)
            {
                totalTime = Calculation.Calculate(imagesAmount, crewRate);
                totalTimeOutput.Text = totalTime.ToString();
            }
        }

        private void clearValues ()
        {
            // Clear previously created TextBoxes
            foreach (var control in Controls.OfType<TextBox>().ToList())
            {
                if (control.Name != imagesAmountInput.Name && control.Name != crewSizeInput.Name)
                {
                    Controls.Remove(control);
                    control.Dispose();

                    /*crew.Clear();*/
                }
            }
        }

        /*private int intErrorHandler(Control control)
        {
            int outcomeValue;

            if (!int.TryParse(control.Text, out outcomeValue) && control.Text != "")
            {
                new Error().ShowDialog();

                control.Text = string.Empty;
            }

            return outcomeValue;
        }*/

        /*private void emptyValueErrorHandler(Control control)
        {

        }*/
    }
}