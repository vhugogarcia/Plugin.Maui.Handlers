namespace Plugin.Maui.Handlers;

partial class TimePickerHandler
{
	/// <summary>
    /// Removes the borders of the <see cref="TimePicker"/> control
    /// </summary>
    public static void RemoveBorders()
    {
        Microsoft.Maui.Handlers.TimePickerHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
        {
            // Not needed for Windows
        });
    }
}
