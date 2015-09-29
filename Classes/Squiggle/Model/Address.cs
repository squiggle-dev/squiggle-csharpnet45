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
    /// Gets or Sets id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? id { get; set; }

    
    /// <summary>
    /// Gets or Sets email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    public string email { get; set; }

    
    /// <summary>
    /// Gets or Sets password
    /// </summary>
    [DataMember(Name="password", EmitDefaultValue=false)]
    public string password { get; set; }

    
    /// <summary>
    /// Gets or Sets firstName
    /// </summary>
    [DataMember(Name="first_name", EmitDefaultValue=false)]
    public string firstName { get; set; }

    
    /// <summary>
    /// Gets or Sets lastName
    /// </summary>
    [DataMember(Name="last_name", EmitDefaultValue=false)]
    public string lastName { get; set; }

    
    /// <summary>
    /// Gets or Sets jobTitle
    /// </summary>
    [DataMember(Name="job_title", EmitDefaultValue=false)]
    public string jobTitle { get; set; }

    
    /// <summary>
    /// Gets or Sets telMobile
    /// </summary>
    [DataMember(Name="tel_mobile", EmitDefaultValue=false)]
    public string telMobile { get; set; }

    
    /// <summary>
    /// Gets or Sets telDirect
    /// </summary>
    [DataMember(Name="tel_direct", EmitDefaultValue=false)]
    public string telDirect { get; set; }

    
    /// <summary>
    /// Gets or Sets linkedin
    /// </summary>
    [DataMember(Name="linkedin", EmitDefaultValue=false)]
    public string linkedin { get; set; }

    
    /// <summary>
    /// Gets or Sets facebook
    /// </summary>
    [DataMember(Name="facebook", EmitDefaultValue=false)]
    public string facebook { get; set; }

    
    /// <summary>
    /// Gets or Sets twitter
    /// </summary>
    [DataMember(Name="twitter", EmitDefaultValue=false)]
    public string twitter { get; set; }

    
    /// <summary>
    /// Gets or Sets instagram
    /// </summary>
    [DataMember(Name="instagram", EmitDefaultValue=false)]
    public string instagram { get; set; }

    
    /// <summary>
    /// Gets or Sets googleplus
    /// </summary>
    [DataMember(Name="googleplus", EmitDefaultValue=false)]
    public string googleplus { get; set; }

    
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
      sb.Append("class Address {\n");
      
      sb.Append("  id: ").Append(id).Append("\n");
      
      sb.Append("  email: ").Append(email).Append("\n");
      
      sb.Append("  password: ").Append(password).Append("\n");
      
      sb.Append("  firstName: ").Append(firstName).Append("\n");
      
      sb.Append("  lastName: ").Append(lastName).Append("\n");
      
      sb.Append("  jobTitle: ").Append(jobTitle).Append("\n");
      
      sb.Append("  telMobile: ").Append(telMobile).Append("\n");
      
      sb.Append("  telDirect: ").Append(telDirect).Append("\n");
      
      sb.Append("  linkedin: ").Append(linkedin).Append("\n");
      
      sb.Append("  facebook: ").Append(facebook).Append("\n");
      
      sb.Append("  twitter: ").Append(twitter).Append("\n");
      
      sb.Append("  instagram: ").Append(instagram).Append("\n");
      
      sb.Append("  googleplus: ").Append(googleplus).Append("\n");
      
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
