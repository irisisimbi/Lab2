namespace BicycleMealManagement;

public class MealForm : Form
{
    private readonly ComboBox meal = new() { Left = 230, Top = 125, Width = 220, DropDownStyle = ComboBoxStyle.DropDownList };
    private readonly NumericUpDown quantity = new() { Left = 230, Top = 180, Width = 220, Minimum = 1, Maximum = 50, Value = 1 };
    private readonly Label total = new() { Left = 230, Top = 245, Width = 250, Height = 30, Text = "Total: 0 RWF", Font = new Font("Segoe UI", 12, FontStyle.Bold) };

    private readonly decimal[] prices = { 2500m, 3500m, 5000m };

    public MealForm(string user)
    {
        Ui.Style(this, "Meal service");
        Controls.Add(Ui.Heading("Meal Service"));
        Controls.Add(Ui.Label("Select meal:", 90, 125, 130));
        meal.Items.AddRange(new object[] { "Rice and beans", "Chicken and chips", "Beef with rice" });
        meal.SelectedIndex = 0;
        Controls.Add(meal);

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
        decimal amount = prices[meal.SelectedIndex] * quantity.Value;
        total.Text = $"Total: {amount:N0} RWF";
        MessageBox.Show($"Meal: {meal.Text}\nQuantity: {quantity.Value}\nTotal: {amount:N0} RWF",
            "Meal order summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
