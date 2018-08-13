using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thing_2._1
{
    static class Matrixes
    {
        public static void DivString(double[][] target, int number, double Tar)
        {
            for (int i = 0; i < target[0].Length; i++)
            {
                target[number][i] *= 1.0 / (Tar);
            }
        }

        public static  void SwapString(double[][] target, int number1, int number2)
        {
            double c;
            for (int i = 0; i < target[0].Length; i++)
            {
                c = target[number1][i];
                target[number1][i] = target[number2][i];
                target[number2][i] = c;
            }
        }

        public static void SubString(double[][] target, int number1, int number2, double Mult)
        {
            for (int i = 0; i < target[0].Length; i++)
            {
                target[number1][i] -= Mult * target[number2][i];
            }
        }

        public static double GetDet(double[][] target)
        {
            double[][] temp = new double[target.Length][];
            int i, j;
            for (i = 0; i < target.Length; i++)
            {
                temp[i] = new double[target.Length];
            }
            for (i = 0; i < target.Length; i++)
            {
                for (j = 0; j < target.Length; j++)
                {
                    temp[i][j] = target[i][j];
                }
            }
                //pryamoi hod
                for (i = 0; i < temp.Length; i++)
                {
                    if (temp[i][i] == 0)
                    {
                        j = i + 1;
                        for (; j < temp.Length; j++)
                        {
                            if (temp[j][i] != 0)
                            {
                                SwapString(temp, j, i);
                                break;
                            }
                        }
                        if (j == temp.Length)
                        {
                            return 0;
                        }
                    }
                    // DivString(temp, i, temp[i][i]);
                    for (j = i + 1; j < temp.Length; j++)
                    {
                        SubString(temp, j, i, temp[j][i] / temp[i][i]);
                    }
                }
            //obratnii
            for (i = temp.Length - 1; i >= 0; i--)
            {
                for (j = i - 1; j >= 0; j--)
                {
                    SubString(temp, j, i, temp[j][i] / temp[i][i]);
                }
            }
            double result = 1;
            for (i = 0; i < temp.Length; i++)
            {
                result *= temp[i][i];
            }
            return result;
        }

        public static double[,] Multiply(double[,] target1, double[,] target2, int Size1, int Size2, int Size3)
        {
            double sum = 0;
            double[,] result = new double[Size1, Size2];
            for (int i = 0; i < Size1; i++)
            {
                for (int j = 0; j < Size2; j++)
                {
                    for (int k = 0; k < Size3; k++)
                    {
                        sum += target1[i,k] * target2[k,j];
                    }
                    //result[i][j] = sum;
                    result[i,j] = sum;
                }
            }
            return result;
        }

        public static double[,] GetReverse(double[,] target, int Length)
        {
            double[][] matrix = new double[Length][];
            for (int i = 0; i < Length; i++)
            {
                matrix[i] = new double[2 * Length];
            }
                for (int i = 0; i < Length; i++)
                {
                    for (int j = 0; j < Length; j++)
                    {
                        matrix[i][j] = (target[i,j]);
                    }
                }
            for (int i = 0; i < Length; i++)
            {
                matrix[i][i + Length] = 1;
            }
            double[] x = new double[Length];
            //pryamoi hod
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][i] == 0)
                {
                    int j = i + 1;
                    for (; j < matrix.Length; j++)
                    {
                        if (matrix[j][i] != 0)
                        {
                            SwapString(matrix, j, i);
                            //apString(matrixres, j, i);
                            break;
                        }
                    }
                    if (j == matrix.Length)
                    {
                        return new double[0, 0];
                    }
                }
                //DivString(matrixres, i, matrix[i][i]);
                DivString(matrix, i, matrix[i][i]);
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    //SubString(matrixres, matrix, j, i, matrix[j][i]);
                    SubString(matrix, j, i, matrix[j][i]);
                }
            }
            //obratnii
            for (int i = matrix.Length - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    //SubString(matrixres, matrix, j, i, matrix[j][i]);
                    SubString(matrix, j, i, matrix[j][i]);
                }
            }

            double[,] result = new double[Length, Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    result[i,j] = Math.Round(matrix[i][j + matrix.Length], 5);
                }
            }
            return result;
        }

        public static double[,] GetTransp(double[,] target, int Length1, int Length2)
        {
            double[,] result = new double[Length2, Length1];
            int i, j;
            for (i = 0; i < Length1; i++)
            {
                for (j = 0; j < Length2; j++)
                {
                    result[j, i] = target[i, j];
                }
            }
            return result;
        }

        public static double[][] GetMinor(double[][] target, int n1, int n2)
        {
            double[][] result = new double[target.Length-1][];
            int i, j;
            for (i = 0; i < target.Length-1; i++)
            {
                result[i] = new double[target.Length-1];
            }
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    result[i][j] = target[i][j];
                }
                for (j = n2 + 1; j < target.Length; j++)
                {
                    result[i][j-1] = target[i][j];
                }
            }
            for (i = n1+1; i < target.Length; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    result[i-1][j] = target[i][j];
                }
                for (j = n2 + 1; j < target.Length; j++)
                {
                    result[i-1][j - 1] = target[i][j];
                }
            }
            return result;
        }
    }
}
