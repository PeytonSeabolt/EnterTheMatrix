//Peyton Seabolt

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaboltMatrix
{
    class Matrix<T>
    {
        int row;
        int column;
         private T[,] m;
        
        public Matrix(T[,] x)
        {
            m = x;
        }


        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            T[,] c = new T[a.m.GetLength(0),a.m.GetLength(1)];
            for(int i = 0; i < a.m.GetLength(0); i++)
            {
                for (int j = 0; j < a.m.GetLength(1); j++)
                {
                    c[i, j] = (dynamic)a.m[i, j] + (dynamic)b.m[i, j];
                }
            }
            return new Matrix<T>(c);
        } //Operator +

        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            T[,] c = new T[a.m.GetLength(0), a.m.GetLength(1)];
            for (int i = 0; i < a.m.GetLength(0); i++)
            {
                for (int j = 0; j < a.m.GetLength(1); j++)
                {
                    c[i, j] = (dynamic)a.m[i, j] - (dynamic)b.m[i, j];
                }
            }
            return new Matrix<T>(c);
        } //Operator -

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            T[,] c = new T[a.m.GetLength(0), a.m.GetLength(1)];
            for (int i = 0; i < a.m.GetLength(0); i++)
            {
                for (int j = 0; j < a.m.GetLength(1); j++)
                {
                    c[i, j] = (dynamic)a.m[i, j] * (dynamic)b.m[i, j];
                }
            }
            return new Matrix<T>(c);
        } //Operator *

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    s = s + m[i, j] + "\t"; //calling ToString integer method
                }
                s = s + "\n";
            }
            return s;
       } // ToString


        public T this[int i, int j]  //creates property of square braces
        {
            get { return m[i, j]; }
            set { m[i, j] = value; }
        }

           
    }
}
