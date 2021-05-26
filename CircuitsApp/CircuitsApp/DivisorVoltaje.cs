using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitsApp
{
    class DivisorVoltaje
    {
        public float Vcc { get; set; }
        public float Vee { get; set; }
        public float Vx { get; set; }
        public float Rel { get; set; }

        public List<long> R1 { get; set; }
        public List<long> R2 { get; set; }
        public List<long> R3 { get; set; }

        public List<float> ErrL { get; set; }

        
        public DivisorVoltaje()
        {
            Vcc = 0;
            Vee = 0;
            Vx = 1;
            Rel = 0;
            R1 = new List<long>();
            R2 = new List<long>();
            R3 = new List<long>();
            ErrL = new List<float>();
        }

        public DivisorVoltaje(float vcc, float vee, float vx, float rel)
        {
            Vcc = vcc;
            Vee = vee;
            Vx = vx;
            Rel = rel;
            R1 = new List<long>();
            R2 = new List<long>();
            R3 = new List<long>();
            ErrL = new List<float>();
        }


        public void calcRel()
        {
            Rel = (((Vcc - Vee) / (Vx - Vee)) - 1);
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
                    if (aux < 0) { aux *= -1; }
                    errAct = ((aux / Rel) * 100);
                    if (errAct < err)
                    {
                        R1.Add(y);
                        R2.Add(x);
                        ErrL.Add(errAct);
                    }
                }
            }
        }

        public void findRes3(float err, List<long> RCL)
        {
            float relRes;
            float aux;
            float errAct;

            foreach (long x in RCL)
            {
                foreach (long y in RCL)
                {
                    foreach (long z in RCL)
                    {
                        relRes = ((Convert.ToSingle(y) + Convert.ToSingle(z)) / Convert.ToSingle(x));
                        aux = (Rel - relRes);
                        if (aux < 0)
                            aux *= -1;
                        errAct = ((aux / Rel) * 100);
                        if (errAct < err)
                        {
                            R1.Add(z);
                            R2.Add(y);
                            R3.Add(x);
                            ErrL.Add(errAct);
                        }                                                
                    }
                }
            }
        }

        public void cleanL()
        {
            R1.Clear();
            R2.Clear();
            R3.Clear();
            ErrL.Clear();
        }
    }
}
