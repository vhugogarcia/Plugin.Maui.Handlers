namespace Plugin.Maui.Handlers;

partial class DatePickerHandler
{
	/// <summary>
    /// Removes the borders of the <see cref="DatePicker"/> control
    /// </summary>
    public static void RemoveBorders()
    {
        Microsoft.Maui.Handlers.DatePickerHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
        {
            // Not needed for Windows
        });
    }
}