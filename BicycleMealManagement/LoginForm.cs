namespace BicycleMealManagement;

public class LoginForm : Form
{
    private readonly TextBox username = Ui.TextBox(205, 155);
    private readonly TextBox password = Ui.TextBox(205, 205, password: true);

    public LoginForm()
    {
        Ui.Style(this, "Bicycle & Meal Management - Login");
        Controls.Add(Ui.Heading("Bicycle & Meal Management"));
        Controls.Add(Ui.Label("Username:", 105, 155, 95));
        Controls.Add(Ui.Label("Password:", 105, 205, 95));
        Controls.Add(username);
        Controls.Add(password);

        var login = Ui.Button("Login", 205, 265, 220);
        login.Click += (_, _) => Login();
        Controls.Add(login);

        var hint = new Label { Text = "Demo account: admin  |  Password: 1234",
            Left = 130, Top = 325, Width = 370, Height = 28, ForeColor = Color.DimGray };
        Controls.Add(hint);
        AcceptButton = login;
    }

    private void Login()
    {
        if (username.Text.Trim() == "admin" && password.Text == "1234")
        {
            Hide();
            using var menu = new ChooseForm(username.Text.Trim());
            menu.ShowDialog();
            Close();
        }
        else
        {
            MessageBox.Show("Invalid username or password. Please try again.",
                "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            password.Clear();
            password.Focus();
        }
    }
}
