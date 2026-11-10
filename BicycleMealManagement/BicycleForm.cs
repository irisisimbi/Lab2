namespace BicycleMealManagement;

public class BicycleForm : Form
{
    private readonly ComboBox bicycleType = new() { Left = 230, Top = 125, Width = 220, DropDownStyle = ComboBoxStyle.DropDownList };
    private readonly NumericUpDown hours = new() { Left = 230, Top = 180, Width = 220, Minimum = 1, Maximum = 24, Value = 1 };
    private readonly Label total = new() { Left = 230, Top = 245, Width = 250, Height = 30, Text = "Total: 0 RWF", Font = new Font("Segoe UI", 12, FontStyle.Bold) };

    public BicycleForm(string user)
    {
        Ui.Style(this, "Bicycle service");
        Controls.Add(Ui.Heading("Bicycle Service"));
        Controls.Add(Ui.Label("Bicycle type:", 90, 125, 130));
        bicycleType.Items.AddRange(new object[] { "Standard bicycle", "Mountain bicycle", "Electric bicycle" });
        bicycleType.SelectedIndex = 0;
        Controls.Add(bicycleType);

        Controls.Add(Ui.Label("Rental hours:", 90, 180, 130));
        Controls.Add(hours);
        Controls.Add(total);

        var calculate = Ui.Button("Calculate total", 230, 300, 150);
        calculate.Click += (_, _) => Calculate();
        Controls.Add(calculate);

        var back = Ui.Button("Back", 90, 365, 110);
        back.Click += (_, _) => Close();
        Controls.Add(back);

        var logout = Ui.Button("Logout", 390, 365, 110);
        logout.Click += (_, _) => { Close(); };
        Controls.Add(logout);
    }

    private void Calculate()
    {
        decimal rate = bicycleType.SelectedIndex switch { 0 => 1000m, 1 => 1500m, _ => 2500m };
        decimal amount = rate * hours.Value;
        total.Text = $"Total: {amount:N0} RWF";
        MessageBox.Show($"Bicycle: {bicycleType.Text}\nHours: {hours.Value}\nTotal: {amount:N0} RWF",
            "Bicycle rental summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
