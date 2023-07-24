using EditingImagesWithUI.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using EditingImagesWithUI.entity;*/

namespace EditingImagesWithUI.methods
{
    public static class Calculation
    {
        public static double Calculate(int imagesAmount, List<double> crewRate)
        {
            double totalRate = 0;
            foreach (double personRate in crewRate)
            {
                totalRate += personRate;
            }
            return imagesAmount / totalRate;
        }
    }
}
