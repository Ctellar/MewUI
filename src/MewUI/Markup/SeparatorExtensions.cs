namespace Aprillz.MewUI.Controls;

/// <summary>
/// Fluent markup extensions for <see cref="Separator"/>.
/// </summary>
public static class SeparatorExtensions
{
    /// <summary>
    /// Sets the orientation of the separator line.
    /// </summary>
    /// <param name="separator">Target separator.</param>
    /// <param name="value">Orientation value.</param>
    /// <returns>The separator for chaining.</returns>
    public static Separator Orientation(this Separator separator, MewUI.Orientation value)
    {
        separator.Orientation = value;
        return separator;
    }
}
