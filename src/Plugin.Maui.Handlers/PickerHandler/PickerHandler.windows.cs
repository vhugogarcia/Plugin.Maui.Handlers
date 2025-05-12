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
            // Not needed for Windows
        });
    }
}