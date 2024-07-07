using System.Collections.ObjectModel;

namespace SwipeItemLacksA11y
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ListItem> Items { get; private set; }
        public Command<ListItem> TapMeCommand { get; private set; }

        public MainPage()
        {
            Items = new ObservableCollection<ListItem>();
            Items.Add(new ListItem() { Text = "First" });
            Items.Add(new ListItem() { Text = "Second" });
            Items.Add(new ListItem() { Text = "Third" });
            Items.Add(new ListItem() { Text = "Fourth" });

            TapMeCommand = new Command<ListItem>(async (item) =>
            {
                await DisplayAlert("Hurra!", "You just executed the swipe item command.", "Dismiss");
            });

            InitializeComponent();

            BindingContext = this;
        }

        private void OnRowItemSelected(object sender, SelectionChangedEventArgs e)
        {

        }
    }

}
