using Aprillz.MewUI.Controls;
using Aprillz.MewUI.Rendering;

namespace Aprillz.MewUI.Gallery;

partial class GalleryView
{
    private FrameworkElement SeparatorPage() =>
        CardGrid(
            Card(
                "Horizontal (theme-aware default)",
                new StackPanel()
                    .Vertical()
                    .Spacing(8)
                    .Children(
                        new TextBlock().Text("Content above"),
                        new Separator(),
                        new TextBlock().Text("Content below")
                    )
            ),

            Card(
                "Horizontal – custom thickness",
                new StackPanel()
                    .Vertical()
                    .Spacing(8)
                    .Children(
                        new TextBlock().Text("Thin (1px)"),
                        new Separator()
                            .BorderThickness(1)
                            .Background(Color.FromRgb(200, 200, 200)),
                        new TextBlock().Text("Medium (3px)"),
                        new Separator()
                            .BorderThickness(3)
                            .Background(Color.FromRgb(70, 130, 230)),
                        new TextBlock().Text("Thick (6px)"),
                        new Separator()
                            .BorderThickness(6)
                            .Background(Color.FromRgb(230, 100, 80))
                    )
            ),

            Card(
                "Vertical (theme-aware default)",
                new StackPanel()
                    .Horizontal()
                    .Height(80)
                    .Children(
                        new TextBlock().Text("Left"),
                        new Separator()
                            .Orientation(Orientation.Vertical)
                            .Margin(8, 0),
                        new TextBlock().Text("Right")
                    )
            ),

            Card(
                "Vertical – custom thickness",
                new StackPanel()
                    .Horizontal()
                    .Height(80)
                    .Spacing(16)
                    .Children(
                        new TextBlock().Text("A"),
                        new Separator()
                            .Orientation(Orientation.Vertical)
                            .BorderThickness(2)
                            .Background(Color.FromRgb(100, 200, 120)),
                        new TextBlock().Text("B"),
                        new Separator()
                            .Orientation(Orientation.Vertical)
                            .BorderThickness(4)
                            .Background(Color.FromRgb(200, 160, 60)),
                        new TextBlock().Text("C")
                    )
            )
        );
}
