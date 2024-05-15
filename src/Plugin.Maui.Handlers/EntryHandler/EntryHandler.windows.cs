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

    	});
    }
}