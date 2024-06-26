﻿namespace Plugin.Maui.Handlers;

partial class EditorHandler
{
    /// <summary>
    /// Removes the borders of the <see cref="Editor"/> control
    /// </summary>
    public static void RemoveBorders()
    {
        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
        {
            // Not needed for Windows
        });
    }

    /// <summary>
    /// Removes the borders of the <see cref="Entry"/> control
    /// </summary>
    public static void EnableScrolling()
    {
        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("Scrolling", (handler, view) =>
        {
            // Not needed for Windows
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
            // Not needed for Windows
    	});
    }
}