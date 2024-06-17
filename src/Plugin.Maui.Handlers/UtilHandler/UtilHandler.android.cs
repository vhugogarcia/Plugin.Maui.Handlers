using Microsoft.Maui;
using Microsoft.Maui.Platform;
using System.Drawing;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace Plugin.Maui.Handlers;

partial class UtilHandler
{
	/// <summary>
    /// Forces to hide the soft-keyboard
    /// </summary>
    public static void HideKeyboard()
    {
        if (Microsoft.Maui.ApplicationModel.Platform.CurrentActivity?.CurrentFocus is not null)
        {
            Microsoft.Maui.ApplicationModel.Platform.CurrentActivity.HideKeyboard(Microsoft.Maui.ApplicationModel.Platform.CurrentActivity.CurrentFocus);
            Microsoft.Maui.ApplicationModel.Platform.CurrentActivity.CurrentFocus.ClearFocus();
        }
    }
}