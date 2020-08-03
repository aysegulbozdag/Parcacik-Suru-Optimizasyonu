using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Parcacik_Suru_Optimizasyonu
{
    class Particle
    {
        private int low_limit = -5;
        private int top_limit = 5;
        private int d_swarm = 2;
        private int size_swarm = 10;
        public double[,] swarm;
        public static Random rnd = new Random();
        double[,] pbestpos;
        double[] pbestVal;
        double sbestVal;
        public double[] sbestPos;
        public int iteration = 5;

        public List<double> objList = new List<double>();

        public Particle(int low_limit, int top_limit, int size_swarm, int d_swarm, int iteration)
        {
            this.top_limit = top_limit;
            this.low_limit = low_limit;
            this.size_swarm = size_swarm;
            this.d_swarm = d_swarm;
            this.iteration = iteration;
            createSwarm(low_limit, top_limit, size_swarm, d_swarm);
            findVelocity();
        }

        //Sürü oluşturuldu.
        public void createSwarm(int low_limit, int top_limit, int size_swarm, int d_swarm)
        {
            swarm = new double[size_swarm, d_swarm];
            for (int i = 0; i < d_swarm; i++)
            {
                for (int j = 0; j < size_swarm; j++)
                {
                    swarm[j, i] = ((top_limit - low_limit) * rnd.NextDouble()) + low_limit;
                }

            }

            for (int i = 0; i < size_swarm; i++)
            {
                calculate(swarm[i, 0], swarm[i, 1]);
            }
        }

        //Amaç fonksiyon değeri
        public void calculate(double x1, double x2)
        {
            objList.Add(4 * Math.Pow(x1, 2) - 2.1 * Math.Pow(x1, 4) + (1 / 3) * Math.Pow(x1, 6) + x1 * x2 - 4 * Math.Pow(x2, 2) + 4 * Math.Pow(x2, 4));
        }


        public void findVelocity()
        {
            //Burada hız formülünde kullanılmak üzere parametreler hesaplandı.
            pbestpos = new double[d_swarm, size_swarm];
            sbestPos = new double[d_swarm];//gbest
            pbestVal = new double[objList.Count];
            pbestpos = swarm;
            // Array.Copy(swarm, pbestpos,0);
            for (int i = 0; i < objList.Count; i++)
            {
                pbestVal[i] = objList[i];
            }

            sbestVal = pbestVal.Min();
            int index = Array.IndexOf(pbestVal, sbestVal);
            //int index = objList.IndexOf(sbestVal);
            // sbestPos = Array.IndexOf(swarm, index);

            for (int i = 0; i < d_swarm; i++)
            {
                sbestPos[i] = swarm[index, i];
            }

            updateVelocity();
        }

        double[,] velocity;
        public double[,] newPosition;
        public double c1 = 2.0;
        public double c2 = 2.0;
        public int epoch = 0;
        public List<double> objListGbest = new List<double>();
        public void updateVelocity()
        {

            while (epoch < iteration)
            {
                objListGbest.Add(sbestVal);

                //Hızların tutulması için, bir dizi oluşturuldu.
                velocity = new double[size_swarm, d_swarm];

                double w = 0.0;
                double r1, r2;
                double vmax = (top_limit - low_limit) / 2;

                //Hız formülü ile hızlar bulundu.
                for (int i = 0; i < size_swarm; i++)
                {
                    r1 = rnd.NextDouble();
                    r2 = rnd.NextDouble();
                    for (int j = 0; j < d_swarm; j++)
                    {
                        velocity[i, j] = (w * velocity[i, j]) + (c1 * r1 * (pbestpos[i, j] - swarm[i, j]))
                            + (c2 * r2 * (sbestPos[j] - swarm[i, j]));
                    }
                }
                //Hız değerleri vmax dan büyük ise vmax'a eşitlendi. Küçükse -vmax'a eşitlendi.
                for (int i = 0; i < size_swarm; i++)
                {
                    for (int j = 0; j < d_swarm; j++)
                    {
                        if (velocity[i, j] > vmax)
                        {
                            velocity[i, j] = vmax;
                        }

                        else if (velocity[i, j] < -vmax)
                        {
                            velocity[i, j] = -vmax;
                        }
                    }
                }

                //Yeni pozisyon bulma
                newPosition = new double[size_swarm, d_swarm];
                for (int i = 0; i < size_swarm; i++)
                {
                    for (int j = 0; j < d_swarm; j++)
                    {
                        newPosition[i, j] = swarm[i, j] + velocity[i, j];
                    }
                }
                //Bulunan pozisyonlar alt ve üst sınır dışındaysa bu değeri alt ve üst sınıra eşitleme
                for (int i = 0; i < size_swarm; i++)
                {
                    for (int j = 0; j < d_swarm; j++)
                    {
                        if (newPosition[i, j] > top_limit)
                        {
                            newPosition[i, j] = top_limit;
                        }

                        else if (newPosition[i, j] < low_limit)
                        {
                            newPosition[i, j] = low_limit;
                        }
                    }
                }

                objList.Clear();
                for (int i = 0; i < size_swarm; i++)
                {
                    calculate(newPosition[i, 0], newPosition[i, 1]);
                }

                //Parçacık en iyisi güncelleme

                for (int i = 0; i < size_swarm; i++)
                {

                    if (objList[i] < pbestVal[i])
                    {
                        pbestVal[i] = objList[i];
                        pbestpos = newPosition;
                    }

                }

                //Sürünün en iyisini güncelle
                for (int i = 0; i < size_swarm; i++)
                {
                    if (objList.Min() < sbestVal)
                    {
                        sbestVal = objList.Min();
                        int index = Array.IndexOf(pbestVal, sbestVal);
                        sbestPos[i] = newPosition[index, i];
                    }
                }
                // objListGbest.Add(sbestVal);

                epoch += 1;

            }
        }


    }
}
