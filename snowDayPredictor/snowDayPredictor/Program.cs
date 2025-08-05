namespace snowDayPredictor
{
    public class WeatherPrediction
    {
        int id;
        string date;
        double tempMax;
        double tempMin;
        double humidity;
        double snow;
        double snowDepth;
        double visibility;
        string conditions;
        string description;


        public WeatherPrediction(int id, string date, double tempMax, double tempMin, double humidity, double snow, double snowDepth, double visibility, string conditions, string description)
        {
            this.id = id;
            this.date = date;
            this.tempMax = tempMax;
            this.tempMin = tempMin;
            this.humidity = humidity;
            this.snow = snow;
            this.snowDepth = snowDepth;
            this.visibility = visibility;
            this.conditions = conditions;
            this.description = description;
        }


        public override string ToString()
        {
            return $"id: {id}\ndate: {date}, \nTemp Min: {tempMin}, Temp Max: {tempMax}, Humidity: {humidity}, Snow: {snow}, Snow Depth: {snowDepth}, Visibility: {visibility}, \nConditions: {conditions}, Description: {description}";
        }


    }




    internal class Program
    {

        static void Main(string[] args)
        {
            List<WeatherPrediction> weatherPredictions = new List<WeatherPrediction>();
            int index = 0;
            StreamReader sr = new StreamReader("predictions.csv");

            string[] lines = sr.ReadToEnd().Split('\n');

            sr.Close();

            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(",");


                weatherPredictions.Add(new WeatherPrediction(index, split[1], Convert.ToDouble(split[2]), Convert.ToDouble(split[3]), Convert.ToDouble(split[9]), Convert.ToDouble(split[14]), Convert.ToDouble(split[15]), Convert.ToDouble(split[21]), split[29], split[30]));
                index++;
            }


            Console.WriteLine(String.Join("\n\n", weatherPredictions));



            Console.ReadLine();
        }
    }
}
