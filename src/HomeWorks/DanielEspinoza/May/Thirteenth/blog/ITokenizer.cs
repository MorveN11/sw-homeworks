using System;
using System.Collections.Generic;

namespace Blog
{public interface ITokenizer{
    List<Line> Tokenize(string[] data);
}

}
