namespace Calculator;

public partial class CalcPage : ContentPage
{
	public CalcPage()
	{
		InitializeComponent();
	}
	private void OnButtonClicked(object sender, EventArgs e)
	{
		Button but = (Button)sender;
		int num = int.Parse(but.Text);

		lblResult.Text = num+ "+ 5 = " +(num+5);

    }
	private void OnClearClicked(object sender, EventArgs e)
	{
		lblResult.Text = "";
    }
	private void OnEqualsClicked(object sender, EventArgs e)
	{
		lblResult.Text = "";
    }
}