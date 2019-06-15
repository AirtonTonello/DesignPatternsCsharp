using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            - Strategy: Estrategia de abstracao
            - Problema: é necessario fazer o calculo de varios impostos como: iss, icms e outros. Sem que o codigo fique exetenso com varios Ifs
            - Solucao: Criado uma interface Imposto que contem a funcao calcula, cada imposto sera um classe e essa classe herda a interface imposto
              cada classe tera o metodo calcula, dessa forma a calculadora sabera qual imposto utilizar
             */
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iccc);

            Console.ReadKey();
        }
    }
}
