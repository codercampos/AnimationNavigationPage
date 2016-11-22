# Animation Navigation Page
Override the default Page Transitions for Xamarin.Forms when calling PushAsync and PopAsync.

![Android](Gif/Android.gif) ![iOS](Gif/iOS.gif)

##Features
- Set Animation Duration.
- Select Animation type (Empty, Push, Fade, Flip, Slide, Roll, Rotate).
- Select Animation Subtype (Default, FromLeft, FromRight, FromTop, FromBottom).

##Links
- [Xamarin Components Store](https://components.xamarin.com/view/customnavpage)
- [YouTube Demo](https://youtu.be/Re48wHf_7yU)

## Support platforms

- [x] Android
- [x] iOS
- [ ] WP (Coming Soon)

## Usage
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
- Create AnimationPage instead ContentPage and create instance of FadePageAnimation or PushPageAnimation or FlipPageAnimation etc in xaml or bind from ViewModel.
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

##Changes
**New in 1.5.3**

- Implement Property AnimateNavigationBar (bool) in AnimationNavigationPage. According this issue: https://github.com/AlexandrNikulin/AnimationNavigationPage/issues/11

**New in 1.5.2**

- Implement Bounce Effect for Animations.

**New in 1.5.1**

- Support Animation Duration for FormsAppCompatActivity (Android).

**New in 1.5.0**

- New animation types (Roll and Rotate).
- Support FormsAppCompatActivity for Android (limitation not supported Flip animation and changing animation duration. This features will be implemented on next versions).
