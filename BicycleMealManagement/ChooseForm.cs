namespace BicycleMealManagement;

public class ChooseForm : Form
{
    private readonly string currentUser;

    public ChooseForm(string user)
    {
        currentUser = user;
        Ui.Style(this, "Choose an option");
        Controls.Add(Ui.Heading($"Welcome, {currentUser}"));
        Controls.Add(new Label { Text = "Please choose the service you want to use:",
            Left = 40, Top = 105, Width = 500, Height = 30 });

        var bicycle = Ui.Button("Bicycle", 115, 175, 155);
        bicycle.Click += (_, _) => { using var form = new BicycleForm(currentUser); form.ShowDialog(); };
        Controls.Add(bicycle);

        var meal = Ui.Button("Meal", 335, 175, 155);
        meal.Click += (_, _) => { using var form = new MealForm(currentUser); form.ShowDialog(); };
        Controls.Add(meal);

        var logout = Ui.Button("Logout", 225, 270, 155);
        logout.Click += (_, _) => Close();
        Controls.Add(logout);

        Controls.Add(new Label { Text = "Choose Bicycle or Meal. You can return here and log out at any time.",
            Left = 55, Top = 345, Width = 500, Height = 45, ForeColor = Color.DimGray });
    }
}
