using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace Plugin.Maui.Handlers;

partial class EntryHandler
{
	/// <summary>
    /// Removes the borders of the <see cref="Entry"/> control
    /// </summary>
    public static void RemoveBorders()
    {
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
        {
            handler.PlatformView.Background = null;
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
            handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
        });
    }

    /// <summary>
    /// Adds a Done button to the <see cref="Entry"/> control
    /// <parameter>toolbarBackgroundColor</parameter> The color of the toolbar background
    /// </summary>
    public static void AddDone(Color toolbarBackgroundColor)
    {
        toolbarBackgroundColor ??= Color.FromArgb("#FFFFFF");

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("Done", (handler, view) =>
        {
            // Not needed for Android
    	});
    }

    public static void SetFieldCursorColor(Color cursorColor)
    {
        cursorColor ??= Color.FromArgb("#CCCCCC");

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("CursorColor", (handler, view) =>
        {
#if ANDROID
            if (OperatingSystem.IsAndroidVersionAtLeast(29))
            {
                if (handler.PlatformView.TextCursorDrawable is null)
                    return;

                handler.PlatformView.TextCursorDrawable.SetTint(cursorColor.ToAndroid());
            }
#endif
        });
    }
}