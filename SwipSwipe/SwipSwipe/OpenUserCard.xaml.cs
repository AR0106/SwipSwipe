using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SwipSwipe;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwipSwipe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OpenUserCard : ContentView
    {
        public static readonly BindableProperty UserProperty = BindableProperty.Create("User", typeof(User), typeof(OpenUserCard), null);

        public User UserCard
        {
            get => (User)GetValue(UserProperty);
            set => SetValue(UserProperty, value);
        }

        public OpenUserCard()
        {
            InitializeComponent();
        }

        //public string ImageSource => UserCard.ProfilePicture.AbsoluteUri;
        public string Image = "Resources/drawable/SearchIcon.png";

        public ImageSource imageSource { get { return ImageSource.FromFile(Image); } }
    }
}