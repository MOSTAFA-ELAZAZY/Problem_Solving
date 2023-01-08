using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Minimum_Number_of_Moves_to_Seat_Everyone
    {
        public int MinMovesToSeat(int[] seats, int[] students)
        {
            int Move = 0;
            Array.Sort(seats);
            Array.Sort(students);

            for (int i = 0; i < seats.Length; i++)
            {
                Move = Move + Math.Abs(seats[i] - students[i]);

            }


            return Move;

        }

    }
}
