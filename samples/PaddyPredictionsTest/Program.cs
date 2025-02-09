using PaddiesPackage;

// Create an instance of PaddyPredictions
var paddyPredictions = new PaddyPredictions();

// Print a header
Console.WriteLine("=================================");
Console.WriteLine("Paddy's Developer Predictions");
Console.WriteLine("=================================\n");

// Get and display today's prediction
Console.WriteLine("Today's Prediction:");
Console.WriteLine($"{paddyPredictions.GetDailyPrediction()}\n");

// Get and display luck rating
Console.WriteLine("Your Developer Luck Rating:");
Console.WriteLine($"{paddyPredictions.GetLuckRating()}\n");

// Wait for user input before closing
Console.WriteLine("Press any key to exit...");
Console.ReadKey();