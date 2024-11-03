using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class MatrixOperations
    { 
        public static int[,] AddMatrix(int[,] Matrix1,int[,] Matrix2)
        {
            int[,] result=new int[2,2];
            for(int i = 0;i<2;i++)
            {
                for(int j = 0;j<2;j++)
                {
                    result[i,j] = Matrix1[i, j] + Matrix2[i,j];
                }
            }
            return result;
        }
        public static int[,] MultiplyMatrices(int[,] Matrix1, int[,] Matrix2)
        {
            int[,] result = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = Matrix1[i, 0] * Matrix2[0, j]+ Matrix1[i, 1] * Matrix2[1, j];
                }
            }
            return result;
        }
    }

    
}


