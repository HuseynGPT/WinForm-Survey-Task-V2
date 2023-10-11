using Newtonsoft.Json;
using System.Text.Json;

namespace Survey_Task_V2.Models;

 public class JsonHandling
{
    static public void WriteAnketToJson(string path, Anket anket)
    {
        string json = JsonConvert.SerializeObject(anket, Formatting.Indented);
        File.WriteAllText(path + anket.name + ".json", json);
    
    }

    static public Anket ReadAnketFromJson(string path) {
        string json = File.ReadAllText(path);
        Anket anket = JsonConvert.DeserializeObject<Anket>(json);
        return anket;
    
    }



}
