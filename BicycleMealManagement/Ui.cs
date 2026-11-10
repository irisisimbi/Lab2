namespace BicycleMealManagement;

internal static class Ui
{
    public static Label Label(string text, int x, int y, int width = 150)
        => new() { Text = text, Left = x, Top = y, Width = width, Height = 28, Font = new Font("Segoe UI", 10) };

    public static TextBox TextBox(int x, int y, int width = 220, bool password = false)
        => new() { Left = x, Top = y, Width = width, Font = new Font("Segoe UI", 10), UseSystemPasswordChar = password };

    public static Button Button(string text, int x, int y, int width = 130)
        => new() { Text = text, Left = x, Top = y, Width = width, Height = 36, Font = new Font("Segoe UI", 9, FontStyle.Bold), FlatStyle = FlatStyle.Flat };

    public static void Style(Form form, string title)
    {
        form.Text = title;
        form.StartPosition = FormStartPosition.CenterScreen;
        form.Size = new Size(620, 480);
        form.MinimumSize = new Size(620, 480);
        form.BackColor = Color.FromArgb(245, 247, 250);
        form.Font = new Font("Segoe UI", 10);
    }

    public static Label Heading(string text)
        => new() { Text = text, AutoSize = false, Left = 35, Top = 25, Width = 530, Height = 48,
            Font = new Font("Segoe UI", 20, FontStyle.Bold), ForeColor = Color.FromArgb(31, 55, 85) };
}
