using System.IO;
using System.Text.Json;

public class CovidConfig{
    public string satuan_suhu { get; set; }
    public int batas_hari_demam { get; set; }
    public string pesan_ditolak { get; set; }
    public string pesan_diterima { get; set; }

    public static CovidConfig LoadConfig(){
        string json = File.ReadAllText("covid_config.json");
        return JsonSerializer.Deserialize<CovidConfig>(json);
    }

    public void UbahSatuan(){
        if (satuan_suhu == "celcius")
            satuan_suhu = "fahrenheit";
        else
            satuan_suhu = "celcius";
    }
}