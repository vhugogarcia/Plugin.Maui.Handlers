# .NET MAUI Plugin: Custom Handlers and Utilities

## Overview

This .NET MAUI plugin provides enhanced functionality for handling user interactions with Entry, Editor, Date Picker and Picker controls, along with additional utilities such as hiding the keyboard programmatically.

It helps you to remove the unnecessary native UI elements of the mentioned controls allowing you to customize input design and enhances user experience in your .NET MAUI applications.

## Features
| **Feature** | **iOS** | **Android** | **Windows** |
| --- | --- | --- | --- |
| **Entry** |     |     |     |
| Remove Borders | ✅   | ✅   |     |
| Add Done Button | ✅   |     |     |
| Set Field Cursor Color |     | ✅   |     |
| **Editor** |     |     |     |
| Remove Borders | ✅   | ✅   |     |
| Add Done Button | ✅   |     |     |
| Enable Scrolling | ✅   |     |     |
| **Picker** |     |     |     |
| Remove Borders | ✅   | ✅   |     |
| **Date Picker** |     |     |     |
| Remove Borders | ✅   | ✅   |     |
| **Utilities** |     |     |     |
| Hide Keyboard | ✅   | ✅   |     |
| Disable WebView Bounce | ✅   |     |     |

#### Example Usage

```csharp
// Removes the borders from the entry control
EntryHandler.RemoveBorders();

// Sets the cursor color of the entry control. Default color is #CCCCCC
EntryHandler.SetFieldCursorColor(Color.FromArgb("#000000"))

// Adds a DONE button to the keyboard and sets toolbar background. Default color is #FFFFFF
EntryHandler.AddDone(Color.FromArgb("#000000"));
EditorHandler.AddDone(null);

// Removes the borders from the editor control
EditorHandler.RemoveBorders();

// Removes the borders from the picker control
PickerHandler.RemoveBorders();

// Removes the borders from the date picker control
DatePickerHandler.RemoveBorders();

// Enables the vertical scrolling on the editor control
EditorHandler.EnableScrolling();

// Forces the keyword to be hidden
UtilHandler.HideKeyboard();
```

## Thank You!

So if you enjoy this plugin, please consider supporting my contribution via Github sponsorship https://github.com/sponsors/vhugogarcia and follow me on my personal blog (https://dev.to/vhugogarcia) where I keep posting .NET MAUI useful guides and tricks.