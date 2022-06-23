using System;

namespace IMC
{
	public static class Calculo
	{
		public static double Calcular(double peso, double altura)
        {
			return peso / (altura * altura);
        }

		public static Classificacao Classificar(double imc)
        {
			Classificacao classificacao;

			if (imc < 18.5)
            {
				classificacao = Classificacao.AbaixoDoPeso;
            }
			else if (imc >= 18.5 && imc < 24.9)
            {
				classificacao = Classificacao.PesoNormal;
            }
			else if (imc >= 25 && imc < 29.9)
            {
				classificacao = Classificacao.Sobrepeso;
            }
			else if (imc >= 30 && imc < 34.9)
			{
				classificacao = Classificacao.ObesidadeGrauI;
			}
			else if (imc >= 35 && imc < 39.9)
			{
				classificacao = Classificacao.ObesidadeGrauII;
			}
			else
			{
				classificacao = Classificacao.ObesidadeGrauIII;
			}

			return classificacao;
		}
	}
}

