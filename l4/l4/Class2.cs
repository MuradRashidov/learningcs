using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4
{
    internal class Class2
    {
        internal static async Task Main()
        {
            const string ApiUrl = "https://catfact.ninja/fact";
            bool isContinue;
            HttpClient client = new HttpClient();

            do
            {
                var  res = await client.GetAsync("https://catfact.ninja/fact");
                string result = await res.Content.ReadAsStringAsync();
                //r cf = JsonConvert.DeserializeObject<CatFact>(result);
                Console.WriteLine(result); 
                Console.WriteLine(5);

                isContinue = Convert.ToBoolean(Console.ReadLine());
            } while (true);

        }
    }

    public class CatFact
    {
        public string Fact { get; set; }
        public int Length { get ; set; }
    }
}