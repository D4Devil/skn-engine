using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace SKN_Engine
{
    public class Game : GameWindow
    {
        public Game(int width = 480, int height = 480, string title = "Render Engine") : base(GameWindowSettings.Default, new NativeWindowSettings { ClientSize = (width, height), Title = title })
        {
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);

        }
    }
}