namespace Sample
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count = 0;

            pr.IsIndeterminate = false;

            while (count < 100)
            {
                await Task.Delay(50);

                count++;

                CounterBtn.Text = $"Progress {count} %";

                pr.Progress = count / 100d;
            }

            pr.IsIndeterminate = true;
        }

        private async void OnIsVisibleClicked(object sender, EventArgs e)
        {
            pr.IsVisible = !pr.IsVisible;
        }
    }
}
