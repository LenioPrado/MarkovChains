using Common.Model;
using Microsoft.ML.Probabilistic.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarkovChains.Inferencia
{
    public class ExecutorInferencia
    {
        public static void RunCyclingTime2()
        {
            double[] trainingData = new double[] {21,8,20,4,4,1,10,8,8,4 };
            
            ModelData initPriors = new ModelData(
                Gaussian.FromMeanAndPrecision(1.0, 0.01),
                Gamma.FromShapeAndScale(2.0, 0.5));

            // Train the model
            CyclistTraining cyclistTraining = new CyclistTraining();
            cyclistTraining.CreateModel();
            cyclistTraining.SetModelData(initPriors);

            ModelData posteriors1 = cyclistTraining.InferModelData(trainingData);
            Console.WriteLine("Average travel time = " + posteriors1.AverageTimeDist);
            Console.WriteLine("Traffic noise = " + posteriors1.TrafficNoiseDist);

            // Make predictions based on the trained model
            CyclistPrediction cyclistPrediction = new CyclistPrediction();
            cyclistPrediction.CreateModel();
            cyclistPrediction.SetModelData(posteriors1);

            Gaussian tomorrowsTimeDist = cyclistPrediction.InferTomorrowsTime();

            double tomorrowsMean = tomorrowsTimeDist.GetMean();
            double tomorrowsStdDev = Math.Sqrt(tomorrowsTimeDist.GetVariance());

            Console.WriteLine("Tomorrows average time: {0:f2}", tomorrowsMean);
            Console.WriteLine("Tomorrows standard deviation: {0:f2}", tomorrowsStdDev);
            Console.WriteLine("Probability that tomorrow's time is < 18 min: {0}",
                              cyclistPrediction.InferProbabilityTimeLessThan(18.0));
            
            // Second round of training
            double[] trainingData2 = new double[] { 18,5,27,37,15 };

            cyclistTraining.SetModelData(posteriors1);
            ModelData posteriors2 = cyclistTraining.InferModelData(trainingData2);

            Console.WriteLine("\n2nd training pass");
            Console.WriteLine("Average travel time = " + posteriors2.AverageTimeDist);
            Console.WriteLine("Traffic noise = " + posteriors2.TrafficNoiseDist);

            // Predictions based on two rounds of training
            cyclistPrediction.SetModelData(posteriors2);

            tomorrowsTimeDist = cyclistPrediction.InferTomorrowsTime();
            tomorrowsMean = tomorrowsTimeDist.GetMean();
            tomorrowsStdDev = Math.Sqrt(tomorrowsTimeDist.GetVariance());

            Console.WriteLine("Tomorrows average time: {0:f2}", tomorrowsMean);
            Console.WriteLine("Tomorrows standard deviation: {0:f2}", tomorrowsStdDev);
            Console.WriteLine("Probability that tomorrow's time is < 18 min: {0}",
                              cyclistPrediction.InferProbabilityTimeLessThan(18));
        }

        private static double[] ObterDadosTreinamento(IList<Estados> estadosUG, int inicio, int quantidade)
        {
            double[] treinamento = estadosUG.Skip(inicio).Take(quantidade).Select(estado => estado.Duracao.Value.TotalMinutes).ToArray();

            for (int index = 0; index < treinamento.Length; index++)
            {
                treinamento[index] = Math.Round(treinamento[index], 0);
            }

            return treinamento;
        }

        public static void RodarInferencia(IEnumerable<DadosUG> dadosUGs)
        {
            var ug1 = dadosUGs.FirstOrDefault(c => c.UG.Equals("CF1-01"));

            ModelData initPriors = new ModelData(
                Gaussian.FromMeanAndPrecision(1.0, 0.01),
                Gamma.FromShapeAndScale(2.0, 0.5));

            // Train the model
            CyclistTraining cyclistTraining = new CyclistTraining();
            cyclistTraining.CreateModel();
            cyclistTraining.SetModelData(initPriors);

            //new double[] { 13, 17, 16, 12, 13, 12, 14, 18, 16, 16 };
            double[] trainingData = ObterDadosTreinamento(ug1.Estados, 1, 10);
            Console.WriteLine($"Dados para treinamento: {string.Join(" | ", trainingData)}");

            ModelData posteriors1 = cyclistTraining.InferModelData(trainingData);
            Console.WriteLine("Average travel time = " + posteriors1.AverageTimeDist);
            Console.WriteLine("Traffic noise = " + posteriors1.TrafficNoiseDist);

            // Make predictions based on the trained model
            CyclistPrediction cyclistPrediction = new CyclistPrediction();
            cyclistPrediction.CreateModel();
            cyclistPrediction.SetModelData(posteriors1);

            Gaussian tomorrowsTimeDist = cyclistPrediction.InferTomorrowsTime();

            double tomorrowsMean = tomorrowsTimeDist.GetMean();
            double tomorrowsStdDev = Math.Sqrt(tomorrowsTimeDist.GetVariance());

            Console.WriteLine("Tomorrows average time: {0:f2}", tomorrowsMean);
            Console.WriteLine("Tomorrows standard deviation: {0:f2}", tomorrowsStdDev);
            Console.WriteLine("Probability that tomorrow's time is < 18 min: {0}",
                              cyclistPrediction.InferProbabilityTimeLessThan(18.0));


            int execucao = 1;
            int counter = 1;
            int endLoop = ug1.Estados.Count;
            int numeroElementos = 10;
            do
            {
                // Second round of training
                //new double[] { 17, 19, 18, 21, 15 };
                double[] trainingData2 = new double[] {18,5,27,37,15};
                    //ObterDadosTreinamento(ug1.Estados, numeroElementos * execucao, numeroElementos);
                Console.WriteLine($"Dados para treinamento '{execucao}': {string.Join(" | ", trainingData2)}");

                cyclistTraining.SetModelData(posteriors1);
                ModelData posteriors2 = cyclistTraining.InferModelData(trainingData2);

                //Console.WriteLine("\n2nd training pass");
                Console.WriteLine("Average travel time = " + posteriors2.AverageTimeDist);
                Console.WriteLine("Traffic noise = " + posteriors2.TrafficNoiseDist);

                // Predictions based on two rounds of training
                cyclistPrediction.SetModelData(posteriors2);

                tomorrowsTimeDist = cyclistPrediction.InferTomorrowsTime();
                tomorrowsMean = tomorrowsTimeDist.GetMean();
                tomorrowsStdDev = Math.Sqrt(tomorrowsTimeDist.GetVariance());

                Console.WriteLine("Tomorrows average time: {0:f2}", tomorrowsMean);
                Console.WriteLine("Tomorrows standard deviation: {0:f2}", tomorrowsStdDev);
                Console.WriteLine("Probability that tomorrow's time is < 18 min: {0}\n",
                                    cyclistPrediction.InferProbabilityTimeLessThan(18));

                posteriors1 = posteriors2;

                counter += numeroElementos;
                execucao++;


                Console.ReadKey(true);
            } while (counter < endLoop);
        }
    }
}
