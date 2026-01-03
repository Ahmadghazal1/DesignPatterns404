using Mediator.Example1;

namespace Mediator;

internal class Program
{
    static void Main(string[] args)
    {
        FormMediator mediator = new FormMediator();

        TextField usernameField = new TextField(mediator);
        TextField passwordField = new TextField(mediator);
        Button loginButton = new Button(mediator);
        Label statusLabel = new Label(mediator);

        mediator.SetUsernameField(usernameField);
        mediator.SetPasswordField(passwordField);
        mediator.SetLoginButton(loginButton);
        mediator.SetStatusLabel(statusLabel);

        // Simulate user interaction
        usernameField.SetText("admin");
        passwordField.SetText("1234");
        loginButton.Click(); // Should succeed

        Console.WriteLine("\n--- New Attempt with Wrong Password ---");
        passwordField.SetText("wrong");
        loginButton.Click(); // Should fail
    }
}
