namespace PaddiesPackage
{
    public class PaddyPredictions
    {
        private static readonly string[] _predictions = {
        "Maximum effort! Your code will compile on the first try today!",
        "Chimichangas for lunch will fix that pesky bug",
        "Breaking the fourth wall warning: Your code comments are getting too meta",
        "You'll find a missing semicolon faster than I can heal",
        "Today's code review will be less painful than my origin story",
        "Your pull request will be approved faster than I can say 'Captain Deadpool'",
        "Stack Overflow will actually have the exact answer you need (No bamboozle!)",
        "Your debugging session will be more successful than my attempts at being an X-Men",
        "That legacy code you're afraid to touch? It's not as scary as Francis",
        "Time to catch some bugs! And by bugs, I mean actual bugs in your code"
    };

        private static readonly Random _random = new();

        public string GetDailyPrediction()
        {
            return _predictions[_random.Next(_predictions.Length)];
        }

        public string GetLuckRating()
        {
            int luck = _random.Next(1, 11);
            return $"Your luck rating today is {luck} out of 10! {(luck > 7 ? "Top o' the morning to ya!" : "Better grab a lucky charm!")}";
        }
    }
}