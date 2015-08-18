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
  public class Snippet {
    
    /// <summary>
    /// Gets or Sets id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? id { get; set; }

    
    /// <summary>
    /// Gets or Sets contentHtml
    /// </summary>
    [DataMember(Name="content_html", EmitDefaultValue=false)]
    public string contentHtml { get; set; }

    
    /// <summary>
    /// Gets or Sets contentPlaintext
    /// </summary>
    [DataMember(Name="content_plaintext", EmitDefaultValue=false)]
    public string contentPlaintext { get; set; }

    
    /// <summary>
    /// Gets or Sets contentRichtext
    /// </summary>
    [DataMember(Name="content_richtext", EmitDefaultValue=false)]
    public string contentRichtext { get; set; }

    
    /// <summary>
    /// Gets or Sets thumbnail
    /// </summary>
    [DataMember(Name="thumbnail", EmitDefaultValue=false)]
    public string thumbnail { get; set; }

    
    /// <summary>
    /// Gets or Sets user
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    public int? user { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Snippet {\n");
      
      sb.Append("  id: ").Append(id).Append("\n");
      
      sb.Append("  contentHtml: ").Append(contentHtml).Append("\n");
      
      sb.Append("  contentPlaintext: ").Append(contentPlaintext).Append("\n");
      
      sb.Append("  contentRichtext: ").Append(contentRichtext).Append("\n");
      
      sb.Append("  thumbnail: ").Append(thumbnail).Append("\n");
      
      sb.Append("  user: ").Append(user).Append("\n");
      
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
