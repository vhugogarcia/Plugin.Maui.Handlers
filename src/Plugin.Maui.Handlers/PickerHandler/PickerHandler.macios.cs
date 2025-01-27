using Microsoft.Maui;
using Microsoft.Maui.Platform;
using System.Drawing;
using Color = Microsoft.Maui.Graphics.Color;

using UIKit;
using Foundation;

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
            handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
            handler.PlatformView.Layer.BorderWidth = 0;
            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
        });
    }
}