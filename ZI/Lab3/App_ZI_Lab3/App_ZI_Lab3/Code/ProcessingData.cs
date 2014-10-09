using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace App_ZI_Lab3.Code
{
    class ProcessingData
    {

        long[] _standartMatrix;
        long[] _collectMatrix;
        long[] _resultMatrix;
        long[] _resultDeflectPercentMatrix;

        public ProcessingData(long[] standartMatrix, long[] collectMatrix)
        {

            if (standartMatrix.Length == collectMatrix.Length)
            {

                this._standartMatrix = standartMatrix;
                this._collectMatrix = collectMatrix;
                this._resultMatrix = new long[standartMatrix.Length];
                this._resultDeflectPercentMatrix = new long[standartMatrix.Length];
            }
            else
            {
                try
                {
                    throw new ArgumentException("Эталонная и собранная матрица имеют разный размер.");
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Эталонная и собранная матрица имеют разный размер.");
                }
            }
        }

        private void CalcResultMatrix()
        {

            for (int i = 0; i < _resultMatrix.Length; i++)
			{
			 
                _resultMatrix[i] = _standartMatrix[i] - _collectMatrix[i];
			}
        }

        private void CalcResultDeflectPercentMatrix()
        {

            for (int i = 0; i < _standartMatrix.Length; i++)
            {
                
                _resultDeflectPercentMatrix[i] = 
            }
        }


        //Реализовать метод возвращающий отклонения в процентах.

    }
}
