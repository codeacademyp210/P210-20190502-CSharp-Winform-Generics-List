using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformProject
{
    class Student<T>
    {
        public T score;

        public void GetScore(T newScore, T index)
        {
            Type type = newScore.GetType();
            if (type.Name == "Int32")
            {
                int res = Convert.ToInt32(newScore) * Convert.ToInt32(index);
            }
            //return newScore * index;
        }
    }
}
