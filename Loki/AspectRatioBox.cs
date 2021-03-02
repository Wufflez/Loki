using System;
using System.Windows;
using System.Windows.Controls;

namespace Loki
{
    public class AspectRatioBox : Decorator
    {
        public static readonly DependencyProperty AspectRatioProperty =
           DependencyProperty.Register(
              "AspectRatio",
              typeof(double),
              typeof(AspectRatioBox),
              new FrameworkPropertyMetadata
                 (
                    1d,
                    FrameworkPropertyMetadataOptions.AffectsMeasure
                 ),
              ValidateRatio);

        private static bool ValidateRatio(object value)
        {
            return value is double aspectRatio && 
                   aspectRatio > 0 && !double.IsInfinity(aspectRatio) && !double.IsNaN(aspectRatio);
        }

        public double AspectRatio
        {
            get => (double)GetValue(AspectRatioProperty);
            set => SetValue(AspectRatioProperty, value);
        }

        protected override Size MeasureOverride(Size constraint)
        {
            if (Child == null) return new Size(0, 0);

            constraint = SizeToRatio(constraint, false);
            Child.Measure(constraint);

            if (double.IsInfinity(constraint.Width)
                || double.IsInfinity(constraint.Height))
            {
                return SizeToRatio(Child.DesiredSize, true);
            }

            return constraint;

        }

        public Size SizeToRatio(Size size, bool expand)
        {
            double ratio = AspectRatio;

            double height = size.Width / ratio;
            double width = size.Height * ratio;

            if (expand)
            {
                width = Math.Max(width, size.Width);
                height = Math.Max(height, size.Height);
            }
            else
            {
                width = Math.Min(width, size.Width);
                height = Math.Min(height, size.Height);
            }

            return new Size(width, height);
        }

        protected override Size ArrangeOverride(Size arrangeSize)
        {
            if (Child == null) return arrangeSize;

            Size newSize = SizeToRatio(arrangeSize, false);

            double widthDelta = arrangeSize.Width - newSize.Width;
            double heightDelta = arrangeSize.Height - newSize.Height;

            double top = 0;
            double left = 0;

            if (!double.IsNaN(widthDelta)
                && !double.IsInfinity(widthDelta)) 
                left = widthDelta / 2;

            if (!double.IsNaN(heightDelta)
                && !double.IsInfinity(heightDelta)) 
                top = heightDelta / 2;

            var finalRect = new Rect(new Point(left, top), newSize);
            Child.Arrange(finalRect);

            return arrangeSize;
        }
    }
}
