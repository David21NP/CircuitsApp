using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircuitsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resizeAll();
            //MessageBox.Show("Usar coma( , ) para decimales.", "Advertencia", MessageBoxButtons.OK);
        }

        List<long> RCLF = new List<long> { 10, 12, 15, 18, 20, 22, 24, 27, 30, 33, 39, 47, 51, 56, 62, 68, 75, 82, 91, 100, 120, 130, 150, 180, 200, 220, 240, 270, 300, 330, 390, 470, 510, 560, 620, 680, 750, 820, 910, 1000, 1200, 1500, 1600, 1800, 2000, 2200, 2400, 2700, 3000, 3300, 3600, 3900, 4300, 4700, 5100, 5600, 6200, 6800, 7500, 8200, 9100, 10000, 12000, 15000, 18000, 20000, 22000, 24000, 27000, 30000, 33000, 39000, 47000, 51000, 56000, 62000, 68000, 82000, 100000, 120000, 150000, 160000, 180000, 200000, 220000, 240000, 270000, 300000, 330000, 360000, 390000, 470000, 510000, 560000, 680000, 750000, 820000, 1000000, 1200000, 1500000, 1800000, 2000000, 2200000, 2400000, 2700000, 3000000, 3300000, 3900000, 4700000, 5600000, 6800000, 7500000, 8200000 };

        public float findVx(float vcc, float vee, float r1, float r2) { return ((((vcc - vee) * r2) / (r1 + r2)) + vee); }
        public float findI(float vcc, float vee, float r1, float r2) { return ((vcc - vee) / (r1 + r2)); }

        public float findVx3(float vcc, float vee, float r1, float r2, float r3) { return ((((vcc - vee) * r3) / (r1 + r2 + r3)) + vee); }
        public float findI3(float vcc, float vee, float r1, float r2, float r3) { return ((vcc - vee) / (r1 + r2 + r3)); }

        public float gainN(float r1, float r2) { return ((r2 / r1) + 1); }

        public float gainInv(float r1, float r2) { return (r2 / r1); }

        public float gainIns(float rg) { return ((49400 / rg) + 1); }

        public void resizeAll()
        {
            panel2.Top = this.Height - 85;

            tabControl1.Width = this.Width - 15;
            tabControl1.Height = this.Height - 110;

            tabControl2.Width = tabControl1.Width - 20;
            tabControl2.Height = tabControl1.Height - 40;

            tabControl3.Width = tabControl1.Width - 20;
            tabControl3.Height = tabControl1.Height - 40;

            tabControl4.Width = tabControl1.Width - 20;
            tabControl4.Height = tabControl1.Height - 40;

            tabControl5.Width = tabControl1.Width - 20;
            tabControl5.Height = tabControl1.Height - 40;

            tabControl6.Width = tabControl1.Width - 20;
            tabControl6.Height = tabControl1.Height - 40;

            tabControl13.Width = tabControl1.Width - 20;
            tabControl13.Height = tabControl1.Height - 40;


            tabControl7.Width = tabControl2.Width - 20;
            tabControl7.Height = tabControl2.Height - 40;

            tabControl8.Width = tabControl2.Width - 20;
            tabControl8.Height = tabControl2.Height - 40;

            tabControl9.Width = tabControl2.Width - 20;
            tabControl9.Height = tabControl2.Height - 40;


            tabControl10.Width = tabControl3.Width - 20;
            tabControl10.Height = tabControl3.Height - 40;

            tabControl11.Width = tabControl3.Width - 20;
            tabControl11.Height = tabControl3.Height - 40;

            tabControl12.Width = tabControl3.Width - 20;
            tabControl12.Height = tabControl3.Height - 40;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalc22_Click(object sender, EventArgs e)
        {
            float vx;
            if (!string.IsNullOrEmpty(Vcc2x2.Text))
            {
                if (!string.IsNullOrEmpty(Vee2x2.Text))
                {
                    if (!string.IsNullOrEmpty(R12x2.Text))
                    {
                        if (!string.IsNullOrEmpty(R22x2.Text))
                        {
                            vx = findVx((float.Parse(Vcc2x2.Text)), (float.Parse(Vee2x2.Text)), (float.Parse(R12x2.Text)), (float.Parse(R22x2.Text)));
                            MessageBox.Show("Vx es : " + (vx.ToString()), "Respuesta", MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Falta llenar el campo de R2.", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Falta llenar el campo de R1.", "ERROR", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Falta llenar el campo de VEE.", "ERROR", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de VCC.", "ERROR", MessageBoxButtons.OK);

        }

        private void BtnCalc21_Click(object sender, EventArgs e)
        {
            float vx;
            if (!string.IsNullOrEmpty(Vcc2x1.Text))
            {
                if (!string.IsNullOrEmpty(R12x1.Text))
                {
                    if (!string.IsNullOrEmpty(R22x1.Text))
                    {
                        vx = findVx((float.Parse(Vcc2x1.Text)), 0, (float.Parse(R12x1.Text)), (float.Parse(R22x1.Text)));
                        MessageBox.Show("Vx es : " + (vx.ToString()), "Respuesta", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Falta llenar el campo de R2.", "ERROR", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Falta llenar el campo de R1.", "ERROR", MessageBoxButtons.OK);    
            }
            else
                MessageBox.Show("Falta llenar el campo de VCC.", "ERROR", MessageBoxButtons.OK);
        }

        private void Btn3x2_Click(object sender, EventArgs e)
        {
            float vx;
            if (!string.IsNullOrEmpty(Vcc3x2.Text))
            {
                if (!string.IsNullOrEmpty(Vee3x2.Text))
                {
                    if (!string.IsNullOrEmpty(R13x2.Text))
                    {
                        if (!string.IsNullOrEmpty(R23x2.Text))
                        {
                            if (!string.IsNullOrEmpty(R33x2.Text))
                            {
                                vx = findVx3((float.Parse(Vcc3x2.Text)), (float.Parse(Vee3x2.Text)), (float.Parse(R13x2.Text)), (float.Parse(R23x2.Text)), (float.Parse(R33x2.Text)));
                                MessageBox.Show("Vx es : " + (vx.ToString()), "Respuesta", MessageBoxButtons.OK);
                            }
                            else
                                MessageBox.Show("Falta llenar el campo de R3.", "ERROR", MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Falta llenar el campo de R2.", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Falta llenar el campo de R1.", "ERROR", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Falta llenar el campo de VEE.", "ERROR", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de VCC.", "ERROR", MessageBoxButtons.OK);
        }

        private void BtnCalc3x1_Click(object sender, EventArgs e)
        {
            float vx;
            if (!string.IsNullOrEmpty(Vcc3x1.Text))
            {
                if (!string.IsNullOrEmpty(R13x1.Text))
                {
                    if (!string.IsNullOrEmpty(R23x1.Text))
                    {
                        if (!string.IsNullOrEmpty(R33x1.Text))
                        {
                            vx = findVx3((float.Parse(Vcc3x1.Text)), 0, (float.Parse(R13x1.Text)), (float.Parse(R23x1.Text)), (float.Parse(R33x1.Text)));
                            MessageBox.Show("Vx es : " + (vx.ToString()), "Respuesta", MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Falta llenar el campo de R3.", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Falta llenar el campo de R2.", "ERROR", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Falta llenar el campo de R1.", "ERROR", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de VCC.", "ERROR", MessageBoxButtons.OK);
        }

        private void BtnCalc2r2_Click(object sender, EventArgs e)
        {
            DivisorVoltaje DivVolt2 = new DivisorVoltaje();
            int a = 0;
            string pass;

            if (!string.IsNullOrEmpty(AllowErr.Text))
            {
                if (!string.IsNullOrEmpty(Vcc2r2.Text))
                {
                    if (!string.IsNullOrEmpty(Vee2r2.Text))
                    {
                        if (!string.IsNullOrEmpty(Vx2r.Text))
                        {
                            DivVolt2.Vcc = float.Parse(Vcc2r2.Text);
                            DivVolt2.Vee = float.Parse(Vee2r2.Text);
                            DivVolt2.Vx = float.Parse(Vx2r.Text);
                            if (DivVolt2.Vx > (DivVolt2.Vcc - DivVolt2.Vee))
                            {
                                MessageBox.Show("Vx no puede ser mayor que las fuentes.", "Error", MessageBoxButtons.OK);
                            }
                            else
                            {
                                DivVolt2.calcRel();
                                DivVolt2.findRes((float.Parse(AllowErr.Text)), RCLF);

                                a = DivVolt2.ErrL.IndexOf(DivVolt2.ErrL.Min());

                                pass = "El Resultado con menor error fue \nR1 = " + DivVolt2.R1[a].ToString() + "\nR2 = " + DivVolt2.R2[a].ToString() + "\nCon un error del : " + DivVolt2.ErrL[a].ToString() + "%";

                                FormLista fls = new FormLista(DivVolt2.R1, DivVolt2.R2, DivVolt2.ErrL, pass);
                                fls.Show();
                            }
                        }
                        else
                            MessageBox.Show("Falta llenar el campo Vx", "Error", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Falta llenar el campo Vee", "Error", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Falta llenar el campo Vcc", "Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de Error", "Error", MessageBoxButtons.OK);

            DivVolt2.cleanL();
        }

        private void BtnCalc2r1_Click(object sender, EventArgs e)
        {
            DivisorVoltaje DivVolt21 = new DivisorVoltaje();
            int a = 0;
            string pass;

            if (!string.IsNullOrEmpty(AllowErr.Text))
            {
                if (!string.IsNullOrEmpty(Vcc2r1.Text))
                {
                    if (!string.IsNullOrEmpty(Vx2r1.Text))
                    {
                        DivVolt21.Vcc = float.Parse(Vcc2r1.Text);
                        DivVolt21.Vee = 0;
                        DivVolt21.Vx = float.Parse(Vx2r1.Text);
                        if (DivVolt21.Vx > (DivVolt21.Vcc - DivVolt21.Vee))
                        {
                            MessageBox.Show("Vx no puede ser mayor que las fuentes.", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            DivVolt21.calcRel();
                            DivVolt21.findRes((float.Parse(AllowErr.Text)), RCLF);

                            a = DivVolt21.ErrL.IndexOf(DivVolt21.ErrL.Min());

                            pass = "El Resultado con menor error fue \nR1 = " + DivVolt21.R1[a].ToString() + "\nR2 = " + DivVolt21.R2[a].ToString() + "\nCon un error del : " + DivVolt21.ErrL[a].ToString() + "%";

                            FormLista fls = new FormLista(DivVolt21.R1, DivVolt21.R2, DivVolt21.ErrL, pass);
                            fls.Show();
                        }
                    }
                    else
                        MessageBox.Show("Falta llenar el campo Vx", "Error", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Falta llenar el campo Vcc", "Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de Error", "Error", MessageBoxButtons.OK);

            DivVolt21.cleanL();
        }

        private void BtnCalc3r2_Click(object sender, EventArgs e)
        {
            DivisorVoltaje DivVolt32 = new DivisorVoltaje();
            int a = 0;
            string pass;

            if (!string.IsNullOrEmpty(AllowErr.Text))
            {
                if (!string.IsNullOrEmpty(Vcc3r2.Text))
                {
                    if (!string.IsNullOrEmpty(Vee3r2.Text))
                    {
                        if (!string.IsNullOrEmpty(Vx3r2.Text))
                        {
                            DivVolt32.Vcc = float.Parse(Vcc3r2.Text);
                            DivVolt32.Vee = float.Parse(Vee3r2.Text);
                            DivVolt32.Vx = float.Parse(Vx3r2.Text);
                            if (DivVolt32.Vx > (DivVolt32.Vcc - DivVolt32.Vee))
                            {
                                MessageBox.Show("Vx no puede ser mayor que las fuentes.", "Error", MessageBoxButtons.OK);
                            }
                            else
                            {
                                DivVolt32.calcRel();
                                DivVolt32.findRes3((float.Parse(AllowErr.Text)), RCLF);

                                a = DivVolt32.ErrL.IndexOf(DivVolt32.ErrL.Min());

                                pass = "El Resultado con menor error fue \nR1 = " + DivVolt32.R1[a].ToString() + "\nR2 = " + DivVolt32.R2[a].ToString() + "\nR3 = " + DivVolt32.R3[a].ToString() + "\nCon un error del : " + DivVolt32.ErrL[a].ToString() + "%";

                                FormLista3 fls = new FormLista3(DivVolt32.R1, DivVolt32.R2, DivVolt32.R3, DivVolt32.ErrL, pass);
                                fls.Show();
                            }
                        }
                        else
                            MessageBox.Show("Falta llenar el campo Vx", "Error", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Falta llenar el campo Vee", "Error", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Falta llenar el campo Vcc", "Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de Error", "Error", MessageBoxButtons.OK);

            DivVolt32.cleanL();
        }

        private void BtnCalc3r1_Click(object sender, EventArgs e)
        {
            DivisorVoltaje DivVolt31 = new DivisorVoltaje();
            int a = 0;
            string pass;

            if (!string.IsNullOrEmpty(AllowErr.Text))
            {
                if (!string.IsNullOrEmpty(Vcc3r1.Text))
                {
                    if (!string.IsNullOrEmpty(Vx3r1.Text))
                    {
                        DivVolt31.Vcc = float.Parse(Vcc3r1.Text);
                        DivVolt31.Vee = 0;
                        DivVolt31.Vx = float.Parse(Vx3r1.Text);
                        if (DivVolt31.Vx > (DivVolt31.Vcc - DivVolt31.Vee))
                        {
                            MessageBox.Show("Vx no puede ser mayor que las fuentes.", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            DivVolt31.calcRel();
                            DivVolt31.findRes3((float.Parse(AllowErr.Text)), RCLF);

                            a = DivVolt31.ErrL.IndexOf(DivVolt31.ErrL.Min());

                            pass = "El Resultado con menor error fue \nR1 = " + DivVolt31.R1[a].ToString() + "\nR2 = " + DivVolt31.R2[a].ToString() + "\nR3 = " + DivVolt31.R3[a].ToString() + "\nCon un error del : " + DivVolt31.ErrL[a].ToString() + "%";

                            FormLista3 fls = new FormLista3(DivVolt31.R1, DivVolt31.R2, DivVolt31.R3, DivVolt31.ErrL, pass);
                            fls.Show();
                        }
                    }
                    else
                        MessageBox.Show("Falta llenar el campo Vx", "Error", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Falta llenar el campo Vcc", "Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de Error", "Error", MessageBoxButtons.OK);

            DivVolt31.cleanL();
        }

        private void BtnCalcAN_Click(object sender, EventArgs e)
        {
            AmpGain AmpNo = new AmpGain();
            int a = 0;
            string pass;

            if (!string.IsNullOrEmpty(AllowErr.Text))
            {
                if (!string.IsNullOrEmpty(GainAN.Text))
                {
                    AmpNo.Gain = float.Parse(GainAN.Text);
                    if (AmpNo.Gain <= 1)
                    {
                        if (AmpNo.Gain <1)
                            MessageBox.Show("La ganacia para este caso no puede ser menor a 1", "Error", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("Para ganacia igual 1 hacer circuito segidor de voltaje.\nEs decir sin R1 y R2 = 0", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        AmpNo.relAN();
                        AmpNo.findRes((float.Parse(AllowErr.Text)), RCLF);

                        a = AmpNo.ErrAmp.IndexOf(AmpNo.ErrAmp.Min());

                        pass = "El resultado con menor error fue \nR1 = " + AmpNo.R1[a].ToString() + "\nR2 = " + AmpNo.R2[a].ToString() + "\nCon un error del : " + AmpNo.ErrAmp[a].ToString() + "%";

                        FormLista fls = new FormLista(AmpNo.R1, AmpNo.R2, AmpNo.ErrAmp, pass);
                        fls.Show();
                    }
                }
                else
                    MessageBox.Show("Falta llenar el campo de Ganacia", "Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de Error", "Error", MessageBoxButtons.OK);

            AmpNo.cleanL();
        }

        private void BtnCalcANR_Click(object sender, EventArgs e)
        {
            float gain;
            if (!string.IsNullOrEmpty(R1AN.Text))
            {
                if (!string.IsNullOrEmpty(R2AN.Text))
                {
                    gain = gainN((float.Parse(R1AN.Text)), (float.Parse(R2AN.Text)));
                    MessageBox.Show("La ganancia es : " + gain.ToString(), "Respuesta", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Falta llenar el campo de R2", "Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de R1", "Error", MessageBoxButtons.OK);
        }

        private void BtnCalcAIG_Click(object sender, EventArgs e)
        {
            AmpGain AmpInv = new AmpGain();
            int a = 0;
            string pass;

            if (!string.IsNullOrEmpty(AllowErr.Text))
            {
                if (!string.IsNullOrEmpty(GainAI.Text))
                {
                    AmpInv.Gain = float.Parse(GainAI.Text);
                    AmpInv.relAI();
                    AmpInv.findRes((float.Parse(AllowErr.Text)), RCLF);

                    a = AmpInv.ErrAmp.IndexOf(AmpInv.ErrAmp.Min());

                    pass = "El resultado con menor error fue \nR1 = " + AmpInv.R1[a].ToString() + "\nR2 = " + AmpInv.R2[a].ToString() + "\nCon un error del : " + AmpInv.ErrAmp[a].ToString() + "%";

                    FormLista fls = new FormLista(AmpInv.R1, AmpInv.R2, AmpInv.ErrAmp, pass);
                    fls.Show();
                }
                else
                    MessageBox.Show("Falta llenar el campo de Ganacia", "Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de Error", "Error", MessageBoxButtons.OK);

            AmpInv.cleanL();
        }

        private void BtnCalcAI_Click(object sender, EventArgs e)
        {
            float gain;
            if (!string.IsNullOrEmpty(R1AI.Text))
            {
                if (!string.IsNullOrEmpty(R2AI.Text))
                {
                    gain = gainInv((float.Parse(R1AI.Text)), (float.Parse(R2AI.Text)));
                    MessageBox.Show("La ganancia es : " + gain.ToString(), "Respuesta", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Falta llenar el campo de R2", "Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de R1", "Error", MessageBoxButtons.OK);
        }

        private void BTnCalcAR_Click(object sender, EventArgs e)
        {
            AmpGain AmpRes = new AmpGain();
            int a = 0;
            string pass;

            if (!string.IsNullOrEmpty(AllowErr.Text))
            {
                if (!string.IsNullOrEmpty(GainAR.Text))
                {
                    AmpRes.Gain = float.Parse(GainAR.Text);
                    AmpRes.relAR();
                    AmpRes.findRes((float.Parse(AllowErr.Text)), RCLF);

                    a = AmpRes.ErrAmp.IndexOf(AmpRes.ErrAmp.Min());

                    pass = "El resultado con menor error fue \nR1 = " + AmpRes.R1[a].ToString() + "\nR2 = " + AmpRes.R2[a].ToString() + "\nCon un error del : " + AmpRes.ErrAmp[a].ToString() + "%";

                    FormLista fls = new FormLista(AmpRes.R1, AmpRes.R2, AmpRes.ErrAmp, pass);
                    fls.Show();
                }
                else
                    MessageBox.Show("Falta llenar el campo de Ganacia", "Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de Error", "Error", MessageBoxButtons.OK);

            AmpRes.cleanL();
        }

        private void BtnCalc2i2_Click(object sender, EventArgs e)
        {
            float current;
            if (!string.IsNullOrEmpty(Vcc2i2.Text))
            {
                if (!string.IsNullOrEmpty(Vee2i2.Text))
                {
                    if (!string.IsNullOrEmpty(R12i2.Text))
                    {
                        if (!string.IsNullOrEmpty(R22i2.Text))
                        {
                            current = findI((float.Parse(Vcc2i2.Text)), (float.Parse(Vee2i2.Text)), (float.Parse(R12i2.Text)), (float.Parse(R22i2.Text)));
                            MessageBox.Show("La corriente es : " + (current.ToString()), "Respuesta", MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Falta llenar el campo de R2.", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Falta llenar el campo de R1.", "ERROR", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Falta llenar el campo de VEE.", "ERROR", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de VCC.", "ERROR", MessageBoxButtons.OK);
        }

        private void BtnCalc2i1_Click(object sender, EventArgs e)
        {
            float current;
            if (!string.IsNullOrEmpty(Vcc2i2.Text))
            {
                if (!string.IsNullOrEmpty(R12i2.Text))
                {
                    if (!string.IsNullOrEmpty(R22i2.Text))
                    {
                        current = findI((float.Parse(Vcc2i2.Text)), 0, (float.Parse(R12i2.Text)), (float.Parse(R22i2.Text)));
                        MessageBox.Show("La corriente es : " + (current.ToString()), "Respuesta", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Falta llenar el campo de R2.", "ERROR", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Falta llenar el campo de R1.", "ERROR", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de VCC.", "ERROR", MessageBoxButtons.OK);
        }

        private void BtnCalc3i2_Click(object sender, EventArgs e)
        {
            float current;
            if (!string.IsNullOrEmpty(Vcc3i2.Text))
            {
                if (!string.IsNullOrEmpty(Vee3i2.Text))
                {
                    if (!string.IsNullOrEmpty(R13i2.Text))
                    {
                        if (!string.IsNullOrEmpty(R23i2.Text))
                        {
                            if (!string.IsNullOrEmpty(R33i2.Text))
                            {
                                current = findI3((float.Parse(Vcc3i2.Text)), (float.Parse(Vee3i2.Text)), (float.Parse(R13i2.Text)), (float.Parse(R23i2.Text)), (float.Parse(R33i2.Text)));
                                MessageBox.Show("La corriente es : " + (current.ToString()), "Respuesta", MessageBoxButtons.OK);
                            }
                            else
                                MessageBox.Show("Falta llenar el campo de R3.", "ERROR", MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Falta llenar el campo de R2.", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Falta llenar el campo de R1.", "ERROR", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Falta llenar el campo de VEE.", "ERROR", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de VCC.", "ERROR", MessageBoxButtons.OK);
        }

        private void BtnCalc3i1_Click(object sender, EventArgs e)
        {
            float current;
            if (!string.IsNullOrEmpty(Vcc3i2.Text))
            {
                if (!string.IsNullOrEmpty(R13i2.Text))
                {
                    if (!string.IsNullOrEmpty(R23i2.Text))
                    {
                        if (!string.IsNullOrEmpty(R33i2.Text))
                        {
                            current = findI3((float.Parse(Vcc3i2.Text)), 0, (float.Parse(R13i2.Text)), (float.Parse(R23i2.Text)), (float.Parse(R33i2.Text)));
                            MessageBox.Show("La corriente es : " + (current.ToString()), "Respuesta", MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Falta llenar el campo de R3.", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Falta llenar el campo de R2.", "ERROR", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Falta llenar el campo de R1.", "ERROR", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de VCC.", "ERROR", MessageBoxButtons.OK);
        }

        private void BtnCalcInsr_Click(object sender, EventArgs e)
        {
            AmpGain AmpInst = new AmpGain();
            int a = 0;

            if (!string.IsNullOrEmpty(AllowErr.Text))
            {
                if (!string.IsNullOrEmpty(GainIns1.Text))
                {
                    AmpInst.Gain = float.Parse(GainIns1.Text);

                    AmpInst.findRg((float.Parse(AllowErr.Text)), RCLF);

                    a = AmpInst.ErrAmp.IndexOf(AmpInst.ErrAmp.Min());

                    MessageBox.Show("El resultado con menor error fue \nR1 = " + AmpInst.R1[a].ToString() + "\nCon un error del : " + AmpInst.ErrAmp[a].ToString(), "Mejor resultado", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Falta llenar el campo de Ganacia", "Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de Error", "Error", MessageBoxButtons.OK);
        }

        private void BtnCalcInsg_Click(object sender, EventArgs e)
        {
            float Gain;
            if (!string.IsNullOrEmpty(RgIns.Text))
            {
                if (float.Parse(RgIns.Text) != 0)
                {
                    Gain = gainIns(float.Parse(RgIns.Text));
                    MessageBox.Show("La ganancia es : " + (Gain.ToString()), "Respuesta", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Rg debe ser diferente de 0", "Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Falta llenar el campo de Rg", "Error", MessageBoxButtons.OK);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeAll();
        }
    }
}
