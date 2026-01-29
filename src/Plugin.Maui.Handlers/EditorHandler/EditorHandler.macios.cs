using Microsoft.Maui;
using Microsoft.Maui.Platform;
using System.Drawing;
using Color = Microsoft.Maui.Graphics.Color;

using UIKit;
using Foundation;

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
            // Not needed for iOS
        });
    }

    /// <summary>
    /// Enables the scrolling of the <see cref="Editor"/> control
    /// </summary>
    public static void EnableScrolling()
    {
        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("Scrolling", (handler, view) =>
        {
            handler.PlatformView.ScrollEnabled = true;
            handler.PlatformView.UserInteractionEnabled = true;
        });
    }

    /// <summary>
    /// Adds a Done button to the <see cref="Editor"/> control
    /// <parameter>toolbarBackgroundColor</parameter> The color of the toolbar background
    /// <parameter>useTransparentToolbar</parameter> Whether to use a transparent toolbar (iOS 26+ only)
    /// </summary>
    public static void AddDone(Color? toolbarBackgroundColor = null, bool useTransparentToolbar = false)
    {
        toolbarBackgroundColor ??= Color.FromArgb("#FFFFFF");

        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("Done", (handler, view) =>
        {
            var toolbar = new UIToolbar(new RectangleF(0.0f, 0.0f, 50.0f, 44.0f))
            {
                Translucent = true
            };

            // iOS 26+ transparent toolbar support
            if (useTransparentToolbar && UIDevice.CurrentDevice.CheckSystemVersion(26, 0))
            {
                var appearance = new UIToolbarAppearance();
                appearance.ConfigureWithTransparentBackground();
                toolbar.StandardAppearance = appearance;
                toolbar.CompactAppearance = appearance;
                toolbar.ScrollEdgeAppearance = appearance;
                toolbar.BackgroundColor = UIKit.UIColor.Clear;
            }
            else
            {
                toolbar.BackgroundColor = toolbarBackgroundColor.ToPlatform();
            }

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
}