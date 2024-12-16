namespace SuperKosci;
public partial class MainPage : ContentPage
{
    int wynik = 0;
    int punkty = 0;

    public MainPage()
    {
        InitializeComponent();
    }
    private void reset(object sender, EventArgs e)
    {
        wynik = 0;
        punkty = 0;
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        Random random = new Random();
            int[] kosci = new int[6];
        int i = 0;
                kosci[i] = random.Next(1, 7);
                kosc1.Source = $"kosc{kosci[i]}.png";
        i++;
                kosci[i] = random.Next(1, 7);
                kosc2.Source = $"kosc{kosci[i]}.png";
        i++;
                kosci[i] = random.Next(1, 7);
                kosc3.Source = $"kosc{kosci[i]}.png";
        i++;
                kosci[i] = random.Next(1, 7);
                kosc4.Source = $"kosc{kosci[i]}.png";
        i++;
                kosci[i] = random.Next(1, 7);
                kosc5.Source = $"kosc{kosci[i]}.png";
            punkty = suma(kosci);
            losowanie.Text = punkty+"";
            wynikC.Text = wynik + punkty + "";
            wynik = wynik + punkty;

        static int suma(int[] kosci)
        {
            var ileRazy = kosci.GroupBy(x => x);
            int punkty = 0;
            foreach (var group in ileRazy)
            {
                if (group.Count() >= 2)
                {
                    punkty += group.Sum();
                }
            }
            return punkty;
        }
    }
}
