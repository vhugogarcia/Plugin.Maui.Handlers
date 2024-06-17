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
        UIApplication.SharedApplication.KeyWindow?.EndEditing(true);
    }
}