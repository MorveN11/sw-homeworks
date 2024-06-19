using Calculadora.src.Operations.Interfaces;

namespace Calculadora.src.Operations.Clases
{
    public class SquareRoot : ISimpleOperation{
        public char symbol(){
            return '√';
        }

        public double Operation(double a){
            if (a < 0) throw new ArgumentException("Negative number");
            return Math.Sqrt(a);
        }
    }

}
