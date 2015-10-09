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
  public class JSONWebToken {
    
    /// <summary>
    /// Gets or Sets token
    /// </summary>
    [DataMember(Name="token", EmitDefaultValue=false)]
    public string token { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JSONWebToken {\n");
      
      sb.Append("  token: ").Append(token).Append("\n");
      
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
