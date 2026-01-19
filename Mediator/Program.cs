using Mediator.Example1;
using Mediator.Example2;

namespace Mediator;

internal class Program
{
    static void Main(string[] args)
    {
        //FormMediator mediator = new FormMediator();

        //TextField usernameField = new TextField(mediator);
        //TextField passwordField = new TextField(mediator);
        //Button loginButton = new Button(mediator);
        //Label statusLabel = new Label(mediator);

        //mediator.SetUsernameField(usernameField);
        //mediator.SetPasswordField(passwordField);
        //mediator.SetLoginButton(loginButton);
        //mediator.SetStatusLabel(statusLabel);

        //// Simulate user interaction
        //usernameField.SetText("admin");
        //passwordField.SetText("1234");
        //loginButton.Click(); // Should succeed

        //Console.WriteLine("\n--- New Attempt with Wrong Password ---");
        //passwordField.SetText("wrong");
        //loginButton.Click(); // Should fail



        var controlTower = new AirTrafficControlTower();

        var plane1 = new Airplane("Plane A", controlTower);
        var plane2 = new Airplane("Plane B", controlTower);
        var plane3 = new Airplane("Plane C", controlTower);

        controlTower.RegisterPlane(plane1);
        controlTower.RegisterPlane(plane2);
        controlTower.RegisterPlane(plane3);

        plane1.RequestTakeoff();
        plane2.RequestLanding();
        plane3.RequestTakeoff();
    }
}
