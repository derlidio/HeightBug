namespace HeightBug.Controls
{
	public class Proportional : ContentView
	{
		public Proportional()
		{
			BackgroundColor = Colors.Yellow;

            SizeChanged += Proportional_SizeChanged;
		}

        private void Proportional_SizeChanged(object? sender, EventArgs e)
        {
            double request = Math.Floor(Width / 5);

            if (HeightRequest != request)
            {
                HeightRequest = request;
                
                System.Diagnostics.Debug.WriteLine($"Height set to: {HeightRequest}");

                return;
            }

            System.Diagnostics.Debug.WriteLine($"Height is alreay set to: {HeightRequest}");
        }
    }
}