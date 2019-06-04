﻿using System;
using System.Drawing;

namespace FishingFun
{
    public interface IImageProvider
    {
        event EventHandler<BobberBitmapEvent> BitmapEvent;
    }

    public class BobberBitmapEvent : EventArgs
    {
        public Bitmap Bitmap { get; set; }
        public Point Point { get; set; }
    }

    public enum FishingAction
    {
        BobberMove,
        Reset,
        Loot
    }

    public class FishingEvent : EventArgs
    {
        public FishingAction Action;
        public int Amplitude;
    }
}