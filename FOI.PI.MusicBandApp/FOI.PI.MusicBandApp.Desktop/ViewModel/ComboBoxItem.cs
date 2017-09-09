namespace FOI.PI.MusicBandApp.Desktop.ViewModel
{
    public class ComboBoxItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
