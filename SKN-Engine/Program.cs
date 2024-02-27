using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace SKN_Engine
{
    public class Program
    {
        public static void Main()
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
