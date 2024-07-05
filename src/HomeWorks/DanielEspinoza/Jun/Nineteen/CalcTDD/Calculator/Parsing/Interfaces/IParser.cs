using Calculator.Expressions;

namespace Calculator.Parsing;


public interface IParser{

	IExpression Parse(string expression);
    
}
