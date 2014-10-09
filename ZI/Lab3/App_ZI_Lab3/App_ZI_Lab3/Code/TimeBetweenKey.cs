using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace App_ZI_Lab3.Code
{
    class TimeBetweenKey
    {

        long _watchTicks;
        Stopwatch _watch;

        public TimeBetweenKey()
        {

            _watchTicks = 0;
            _watch = new Stopwatch();
        }

        public long WatchTicks
        {

            get { return _watchTicks; }
        }

        public void StartCalcTicks()
        {

            _watch.Start();
        }

        public void StopCalcTicks()
        {

            _watch.Stop();
            _watchTicks = _watch.ElapsedTicks;
        }
    }
}
