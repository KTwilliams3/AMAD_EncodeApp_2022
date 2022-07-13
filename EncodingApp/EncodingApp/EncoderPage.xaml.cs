namespace EncodingApp;

public partial class EncoderPage : ContentPage
{
	public EncoderPage()
	{
		InitializeComponent();
	}

	private void EncodeClicked(object sender, EventArgs e)
	{
		long number = 0;

		try
		{
            if (iBin.IsChecked)
                number = Convert.ToInt64(numEntry.Text, 2);
            else if (iOct.IsChecked)
                number = Convert.ToInt64(numEntry.Text, 8);
            else if (iDec.IsChecked)
                number = Convert.ToInt64(numEntry.Text, 10);
            else if (iHex.IsChecked)
                number = Convert.ToInt64(numEntry.Text, 16);
        }
		catch(FormatException ex)
		{
			resultLabel.Text = "Check digits!";
			return;
		}
        //Output
        if (oBin.IsChecked)
            resultLabel.Text = Convert.ToString(number, 2);
        else if (oOct.IsChecked)
            resultLabel.Text = Convert.ToString(number, 8);
        else if (oDec.IsChecked)
            resultLabel.Text = Convert.ToString(number, 10);
        else if (oHex.IsChecked)
            resultLabel.Text = Convert.ToString(number, 16);
        else
            resultLabel.Text = "Select a base!";

	}
}