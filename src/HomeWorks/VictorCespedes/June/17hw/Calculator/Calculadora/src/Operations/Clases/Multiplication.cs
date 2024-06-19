using Calculadora.src.Operations.Interfaces;

namespace Calculadora.src.Operations.Clases
{
    public class Multiplication : IComplexOperation{
        public char symbol(){
            return '*';
        }

        public double Operation(double value1, double value2){
            double result = value1 * value2;
            return result;
        }
    }
}
