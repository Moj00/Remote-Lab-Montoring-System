﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace SSService
{
    public class ScreenShot
    {
        public static void CaptureAndSave(int x, int y, int width, int height, string imagePath)
        {
            Bitmap myImage = ScreenShot.Capture(x, y, width, height);
            myImage.Save(imagePath, ImageFormat.Png);
        }

        public static Bitmap Capture(int x, int y, int width, int height)
        {
            Bitmap screenShotBMP = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics screenShotGraphics = Graphics.FromImage(screenShotBMP);
            screenShotGraphics.CopyFromScreen(new Point(x, y), Point.Empty, new Size(width, height), CopyPixelOperation.SourceCopy);
            screenShotGraphics.Dispose();
            return screenShotBMP;
        }
    }
}
