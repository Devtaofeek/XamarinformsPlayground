using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin_Forms_Playground.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SkiaSharp;

namespace Xamarin_Forms_Playground.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        SKPaint blackFillPaint = new SKPaint()
        {
            Style = SKPaintStyle.Fill,
            Color = SKColors.LightCyan
        };

        SKPaint whiteStrokePaint = new SKPaint()
        {
            Style = SKPaintStyle.Stroke,
            Color = SKColors.White,
            StrokeWidth = 2,
            StrokeCap = SKStrokeCap.Round,
            IsAntialias = true,
        };
        SKPaint blueFillPaint = new SKPaint()
        {
            Style = SKPaintStyle.Fill,
            Color = SKColors.DarkCyan
        };

        SKPaint whitefillpaint = new SKPaint()
        {
            Style = SKPaintStyle.Fill,
            Color = SKColors.White
        };

        
        public LoginPage()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1f / 60), () =>
            {
                canvasView.InvalidateSurface();
                return true;
            });
            this.BindingContext = new LoginViewModel();
        }

        private void canvasView_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SkiaSharp.SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;
            canvas.Clear(SKColors.LightGoldenrodYellow);
            var width = e.Info.Width;
            var height = e.Info.Height;
            DateTime dateTime = DateTime.Now;
            canvas.Translate(width / 2, height / 2);
            canvas.Scale(width/300f);
            canvas.DrawCircle(0, 0, 100, blueFillPaint);

            for (int angle = 0; angle < 360; angle+=6)
            {
                canvas.DrawCircle(0, -90, angle % 30 == 0 ? 4 : 2, whitefillpaint);
                canvas.RotateDegrees(6);
            }

            canvas.Save();
            canvas.RotateDegrees(30 * dateTime.Hour + dateTime.Minute / 2f);
            whiteStrokePaint.StrokeWidth = 12;
            canvas.DrawLine(0, 0, 0, -50, whiteStrokePaint);
            canvas.Restore();


            canvas.RotateDegrees(6 * dateTime.Minute + dateTime.Second / 10f);
            whiteStrokePaint.StrokeWidth = 8;
            canvas.DrawLine(0, 0, 0, -70, whiteStrokePaint);
            canvas.Restore();

            canvas.Save();
            float seconds = dateTime.Second + dateTime.Millisecond / 1000f;
            canvas.RotateDegrees(6 * seconds);
            whiteStrokePaint.StrokeWidth = 2;
            canvas.DrawLine(0, 10, 0, -90, whiteStrokePaint);
            canvas.Restore();
        }
    }
}