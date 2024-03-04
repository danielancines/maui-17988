namespace Maui_ScaleError_17988
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.SizeChanged += MainPage_SizeChanged;
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, EventArgs e)
        {
            var window = Application.Current.MainPage.Window;

            window.Height = 700;
            window.Width = 500;
        }

        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            this.WidthLabel.Text = this.Width.ToString();
            this.HeightLabel.Text = this.Height.ToString();
        }
    }
}
