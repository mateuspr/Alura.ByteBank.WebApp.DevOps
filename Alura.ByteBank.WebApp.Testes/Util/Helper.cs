using System.IO;
using System.Reflection;

namespace Alura.ByteBank.WebApp.Testes.Util
{
    public static class Helper
    {
        public static string CaminhoDriverNavegador() => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

    }
}
