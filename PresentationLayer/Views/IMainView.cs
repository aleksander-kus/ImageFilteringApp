﻿using PresentationLayer.Presenters;
using System.Drawing;

namespace PresentationLayer.Views
{
    public interface IMainView
    {
        public MainPresenter Presenter { set; }
        public int CanvasWidth { get; }
        public int CanvasHeight { get; }
        public Bitmap CanvasImage { get; }
        public void RedrawCanvas();
    }
}