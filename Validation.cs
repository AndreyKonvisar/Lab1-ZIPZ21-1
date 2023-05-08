using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class Validation
    {
        private string error;
        private string sign;

        public Validation(string error, string sign = null)
        {
            this.error = error;
            this.sign = sign;
            switch (this.error)
            {
                case "signError": Console.Write($"Please, choose X or 0: ");break;

                case "numError": Console.Write($"There is no cell {this.sign} on the field: ");break;

                case "freeError": Console.Write($"This cell is already taken: "); break;

                case "finishError": Console.Write($"Please, choose y or n: "); break;

                default: break;
            }
        }


    }
}
