using ChessApplication.ChessGame.Forms;

namespace ChessApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new formBoard());
        }
    }
}