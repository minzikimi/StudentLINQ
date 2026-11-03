namespace StudentLINQ;
using System.Text.Json.Serialization;

public class ProgramInfo
{
    public string Name { get; set; } = "";

    [JsonPropertyName("current_semester")]
    public int CurrentSemester { get; set; }

    [JsonPropertyName("total_semesters")]
    public int TotalSemesters { get; set; }
}