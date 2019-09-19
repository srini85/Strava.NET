using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Strava.NET.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class MetaAthlete {
    /// <summary>
    /// The unique identifier of the athlete
    /// </summary>
    /// <value>The unique identifier of the athlete</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MetaAthlete {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
