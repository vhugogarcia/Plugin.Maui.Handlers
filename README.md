# .NET MAUI Plugin: Custom Handlers and Utilities

## Overview

This .NET MAUI plugin provides enhanced functionality for handling user interactions with Entry and Editor controls, along with additional utilities such as hiding the keyboard programmatically.
 
 It helps you to remove the unnecessary native UI elements of the mentioned controls allowing you to customize input design and enhances user experience in your .NET MAUI applications.

## Features

### Entry
- **Remove Borders**, this method removes the borders of the entry for iOS and Android.
- **Add Done Button**, this method add a "Done" button toolbar above the keyboard on iOS only.
#### Example Usage
```csharp
EntryHandler.RemoveBorders();

// The toolbar background default color is #FFFFFF 
EntryHandler.AddDone(Color.FromArgb("#000000"));
```

### Editor
- **Remove Borders**, this method removes the borders of the entry for iOS and Android.
- **Add Done Button**, this method add a "Done" button toolbar above the keyboard on iOS only.
- **Enable scrolling**, this method enables the scrolling on editor control for iOS only.
#### Example Usage
```csharp
    EditorHandler.RemoveBorders();

     // The toolbar background default color is #FFFFFF 
    EditorHandler.AddDone(null);
    EditorHandler.EnableScrolling();
```

### Utilities
- **Hide Keyboard**, this method forces to hide the keyboard on iOS and Android.

#### Example Usage
```csharp
UtilHandler.HideKeyboard();
```

## Thank You!
So if you enjoy this plugin, please consider supporting my contribution via Github sponsorship https://github.com/sponsors/vhugogarcia and follow me on my personal blog (https://dev.to/vhugogarcia) where I keep posting .NET MAUI useful guides and tricks.


