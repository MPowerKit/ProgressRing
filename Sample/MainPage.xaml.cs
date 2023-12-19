namespace Sample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count = 0;

            asda.IsIndeterminate = false;

            while (count < 100)
            {
                await Task.Delay(50);

                count++;

                CounterBtn.Text = $"Progress {count} %";

                asda.Progress = count / 100d;
            }

            asda.IsIndeterminate = true;
        }
    }
}
