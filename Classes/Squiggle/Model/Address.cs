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
  public class Address {
    
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    public string Email { get; set; }

    
    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name="first_name", EmitDefaultValue=false)]
    public string FirstName { get; set; }

    
    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [DataMember(Name="last_name", EmitDefaultValue=false)]
    public string LastName { get; set; }

    
    /// <summary>
    /// Gets or Sets JobTitle
    /// </summary>
    [DataMember(Name="job_title", EmitDefaultValue=false)]
    public string JobTitle { get; set; }

    
    /// <summary>
    /// Gets or Sets TelMobile
    /// </summary>
    [DataMember(Name="tel_mobile", EmitDefaultValue=false)]
    public string TelMobile { get; set; }

    
    /// <summary>
    /// Gets or Sets TelDirect
    /// </summary>
    [DataMember(Name="tel_direct", EmitDefaultValue=false)]
    public string TelDirect { get; set; }

    
    /// <summary>
    /// Gets or Sets Linkedin
    /// </summary>
    [DataMember(Name="linkedin", EmitDefaultValue=false)]
    public string Linkedin { get; set; }

    
    /// <summary>
    /// Gets or Sets Facebook
    /// </summary>
    [DataMember(Name="facebook", EmitDefaultValue=false)]
    public string Facebook { get; set; }

    
    /// <summary>
    /// Gets or Sets Twitter
    /// </summary>
    [DataMember(Name="twitter", EmitDefaultValue=false)]
    public string Twitter { get; set; }

    
    /// <summary>
    /// Gets or Sets Instagram
    /// </summary>
    [DataMember(Name="instagram", EmitDefaultValue=false)]
    public string Instagram { get; set; }

    
    /// <summary>
    /// Gets or Sets Googleplus
    /// </summary>
    [DataMember(Name="googleplus", EmitDefaultValue=false)]
    public string Googleplus { get; set; }

    
    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    public int? User { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Address {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Email: ").Append(Email).Append("\n");
      
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      
      sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
      
      sb.Append("  TelMobile: ").Append(TelMobile).Append("\n");
      
      sb.Append("  TelDirect: ").Append(TelDirect).Append("\n");
      
      sb.Append("  Linkedin: ").Append(Linkedin).Append("\n");
      
      sb.Append("  Facebook: ").Append(Facebook).Append("\n");
      
      sb.Append("  Twitter: ").Append(Twitter).Append("\n");
      
      sb.Append("  Instagram: ").Append(Instagram).Append("\n");
      
      sb.Append("  Googleplus: ").Append(Googleplus).Append("\n");
      
      sb.Append("  User: ").Append(User).Append("\n");
      
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
