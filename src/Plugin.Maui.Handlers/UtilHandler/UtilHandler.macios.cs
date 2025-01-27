using Microsoft.Maui;
using Microsoft.Maui.Platform;

using UIKit;
using Foundation;

namespace Plugin.Maui.Handlers;

partial class UtilHandler
{
    /// <summary>
    /// Forces to hide the soft-keyboard
    /// </summary>
    public static void HideKeyboard()
    {
        if (DeviceInfo.Version.Major >= 16)
            UIApplication.SharedApplication?.ConnectedScenes?.ToArray<UIWindowScene>()?.Where(ws => ws.KeyWindow != null)?.Select(ws => ws.KeyWindow)?.Last()?.EndEditing(true);
        else if (DeviceInfo.Version.Major >= 13)
            UIApplication.SharedApplication?.ConnectedScenes?.ToArray<UIWindowScene>()?.Where(ws => ws.Windows != null).SelectMany(ws => ws.Windows)?.Where(w => w.IsKeyWindow).Last()?.EndEditing(true);
    }

    public static void DisableWebViewBounce()
    {
#if IOS
        Microsoft.Maui.Handlers.ScrollViewHandler.Mapper.AppendToMapping("DisableBounce", (handler, view) =>
        {
            handler.PlatformView.Bounces = false;
        });
#endif
    }
}