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
  public class AddressResp {
    
    /// <summary>
    /// Gets or Sets address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    public Address address { get; set; }

    
    /// <summary>
    /// Gets or Sets signatures
    /// </summary>
    [DataMember(Name="signatures", EmitDefaultValue=false)]
    public Signature signatures { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AddressResp {\n");
      
      sb.Append("  address: ").Append(address).Append("\n");
      
      sb.Append("  signatures: ").Append(signatures).Append("\n");
      
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
