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
  public class User {
    
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
    /// Gets or Sets companyName
    /// </summary>
    [DataMember(Name="company_name", EmitDefaultValue=false)]
    public string companyName { get; set; }

    
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
    /// Gets or Sets domain
    /// </summary>
    [DataMember(Name="domain", EmitDefaultValue=false)]
    public string domain { get; set; }

    
    /// <summary>
    /// Gets or Sets address1
    /// </summary>
    [DataMember(Name="address1", EmitDefaultValue=false)]
    public string address1 { get; set; }

    
    /// <summary>
    /// Gets or Sets address2
    /// </summary>
    [DataMember(Name="address2", EmitDefaultValue=false)]
    public string address2 { get; set; }

    
    /// <summary>
    /// Gets or Sets address3
    /// </summary>
    [DataMember(Name="address3", EmitDefaultValue=false)]
    public string address3 { get; set; }

    
    /// <summary>
    /// Gets or Sets addressCity
    /// </summary>
    [DataMember(Name="address_city", EmitDefaultValue=false)]
    public string addressCity { get; set; }

    
    /// <summary>
    /// Gets or Sets addressPostcode
    /// </summary>
    [DataMember(Name="address_postcode", EmitDefaultValue=false)]
    public string addressPostcode { get; set; }

    
    /// <summary>
    /// Gets or Sets addressCountry
    /// </summary>
    [DataMember(Name="address_country", EmitDefaultValue=false)]
    public string addressCountry { get; set; }

    
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
    /// Gets or Sets snippet
    /// </summary>
    [DataMember(Name="snippet", EmitDefaultValue=false)]
    public int? snippet { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class User {\n");
      
      sb.Append("  id: ").Append(id).Append("\n");
      
      sb.Append("  email: ").Append(email).Append("\n");
      
      sb.Append("  companyName: ").Append(companyName).Append("\n");
      
      sb.Append("  firstName: ").Append(firstName).Append("\n");
      
      sb.Append("  lastName: ").Append(lastName).Append("\n");
      
      sb.Append("  domain: ").Append(domain).Append("\n");
      
      sb.Append("  address1: ").Append(address1).Append("\n");
      
      sb.Append("  address2: ").Append(address2).Append("\n");
      
      sb.Append("  address3: ").Append(address3).Append("\n");
      
      sb.Append("  addressCity: ").Append(addressCity).Append("\n");
      
      sb.Append("  addressPostcode: ").Append(addressPostcode).Append("\n");
      
      sb.Append("  addressCountry: ").Append(addressCountry).Append("\n");
      
      sb.Append("  linkedin: ").Append(linkedin).Append("\n");
      
      sb.Append("  facebook: ").Append(facebook).Append("\n");
      
      sb.Append("  twitter: ").Append(twitter).Append("\n");
      
      sb.Append("  instagram: ").Append(instagram).Append("\n");
      
      sb.Append("  googleplus: ").Append(googleplus).Append("\n");
      
      sb.Append("  snippet: ").Append(snippet).Append("\n");
      
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
