using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    static class CalculosMatrices
    {
        public static float[,] Suma(float[,] MatrizA, float[,] MatrizB)
        {
            float[,] matrizResultante = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];
            for (int x = 0; x < matrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultante.GetLength(1); y++)
                {
                    
                    matrizResultante[x, y] = MatrizA[x, y] + MatrizB[x, y];
                    
                }
            }
            return matrizResultante;
        }
        public static float[,] Resta(float[,] MatrizA, float[,] MatrizB)
        {
            float[,] matrizResultante = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];
            for (int x = 0; x < matrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultante.GetLength(1); y++)
                {
                    matrizResultante[x, y] = MatrizA[x, y] - MatrizB[x, y];
                }
            }
            return matrizResultante;
        }
        public static float[,] Multiplicacion(float[,] MatrizA, float[,] MatrizB, ListBox listBox)
        {
            float[,] matrizResultante = new float[MatrizA.GetLongLength(0), MatrizB.GetLength(1)];
            for(int x = 0; x < matrizResultante.GetLength(0); x++)
            {
                for(int y = 0; y < matrizResultante.GetLength(1); y++)
                {
                    for(int n = 0; n < MatrizB.GetLength(0); n++)
                    {
                        string i = "" + MatrizA[x, n];
                        matrizResultante[x, y] += MatrizA[x, n] * MatrizB[n, y];

                        listBox.Items.Add("A[" + (x + 1).ToString() + ", " + (n + 1).ToString() + "] • B[" + (n + 1).ToString() +
                            ", " + (y + 1).ToString() + "] = " + MatrizA[x, n].ToString() + " • " + MatrizB[n, y].ToString()
                            + " = " + (MatrizA[x, n] * MatrizB[n, y]).ToString());
                        if((n+1)%(MatrizA.GetLength(1))==0 && n!=0)
                        {
                            listBox.Items.Add("=> [" + (x + 1).ToString() + ", " + (y + 1).ToString() + "] = [" +
                                matrizResultante[x, y].ToString() + "]");
                        }
                    }

                }
            }
            return matrizResultante;
        }

        public static float[,] Transpuesta(float[,] matriz)
        {
            float[,] matrizTransposta = new float[matriz.GetLength(1), matriz.GetLength(0)];
            for (int x = 0; x < matrizTransposta.GetLength(0); x++)
            {
                for (int y = 0; y < matrizTransposta.GetLength(1); y++)
                {
                    matrizTransposta[x, y] += matriz[y, x];
                }
            }
            return matrizTransposta;
        }
    }
}
