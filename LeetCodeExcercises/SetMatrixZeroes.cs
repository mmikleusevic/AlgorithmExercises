﻿namespace LeetCodeExcercises
{
    public static class SetMatrixZeroes
    {
        public static void SetZeroes(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            bool rowZero = false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[0][j] = 0;
                        if (i > 0)
                        {
                            matrix[i][0] = 0;
                        }
                        else
                        {
                            rowZero = true;
                        }
                    }
                }
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[0][j] == 0 || matrix[i][0] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
            if (matrix[0][0] == 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    matrix[i][0] = 0;
                }
            }
            if (rowZero)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[0][j] = 0;
                }
            }
        }
    }
}
