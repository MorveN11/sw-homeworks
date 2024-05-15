using System;
using System.Collections.Generic;
namespace Blog
{
    public class  Program{
    public static void Main(){
        ProgramController programController = new ProgramController(new TxtFileReader());
        programController.start();
    }
}

}
