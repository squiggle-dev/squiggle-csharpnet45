using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Squiggle.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Signature {
    
    /// <summary>
    /// Gets or Sets plain
    /// </summary>
    [DataMember(Name="plain", EmitDefaultValue=false)]
    public string plain { get; set; }

    
    /// <summary>
    /// Gets or Sets rich
    /// </summary>
    [DataMember(Name="rich", EmitDefaultValue=false)]
    public string rich { get; set; }

    
    /// <summary>
    /// Gets or Sets html
    /// </summary>
    [DataMember(Name="html", EmitDefaultValue=false)]
    public string html { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Signature {\n");
      
      sb.Append("  plain: ").Append(plain).Append("\n");
      
      sb.Append("  rich: ").Append(rich).Append("\n");
      
      sb.Append("  html: ").Append(html).Append("\n");
      
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
