using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Lottie.Forms;
using Rg.Plugins.Popup;
using Rg.Plugins.Popup.Services;


namespace LottieAnimationEx
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            MyButton.Source = ImageSource.FromResource("LottieAnimationEx.Image.microphoneRed.png");
           


        }

        
        
        public async void MyButton_Pressed(object sender, EventArgs e)
        {


            await PopupNavigation.Instance.PushAsync(new LoadingPage());



        }

    } 
}
