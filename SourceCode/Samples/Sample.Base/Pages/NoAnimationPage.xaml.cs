using System;
using FormsControls.Base;
using Xamarin.Forms;

namespace Sample
{
    public partial class NoAnimationPage : ContentPage, IAnimationPage
    {
        public NoAnimationPage()
        {
            InitializeComponent();
        }

        public IPageAnimation PageAnimation { get; } = new EmptyPageAnimation();

        private void OnButtonClicked(object sender, EventArgs args)
        {
            Navigation.PopAsync();
        }
    }
}