using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace Plugin.Maui.Handlers;

partial class EditorHandler
{
    /// <summary>
    /// Removes the borders of the <see cref="Editor"/> control
    /// </summary>
    public static void RemoveBorders()
    {
        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
        {
            handler.PlatformView.Background = null;
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
            handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
        });
    }

	/// <summary>
    /// Enables de scrolling of the <see cref="Editor"/> control
    /// </summary>
    public static void EnableScrolling()
    {
        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("Scrolling", (handler, view) =>
        {
            // Not needed for Android
        });
    }

    /// <summary>
    /// Adds a Done button to the <see cref="Editor"/> control
    /// <parameter>toolbarBackgroundColor</parameter> The color of the toolbar background
    /// </summary>
    public static void AddDone(Color? toolbarBackgroundColor = null, bool useTransparentToolbar = false)
    {
        toolbarBackgroundColor ??= Color.FromArgb("#FFFFFF");

        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("Done", (handler, view) =>
        {
            // Not needed for Android
    	});
    }
}