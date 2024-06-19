using Calculadora.src.Operations.Interfaces;

namespace Calculadora.src.Operations.Clases
{
    public class Pow : IComplexOperation{
        public char symbol(){
            return '^';
        }

        public double Operation(double value1, double value2){
            double result = Math.Pow(value1, value2);
            return result;
        }
    }
}
