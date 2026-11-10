namespace BicycleMealManagement;

public class MushroomForm : Form
{
    private readonly ComboBox product = new() { Left = 230, Top = 125, Width = 220, DropDownStyle = ComboBoxStyle.DropDownList };
    private readonly NumericUpDown quantity = new() { Left = 230, Top = 180, Width = 220, Minimum = 1, Maximum = 100, Value = 1 };
    private readonly Label total = new() { Left = 230, Top = 245, Width = 250, Height = 30, Text = "Total: 0 RWF", Font = new Font("Segoe UI", 12, FontStyle.Bold) };
    private readonly decimal[] prices = { 3000m, 5000m, 8000m };

    public MushroomForm(string user)
    {
        Ui.Style(this, "Mushroom service");
        Controls.Add(Ui.Heading("Mushroom Service"));
        Controls.Add(Ui.Label("Mushroom type:", 90, 125, 130));
        product.Items.AddRange(new object[] { "Oyster mushrooms (pack)", "Button mushrooms (pack)", "Shiitake mushrooms (pack)" });
        product.SelectedIndex = 0;
        Controls.Add(product);

        Controls.Add(Ui.Label("Quantity:", 90, 180, 130));
        Controls.Add(quantity);
        Controls.Add(total);

        var calculate = Ui.Button("Calculate total", 230, 300, 150);
        calculate.Click += (_, _) => Calculate();
        Controls.Add(calculate);

        var back = Ui.Button("Back", 90, 365, 110);
        back.Click += (_, _) => Close();
        Controls.Add(back);

        var logout = Ui.Button("Logout", 390, 365, 110);
        logout.Click += (_, _) => Close();
        Controls.Add(logout);
    }

    private void Calculate()
    {
        decimal amount = prices[product.SelectedIndex] * quantity.Value;
        total.Text = $"Total: {amount:N0} RWF";
        MessageBox.Show($"Mushroom: {product.Text}\nQuantity: {quantity.Value}\nTotal: {amount:N0} RWF",
            "Mushroom order summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
