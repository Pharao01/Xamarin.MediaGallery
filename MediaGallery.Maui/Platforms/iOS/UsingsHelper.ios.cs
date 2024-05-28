using System;
using CoreGraphics;

static class UsingsHelper
{
    public static Rectangle EmptyRectangle =>
#if NET6_0_OR_GREATER
        Rectangle.Zero;
#else
        Rectangle.Empty;
#endif

    public static CGRect AsCGRect(this Rectangle rect) =>
#if NET6_0_OR_GREATER
        new CGRect((float)rect.X, (float)rect.Y, (float)rect.Width, (float)rect.Height);
#else
        rect.ToPlatformRectangle();
#endif
    public static Rectangle ToRect(this object val) =>
        val is Rectangle rect ? rect : EmptyRectangle;

}
