using System.Text.Json;


namespace ProjectNaam {
    public class Program {
        public static void Main () {
            Movie movie = new Movie();
            var jsonStr = JsonSerializer.Serialize(movie);
        }
    }
}