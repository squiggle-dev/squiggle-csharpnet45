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
    /// Gets or Sets CompanyName
    /// </summary>
    [DataMember(Name="company_name", EmitDefaultValue=false)]
    public string CompanyName { get; set; }

    
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
    /// Gets or Sets Domain
    /// </summary>
    [DataMember(Name="domain", EmitDefaultValue=false)]
    public string Domain { get; set; }

    
    /// <summary>
    /// Gets or Sets Address1
    /// </summary>
    [DataMember(Name="address1", EmitDefaultValue=false)]
    public string Address1 { get; set; }

    
    /// <summary>
    /// Gets or Sets Address2
    /// </summary>
    [DataMember(Name="address2", EmitDefaultValue=false)]
    public string Address2 { get; set; }

    
    /// <summary>
    /// Gets or Sets Address3
    /// </summary>
    [DataMember(Name="address3", EmitDefaultValue=false)]
    public string Address3 { get; set; }

    
    /// <summary>
    /// Gets or Sets AddressCity
    /// </summary>
    [DataMember(Name="address_city", EmitDefaultValue=false)]
    public string AddressCity { get; set; }

    
    /// <summary>
    /// Gets or Sets AddressPostcode
    /// </summary>
    [DataMember(Name="address_postcode", EmitDefaultValue=false)]
    public string AddressPostcode { get; set; }

    
    /// <summary>
    /// Gets or Sets AddressCountry
    /// </summary>
    [DataMember(Name="address_country", EmitDefaultValue=false)]
    public string AddressCountry { get; set; }

    
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
    /// Gets or Sets Snippet
    /// </summary>
    [DataMember(Name="snippet", EmitDefaultValue=false)]
    public int? Snippet { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class User {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Email: ").Append(Email).Append("\n");
      
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      
      sb.Append("  Domain: ").Append(Domain).Append("\n");
      
      sb.Append("  Address1: ").Append(Address1).Append("\n");
      
      sb.Append("  Address2: ").Append(Address2).Append("\n");
      
      sb.Append("  Address3: ").Append(Address3).Append("\n");
      
      sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
      
      sb.Append("  AddressPostcode: ").Append(AddressPostcode).Append("\n");
      
      sb.Append("  AddressCountry: ").Append(AddressCountry).Append("\n");
      
      sb.Append("  Linkedin: ").Append(Linkedin).Append("\n");
      
      sb.Append("  Facebook: ").Append(Facebook).Append("\n");
      
      sb.Append("  Twitter: ").Append(Twitter).Append("\n");
      
      sb.Append("  Instagram: ").Append(Instagram).Append("\n");
      
      sb.Append("  Googleplus: ").Append(Googleplus).Append("\n");
      
      sb.Append("  Snippet: ").Append(Snippet).Append("\n");
      
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
