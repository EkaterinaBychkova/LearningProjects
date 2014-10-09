using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ZI_Lab3.Code
{
    class CollectData
    {

        List<TimeBetweenKey> _timePressKey;

        public CollectData()
        {

            _timePressKey = new List<TimeBetweenKey>();
        }

        public void AddTimePressKey(TimeBetweenKey tbk)
        {

            _timePressKey.Add(tbk);
        }

        public long[] GetMatrixTime()
        {

            long[] matrixTime = new long[_timePressKey.Count];

            for (int i = 0; i < matrixTime.Length; i++)
            {

                matrixTime[i] = _timePressKey[i].WatchTicks;
            }

            return matrixTime;
        }
    }
}
