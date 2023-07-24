using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EditingImagesWithUI;

namespace EditingImagesWithUI.errors
{
    class ErrorHandler
    {
        public int intErrorHandler(Control control)
        {
            int outcomeValue;

            if (!int.TryParse(control.Text, out outcomeValue) && control.Text != "")
            {
                new Error("Input the correct numeric value").ShowDialog();

                control.Text = string.Empty;
            }

            return outcomeValue;
        }

        public bool emptyValueErrorHandler(Control control)
        {
            if (control.Text == "")
            {
                new Error("Input values in empty spaces").ShowDialog();
                return false;
            }

            return true;
        }
    }
}
