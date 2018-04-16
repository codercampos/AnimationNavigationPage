# Updates: Published all source code.

# Animation Navigation Page

Override the default Page Transitions for Xamarin.Forms when calling PushAsync and PopAsync.

Available on NuGet: https://www.nuget.org/packages/XForms.Plugin.AnimationNavigationPage [![NuGet](https://img.shields.io/nuget/v/XForms.Plugin.AnimationNavigationPage.svg)](https://www.nuget.org/packages/XForms.Plugin.AnimationNavigationPage) 

Using the AnimationNavPage we can demonstrate how to create a custom transition between different pages.

![Android](Gif/Android.gif) ![iOS](Gif/iOS.gif)

## Features
- Set Animation Duration.
- Select Animation type (Empty, Push, Fade, Flip, Slide, Roll, Rotate).
- Select Animation Subtype (Default, FromLeft, FromRight, FromTop, FromBottom).

## Links
- [Xamarin Components Store](https://components.xamarin.com/view/customnavpage)
- [YouTube Demo](https://youtu.be/Re48wHf_7yU)

## Support platforms

- [x] Android
- [x] iOS

## Usage

Setting-up and using the component happens in 3 steps:	
1.	Install nuget package for PCL/Net.Standard, IOS and Android projects
2.	Declare AnimationNavigationPage
3.	Create and Animation page

## INSTALL
Download the ‘customnavpage’ package from https://www.nuget.org/packages/XForms.Plugin.AnimationNavigationPage.

Next, add 'FormsControls.Touch.Main.Init()' into AppDelegate.cs of your Xamarin.iOS Project:
```csharp
public partial class AppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Xamarin.Forms.Forms.Init();
            FormsControls.Touch.Main.Init();
            LoadApplication(new App());
            return base.FinishedLaunching(app, options);
        }
    }
```

Finaly, add 'FormsControls.Droid.Main.Init()' into MainActivity.cs of your Xamarin Droid Project:
```csharp
public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(bundle);
            Xamarin.Forms.Forms.Init(this, bundle);
            FormsControls.Droid.Main.Init(this);
            LoadApplication(new App());
        }
    }
```

## DECLARE ANIMATIONNAVIGATIONPAGE
In your App, declare your new main page as follows:
```csharp  
public class App : Application
{
        public App()
        {
            InitializeComponent();
            MainPage = new AnimationNavigationPage(new StartPage());
        }
}
```
## CREATE AND ANIMATION PAGE
There are 3 ways to create an Animation Page:
1.	Implement the IAnimationPage interface
2.	Use XAML Tags - No Binding
3. 	Use XAML Tags - With Binding


A Simple Custom Animated Page Transitions Demonstration for Xamarin Forms By bbl-Laobu @ https://github.com/bbl-Laobu/AnimatedTransitionNavPageDemo

