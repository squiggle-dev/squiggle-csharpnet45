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
  public class SnippetResponseSingle : Response {
    
    /// <summary>
    /// Gets or Sets data
    /// </summary>
    [DataMember(Name="data", EmitDefaultValue=false)]
    public Snippet data { get; set; }

    
    /// <summary>
    /// Gets or Sets links
    /// </summary>
    [DataMember(Name="links", EmitDefaultValue=false)]
    public ResponseLinks links { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SnippetResponseSingle {\n");
      
      sb.Append("  data: ").Append(data).Append("\n");
      
      sb.Append("  links: ").Append(links).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
