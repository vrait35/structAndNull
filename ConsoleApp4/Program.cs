using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var result=HttpStatus.BadRequest;
            string statusResult = "BadRequest";
            HttpStatus httpStatus;
            if (Enum.TryParse(statusResult, out httpStatus))
            {
                //делаем что-то
            }
            Point point = new Point(1, 2, 3);
            PlainShape shape = null;
            shape = new PlainShape();
        }
    }
}
