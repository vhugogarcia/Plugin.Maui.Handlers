using Microsoft.Maui;
using Microsoft.Maui.Platform;
using System.Drawing;
using Color = Microsoft.Maui.Graphics.Color;

using UIKit;
using Foundation;

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
             handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
            handler.PlatformView.Layer.BorderWidth = 0;
            handler.PlatformView.BorderStyle = UITextBorderStyle.None;
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
            var toolbar = new UIToolbar(new RectangleF(0.0f, 0.0f, 50.0f, 44.0f))
            {
                BackgroundColor = toolbarBackgroundColor.ToPlatform(),
                Translucent = true
            };

            var doneButton = new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                handler.PlatformView.ResignFirstResponder();
            });

            toolbar.Items = new UIBarButtonItem[] {
                new (UIBarButtonSystemItem.FlexibleSpace),
                doneButton
            };

            handler.PlatformView.InputAccessoryView = toolbar;
        });
    }

    public static void SetFieldCursorColor()
    {
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("CursorColor", (handler, view) =>
        {

        });
    }
}