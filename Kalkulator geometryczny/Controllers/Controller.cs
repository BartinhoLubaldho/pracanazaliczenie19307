using KalkulatorGeometryczny.Models;
using KalkulatorGeometryczny.Views;

namespace KalkulatorGeometryczny.Controllers
{
    public class Controller
    {
        private readonly Model _model;
        private readonly View _view;

        public Controller()
        {
            _model = new Model();
            _view = new View();
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                _view.ShowMenu();
                string choice = Console.ReadLine() ?? string.Empty; 

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter length:");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter width:");
                        double width = Convert.ToDouble(Console.ReadLine());
                        double rectangleArea = _model.CalculateRectangleArea(length, width);
                        _view.ShowResult($"Rectangle Area: {rectangleArea}");
                        break;

                    case "2":
                        Console.WriteLine("Enter radius:");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        double circleArea = _model.CalculateCircleArea(radius);
                        _view.ShowResult($"Circle Area: {circleArea}");
                        break;

                    case "3":
                        isRunning = false;
                        break;

                    default:
                        _view.ShowResult("Invalid option, try again.");
                        break;
                }
            }
        }
    }
}