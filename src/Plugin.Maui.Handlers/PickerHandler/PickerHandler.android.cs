using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace Plugin.Maui.Handlers;

partial class PickerHandler
{
	/// <summary>
    /// Removes the borders of the <see cref="Picker"/> control
    /// </summary>
    public static void RemoveBorders()
    {
        Microsoft.Maui.Handlers.PickerHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
        {
            var layoutParams = new Android.Views.ViewGroup.MarginLayoutParams(handler.PlatformView.Width, handler.PlatformView.Height);
            layoutParams.SetMargins(0, 0, 0, 0);
            handler.PlatformView.LayoutParameters = layoutParams;
            handler.PlatformView.SetPadding(0, 0, 0, 0);
            handler.PlatformView.Background = null;
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
            handler.PlatformView.SetHintTextColor(Android.Graphics.Color.Black);
            handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
        });
    }
}