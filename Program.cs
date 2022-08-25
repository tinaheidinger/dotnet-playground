namespace QuoteGenerator;

public static class SparrowQuoteGenerator
{
    public static String GetRandomSparrowQuote()
    {
        String[] quotes = {
        "The problem is not the problem. The problem is your attitude about the problem.",
        "If you were waiting for the opportune moment, that was it.",
        "This is the day you will always remember as the day you almost caught Captain Jack Sparrow.",
        "Why fight when you can negotiate?",
        "I'm dishonest, and a dishonest man you can always trust to be dishonest. Honestly."
        };

        var random = new Random();
        var quote = quotes[random.Next(0, quotes.Length)];
        return(quote);
    }
}