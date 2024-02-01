namespace FormMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
          /*  count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);*/
        }

      

        private void ModificarBtn_Clicked(object sender, EventArgs e)
        {
            textNombre.Placeholder = "Nuevo Placeholder";
            labelNombre.Text = "¡Botón Enviado!";
        }
        private void cambiarTextoLabel(object sender, EventArgs e)
        {
            labelDireccion.Text = textDireccion.Text;
        }
    }

}
