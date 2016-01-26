using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Squiggle.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class User :  IEquatable<User>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
            
        }

        
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="other">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) && 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Address2 == other.Address2 ||
                    this.Address2 != null &&
                    this.Address2.Equals(other.Address2)
                ) && 
                (
                    this.Address3 == other.Address3 ||
                    this.Address3 != null &&
                    this.Address3.Equals(other.Address3)
                ) && 
                (
                    this.AddressCity == other.AddressCity ||
                    this.AddressCity != null &&
                    this.AddressCity.Equals(other.AddressCity)
                ) && 
                (
                    this.AddressPostcode == other.AddressPostcode ||
                    this.AddressPostcode != null &&
                    this.AddressPostcode.Equals(other.AddressPostcode)
                ) && 
                (
                    this.AddressCountry == other.AddressCountry ||
                    this.AddressCountry != null &&
                    this.AddressCountry.Equals(other.AddressCountry)
                ) && 
                (
                    this.Linkedin == other.Linkedin ||
                    this.Linkedin != null &&
                    this.Linkedin.Equals(other.Linkedin)
                ) && 
                (
                    this.Facebook == other.Facebook ||
                    this.Facebook != null &&
                    this.Facebook.Equals(other.Facebook)
                ) && 
                (
                    this.Twitter == other.Twitter ||
                    this.Twitter != null &&
                    this.Twitter.Equals(other.Twitter)
                ) && 
                (
                    this.Instagram == other.Instagram ||
                    this.Instagram != null &&
                    this.Instagram.Equals(other.Instagram)
                ) && 
                (
                    this.Googleplus == other.Googleplus ||
                    this.Googleplus != null &&
                    this.Googleplus.Equals(other.Googleplus)
                ) && 
                (
                    this.Snippet == other.Snippet ||
                    this.Snippet != null &&
                    this.Snippet.Equals(other.Snippet)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                
                if (this.Address2 != null)
                    hash = hash * 59 + this.Address2.GetHashCode();
                
                if (this.Address3 != null)
                    hash = hash * 59 + this.Address3.GetHashCode();
                
                if (this.AddressCity != null)
                    hash = hash * 59 + this.AddressCity.GetHashCode();
                
                if (this.AddressPostcode != null)
                    hash = hash * 59 + this.AddressPostcode.GetHashCode();
                
                if (this.AddressCountry != null)
                    hash = hash * 59 + this.AddressCountry.GetHashCode();
                
                if (this.Linkedin != null)
                    hash = hash * 59 + this.Linkedin.GetHashCode();
                
                if (this.Facebook != null)
                    hash = hash * 59 + this.Facebook.GetHashCode();
                
                if (this.Twitter != null)
                    hash = hash * 59 + this.Twitter.GetHashCode();
                
                if (this.Instagram != null)
                    hash = hash * 59 + this.Instagram.GetHashCode();
                
                if (this.Googleplus != null)
                    hash = hash * 59 + this.Googleplus.GetHashCode();
                
                if (this.Snippet != null)
                    hash = hash * 59 + this.Snippet.GetHashCode();
                
                return hash;
            }
        }

    }
}
