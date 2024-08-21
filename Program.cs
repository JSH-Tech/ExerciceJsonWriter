using System.Text;
using System.Text.Json;

namespace ExerciceJsonWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var memStream= new MemoryStream();

            var writer= new Utf8JsonWriter(memStream,new JsonWriterOptions {Indented=true});

            writer.WriteStartObject();//Accolade de debut 

            writer.WritePropertyName("Nom");
            writer.WriteStringValue("Mamellon");

            writer.WritePropertyName("Prenom");
            writer.WriteStringValue("Christophe");

            writer.WritePropertyName("Age");
            writer.WriteNumberValue(33);

            writer.WriteEndObject();//Accolade de fin
            writer.Flush();

            memStream.Position=0;
            Console.WriteLine(Encoding.UTF8.GetString(memStream.ToArray()));
        }
    }
}
