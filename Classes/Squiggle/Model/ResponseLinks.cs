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
  public class ResponseLinks {
    
    /// <summary>
    /// Gets or Sets self
    /// </summary>
    [DataMember(Name="self", EmitDefaultValue=false)]
    public string self { get; set; }

    
    /// <summary>
    /// Gets or Sets related
    /// </summary>
    [DataMember(Name="related", EmitDefaultValue=false)]
    public string related { get; set; }

    
    /// <summary>
    /// Gets or Sets next
    /// </summary>
    [DataMember(Name="next", EmitDefaultValue=false)]
    public string next { get; set; }

    
    /// <summary>
    /// Gets or Sets last
    /// </summary>
    [DataMember(Name="last", EmitDefaultValue=false)]
    public string last { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResponseLinks {\n");
      
      sb.Append("  self: ").Append(self).Append("\n");
      
      sb.Append("  related: ").Append(related).Append("\n");
      
      sb.Append("  next: ").Append(next).Append("\n");
      
      sb.Append("  last: ").Append(last).Append("\n");
      
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
