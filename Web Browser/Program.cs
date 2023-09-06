using System.Text.RegularExpressions;
using Web_Browser;

internal class Program
{
    private static HttpFetcher fetcher = new HttpFetcher();
    private static RegexService regexService = new RegexService();

    private static async Task Main()
    {
        //Get respone string from server
        string response = await fetcher.GetResponse("http://www.contoso.com");


        //Define regex pattern to be used
        string regexPattern = "<.*?>";
        //Print result
        await Console.Out.WriteLineAsync(regexService.DoRegexMagic(response,regexPattern)); 
    }
}