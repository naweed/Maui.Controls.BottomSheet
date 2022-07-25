# MAUI Bottom Sheet Control
A simple customizable Bottom Sheet control built using .NET MAUI.

You can read more about implementation of this control at [https://blogs.xgenoapps.com/post/2022/07/23/maui-bottom-sheet](https://blogs.xgenoapps.com/post/2022/07/23/maui-bottom-sheet)

## How to use
1. Add the following namespace declaration in your Maui Form pages:
```
xmlns:controls="clr-namespace:XGENO.Maui.Controls;assembly=Maui.Controls.BottomSheet"
```
2. Add the control to the page and set the properties as necessary.
```
<controls:BottomSheet
    x:Name="simpleBottomSheet"
    HeaderText="Simple Example">
    
    <controls:BottomSheet.BottomSheetContent> 
        <Label
            Text="Hello from Bottom Sheet. This is a simple implementation with no customization." />
    </controls:BottomSheet.BottomSheetContent>
    
</controls:BottomSheet>
```

## BottomSheet Customizations
You can customize the control using any of the below properties
| Property | Data Type | Explanation |
| :--- | :----: | :--- |
| HeaderText      | String       | This is the text which will be displayed as the header of the bottom sheet.   |
| HeaderStyle   | Label Style        | The header text can be styled as needed. By default, it uses the default font with FontSize of 24.      |
| Theme   | Enum        | Defines the theme of the bottom sheet. It is based on enum values of Light and Dark. The bottom sheet color changes based on this theme (white for light theme and dark gray for Dark theme).      |
| SheetHeight   | Double        | This defines the height of the content area of the bottom sheet.      |

## Running Example
https://user-images.githubusercontent.com/103980/180698691-39030b2c-d79e-4412-9435-9590b8181b55.mp4


