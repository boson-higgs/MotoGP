/***************************************************/
/***************************************************/
/***************************************************/
/***************************************************/
/*********  BOSON-HIGGS | neutron.surge.sh  ********/
/***************************************************/
/***************************************************/
/***************************************************/
/***************************************************/

namespace MotoGP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MotoGP());
        }
    }
}