using EditingImagesWithUI.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EditingImagesWithUI.entity;

namespace EditingImagesWithUI.methods
{
    public static class Calculation
    {
        public static double Calculate(int imagesAmount, List<Person> crew)
        {
            double totalRate = 0;
            foreach (Person person in crew)
            {
                totalRate += person.Rate;
            }
            return imagesAmount / totalRate;
        }
    }
}
