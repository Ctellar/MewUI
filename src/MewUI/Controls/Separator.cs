using Aprillz.MewUI.Rendering;

namespace Aprillz.MewUI.Controls;

/// <summary>
/// A simple horizontal or vertical separator line used to visually divide content.
/// </summary>
public class Separator : Control
{
    public static readonly MewProperty<Orientation> OrientationProperty =
        MewProperty<Orientation>.Register<Separator>(nameof(Orientation), Orientation.Horizontal,
            MewPropertyOptions.AffectsLayout | MewPropertyOptions.AffectsRender);

    /// <summary>
    /// Gets or sets the orientation of the separator line.
    /// Default is <see cref="Orientation.Horizontal"/>.
    /// </summary>
    public Orientation Orientation
    {
        get => GetValue(OrientationProperty);
        set => SetValue(OrientationProperty, value);
    }

    private double EffectiveThickness => BorderThickness > 0 ? BorderThickness : 1;

    protected override Size MeasureContent(Size availableSize)
    {
        var thickness = EffectiveThickness;
        return Orientation == Orientation.Horizontal
            ? new Size(0, thickness)
            : new Size(thickness, 0);
    }

    protected override void OnRender(IGraphicsContext context)
    {
        var bg = Background;
        if (bg.A == 0)
        {
            bg = Theme.Palette.ControlBorder;
        }

        var thickness = EffectiveThickness;
        var bounds = Bounds;

        if (Orientation == Orientation.Horizontal)
        {
            var y = bounds.Y + (bounds.Height - thickness) / 2;
            context.FillRectangle(new Rect(bounds.X, y, bounds.Width, thickness), bg);
        }
        else
        {
            var x = bounds.X + (bounds.Width - thickness) / 2;
            context.FillRectangle(new Rect(x, bounds.Y, thickness, bounds.Height), bg);
        }
    }
}
