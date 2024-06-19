using Calculadora.src.Operations.Interfaces;

namespace Calculadora.src.Operations.Clases
{
    public class Substraction : IComplexOperation
    {
        public char symbol(){
            return '-';
        }

        public double Operation(double value1, double value2){
            double result = value1 - value2;
            return result;
        }
    }
}
