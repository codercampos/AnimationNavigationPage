# Xamarin.Forms.Controls
##1. Animation Navigation Page
Override the default Page Transitions for Xamarin.Forms when calling PushAsync and PopAsync.
### Usage
The simplest example of using AnimationNavigationPage looks something like this:

- Create AnimationNavigationPage
```csharp  
public class App : Application
{
    public App()
    {
        MainPage = new AnimationNavigationPage(new YourHomePage());
    }
}
```

- Implement interface IAnimationPage
```csharp   
public partial class FirstPage : ContentPage, IAnimationPage
{
    public FirstPage()
    {
        InitializeComponent();
    }
    
    public AnimationType AnimationType { get; set; } = AnimationType.Flip;

    public uint AnimationDuration { get; set; } = 650;
}
```
Android:

![alt tag](https://github.com/AlexandrNikulin/Xamarin.Forms.Controls/blob/master/Samples/Sample.Droid/Screenshots/Android.gif)

iOS:

![alt tag] (https://github.com/AlexandrNikulin/Xamarin.Forms.Controls/blob/master/Samples/Sample.iOS/Screenshots/iOS.gif)
###Features
- Default animation
- Flip animation
- Slide animation

###Changes
