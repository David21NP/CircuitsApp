using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitsApp
{
    class AmpGain
    {
        public float Gain { get; set; }
        public float Rel { get; set; }

        public List<long> R1 { get; set; }
        public List<long> R2 { get; set; }

        public List<float> ErrAmp { get; set; }


        public AmpGain()
        {
            Gain = 1;
            Rel = 0;
            R1 = new List<long>();
            R2 = new List<long>();
            ErrAmp = new List<float>();
        }

        public AmpGain(float gain, float rel)
        {
            Gain = gain;
            Rel = rel;
            R1 = new List<long>();
            R2 = new List<long>();
            ErrAmp = new List<float>();
        }


        public void relAN()
        {
            Rel = (Gain - 1);
        }

        public void relAI()
        {
            if (Gain < 0)
                Rel = (Gain * (-1));
            else
                Rel = Gain;
        }

        public void relAR()
        {
            Rel = Gain;
        }

        public void findRes(float err, List<long> RCL)
        {
            float relRes;
            float aux;
            float errAct;

            foreach (long x in RCL)
            {
                foreach (long y in RCL)
                {
                    relRes = (Convert.ToSingle(y) / Convert.ToSingle(x));
                    aux = (Rel - relRes);
                    if (aux < 0)
                        aux *= -1;
                    errAct = ((aux / Rel) * 100);
                    if (errAct < err)
                    {
                        R1.Add(x);
                        R2.Add(y);
                        ErrAmp.Add(errAct);
                    }
                }
            }
        }

        public void findRg(float err, List<long> RCL)
        {
            float relRes;
            float aux;
            float errAct;
            relRes = (Convert.ToSingle(49400) / Convert.ToSingle(Gain - 1));

            foreach (long x in RCL)
            {
                aux = (relRes - Convert.ToSingle(x));
                if (aux < 0)
                    aux *= -1;
                errAct = ((aux / relRes) * 100);
                if (errAct < err)
                {
                    R1.Add(x);
                    ErrAmp.Add(errAct);
                }
            }
        }

        public void cleanL()
        {
            R1.Clear();
            R2.Clear();
            ErrAmp.Clear();
        }
    }
}
