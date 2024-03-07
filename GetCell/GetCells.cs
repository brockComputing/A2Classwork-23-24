using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetCells
{
    internal class GetCells
    {
        const int GridSize = 5;
        static void Main(string[] args)
        {
            do
            {

                Console.Write("Enter row number: ");
                int Row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter column number: ");
                int Column = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(GetCell(Row, Column).ToString());
            } while (true);
        }
        private static int GetCell(int Row, int Column)
        {
            return (GridSize - Row) * GridSize + Column - 1;
        }
    }
}
