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
| ItemCount      | Integer       | The number of rating items (e.g. stars) to draw. Defaulted to 5.   |
| ItemSize   | Float        | Defines the height of the item/star. Defaulted to 24f.      |
| ItemSpacing   | Float        | Defines the spacing between items/stars. Defaulted to 6f.      |
| Value   | Double        | The Value of the Rating used to fill the shape items/stars. Defaulted to 2.5d.      |
| RatedFillColor   | Color        | The color used to fill the shape items/stars with rating value. Defaulted to Yellow.     |
| UnRatedFillColor   | Color        | The color used to fill the empty shape items/stars. Defaulted to Light Grey.      |
| StrokeColor   | Color        | The color used to outline shape items/stars. Defaulted to Light Yellow.      |
| StrokeWidth   | Float        | Defines the stroke size of the outline. Defaulted to 1f.      |
| IsReadOnly   | Boolean        | This will be implemented in future and will be used to allow interactions to change the rating via user interactions. Currently defaulted to true.      |
| ShapePath   | String        | Used to define the shape of the item to draw. Defaulted to Star shape.      |

## Running Example
https://user-images.githubusercontent.com/103980/180698691-39030b2c-d79e-4412-9435-9590b8181b55.mp4


