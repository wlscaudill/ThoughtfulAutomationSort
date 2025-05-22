using ThoughtfulAutomationSort.Domain;

namespace ThoughtfulAutomationSort.Console
{
    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                // Would use an argument parsing library without time contraint.
                if (args.Length != 4)
                {
                    System.Console.WriteLine("Invalid usage; provide arguments width, height, length, mass (dimensions in cm and mass in kg)");
                    return 1;
                }

                var validWidth = int.TryParse(args[0], out var width);
                if (!validWidth || width <= 0)
                {
                    System.Console.WriteLine("Invalid usage; width should be positive non-zero integer value.");
                    return 1;
                }

                var validHeight = int.TryParse(args[1], out var height);
                if (!validHeight || height <= 0)
                {
                    System.Console.WriteLine("Invalid usage; height should be positive non-zero integer value.");
                    return 1;
                }

                var validLength = int.TryParse(args[2], out var length);
                if (!validLength || length <= 0)
                {
                    System.Console.WriteLine("Invalid usage; length should be positive non-zero integer value.");
                    return 1;
                }

                var validMass = int.TryParse(args[3], out var mass);
                if (!validMass || mass <= 0)
                {
                    System.Console.WriteLine("Invalid usage; mass should be positive non-zero integer value.");
                    return 1;
                }

                var package = new Package(width, height, length, mass);
                System.Console.WriteLine($"Considering package; width: {package.Width}cm, height: {package.Height}cm, length: {package.Length}cm, mass: {package.Mass}kg");

                var evaluation = new Evaluator().Evaluate(package);
                System.Console.WriteLine($"Evaluated package; bulky: {evaluation.IsBulky}, heavy: {evaluation.IsHeavy}");

                var sortResult = new Dispatcher().Sort(evaluation);
                System.Console.WriteLine($"Sorted package; stack: {sortResult.SortStack}");

                return 0;
            }
            catch (System.Exception ex)
            {
                System.Console.Error.WriteLine($"Encountered unexpected error: {ex}");
                return 1;
            }
        }
    }
}
