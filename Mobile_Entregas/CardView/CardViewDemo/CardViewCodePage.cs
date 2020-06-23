using CardViewDemo.Controls;
using Xamarin.Forms;

namespace CardViewDemo
{
    public class CardViewCodePage : ContentPage
    {
        public CardViewCodePage()
        {
            Title = "CardView Code Demo";
            Padding = 10;

            StackLayout layout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Children =
                {
                    new CardView
                    {
                        BorderColor = Color.DarkGray,
                        CardTitle = "Maycon Representante",
                        CardDescription = "O melhor representante que a 2ND já viu",
                        IconBackgroundColor = Color.SlateGray,
                        IconImageSource = ImageSource.FromFile("user.png")

                    },
                    new CardView
                    {
                        BorderColor = Color.DarkGray,
                        CardTitle = "Ingrid Melo",
                        CardDescription = "Indescritivel.",
                        IconBackgroundColor = Color.SlateGray,

                        IconImageSource = ImageSource.FromFile("user.png")

                    },
                    new CardView
                    {
                        BorderColor = Color.DarkGray,
                        CardTitle = "Rafael Conrado",
                        CardDescription = "Trouxe o cafézinho?",
                        IconBackgroundColor = Color.SlateGray,
                                           IconImageSource = ImageSource.FromFile("user.png")

                    },
                    new CardView
                    {
                        BorderColor = Color.DarkGray,
                        CardTitle = "Tiago",
                        CardDescription = "Blablablablablablablablablablablabla",
                        IconBackgroundColor = Color.SlateGray,
                                                IconImageSource = ImageSource.FromFile("user.png")

                    },
                }
            };

            ScrollView scroll = new ScrollView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Content = layout
            };

            Content = scroll;
        }
    }
}