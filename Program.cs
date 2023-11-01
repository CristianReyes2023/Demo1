using Demo1.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        // Linq01 demoLinq01 = new Linq01();
        // demoLinq01.PrintData();
        // demoLinq01.Query();
        //---------------------------------
        // Linq02 demoLinq02 = new Linq02();
        // demoLinq02.PrintData();
        // Linq02 student = new Linq02();
        // student.PrintDataIdName();
        //---------------------------
        // Linq02 student = new Linq02();
        // student.PrintDataV3();
        //-----------------------------
        // Linq02 student = new Linq02();
        // student.Ordenamiento();
        //------------------------------------
        Linq02 student = new Linq02();
        student.JoinEntities();
    }
}