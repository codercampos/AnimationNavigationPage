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
- Create AnimationPage instead ContentPage and create instance of FadePageAnimation or DefaultPageAnimation or FlipPageAnimation etc in xaml or bind from ViewModel.
```csharp   
<?xml version="1.0" encoding="UTF-8"?>
<controls:AnimationPage xmlns="http://xamarin.com/schemas/2014/forms"
        xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
        xmlns:controls="clr-namespace:FormsControls.Base;assembly=FormsControls.Base"
        x:Class="Sample.FadeAnimationPage"
        Title="Fade Animation">
        <controls:AnimationPage.PageAnimation>
            <controls:FadePageAnimation />
        </controls:AnimationPage.PageAnimation>
</controls:AnimationPage>
```
- Or implement interface IAnimationPage for ContentPage. Create instance of EmptyPageAnimation or DefaultPageAnimation or FlipPageAnimation etc... 
```csharp   
public partial class FirstPage : ContentPage, IAnimationPage
{
        public FirstPage()
        {
            InitializeComponent();
        }
    
        public IPageAnimation PageAnimation { get; } = new FlipPageAnimation { Duration = 650, Subtype = AnimationSubtype.FromLeft }; 
}
```
Android:

![alt tag](https://github.com/AlexandrNikulin/Xamarin.Forms.Controls/blob/master/Samples/Sample.Droid/Screenshots/Android.gif)

iOS:

![alt tag] (https://github.com/AlexandrNikulin/Xamarin.Forms.Controls/blob/master/Samples/Sample.iOS/Screenshots/iOS.gif)
###Features
- Set Animation Duration.
- Select Animation type (Empty, Default, Fade, Flip, Slide).
- Select Animation Subtype (Default, FromLeft, FromRight, FromTop, FromBottom).

###Changes
**Big update version 1.2**

- Improve stability.
- Fix some bugs.
- New sample project.
