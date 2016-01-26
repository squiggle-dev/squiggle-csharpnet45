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
            this.id = null;
            this.email = null;
            this.companyName = null;
            this.firstName = null;
            this.lastName = null;
            this.domain = null;
            this.address1 = null;
            this.address2 = null;
            this.address3 = null;
            this.addressCity = null;
            this.addressPostcode = null;
            this.addressCountry = null;
            this.linkedin = null;
            this.facebook = null;
            this.twitter = null;
            this.instagram = null;
            this.googleplus = null;
            this.snippet = null;
            
        }

        
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
                    this.id == other.id ||
                    this.id != null &&
                    this.id.Equals(other.id)
                ) && 
                (
                    this.email == other.email ||
                    this.email != null &&
                    this.email.Equals(other.email)
                ) && 
                (
                    this.companyName == other.companyName ||
                    this.companyName != null &&
                    this.companyName.Equals(other.companyName)
                ) && 
                (
                    this.firstName == other.firstName ||
                    this.firstName != null &&
                    this.firstName.Equals(other.firstName)
                ) && 
                (
                    this.lastName == other.lastName ||
                    this.lastName != null &&
                    this.lastName.Equals(other.lastName)
                ) && 
                (
                    this.domain == other.domain ||
                    this.domain != null &&
                    this.domain.Equals(other.domain)
                ) && 
                (
                    this.address1 == other.address1 ||
                    this.address1 != null &&
                    this.address1.Equals(other.address1)
                ) && 
                (
                    this.address2 == other.address2 ||
                    this.address2 != null &&
                    this.address2.Equals(other.address2)
                ) && 
                (
                    this.address3 == other.address3 ||
                    this.address3 != null &&
                    this.address3.Equals(other.address3)
                ) && 
                (
                    this.addressCity == other.addressCity ||
                    this.addressCity != null &&
                    this.addressCity.Equals(other.addressCity)
                ) && 
                (
                    this.addressPostcode == other.addressPostcode ||
                    this.addressPostcode != null &&
                    this.addressPostcode.Equals(other.addressPostcode)
                ) && 
                (
                    this.addressCountry == other.addressCountry ||
                    this.addressCountry != null &&
                    this.addressCountry.Equals(other.addressCountry)
                ) && 
                (
                    this.linkedin == other.linkedin ||
                    this.linkedin != null &&
                    this.linkedin.Equals(other.linkedin)
                ) && 
                (
                    this.facebook == other.facebook ||
                    this.facebook != null &&
                    this.facebook.Equals(other.facebook)
                ) && 
                (
                    this.twitter == other.twitter ||
                    this.twitter != null &&
                    this.twitter.Equals(other.twitter)
                ) && 
                (
                    this.instagram == other.instagram ||
                    this.instagram != null &&
                    this.instagram.Equals(other.instagram)
                ) && 
                (
                    this.googleplus == other.googleplus ||
                    this.googleplus != null &&
                    this.googleplus.Equals(other.googleplus)
                ) && 
                (
                    this.snippet == other.snippet ||
                    this.snippet != null &&
                    this.snippet.Equals(other.snippet)
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
                
                if (this.id != null)
                    hash = hash * 59 + this.id.GetHashCode();
                
                if (this.email != null)
                    hash = hash * 59 + this.email.GetHashCode();
                
                if (this.companyName != null)
                    hash = hash * 59 + this.companyName.GetHashCode();
                
                if (this.firstName != null)
                    hash = hash * 59 + this.firstName.GetHashCode();
                
                if (this.lastName != null)
                    hash = hash * 59 + this.lastName.GetHashCode();
                
                if (this.domain != null)
                    hash = hash * 59 + this.domain.GetHashCode();
                
                if (this.address1 != null)
                    hash = hash * 59 + this.address1.GetHashCode();
                
                if (this.address2 != null)
                    hash = hash * 59 + this.address2.GetHashCode();
                
                if (this.address3 != null)
                    hash = hash * 59 + this.address3.GetHashCode();
                
                if (this.addressCity != null)
                    hash = hash * 59 + this.addressCity.GetHashCode();
                
                if (this.addressPostcode != null)
                    hash = hash * 59 + this.addressPostcode.GetHashCode();
                
                if (this.addressCountry != null)
                    hash = hash * 59 + this.addressCountry.GetHashCode();
                
                if (this.linkedin != null)
                    hash = hash * 59 + this.linkedin.GetHashCode();
                
                if (this.facebook != null)
                    hash = hash * 59 + this.facebook.GetHashCode();
                
                if (this.twitter != null)
                    hash = hash * 59 + this.twitter.GetHashCode();
                
                if (this.instagram != null)
                    hash = hash * 59 + this.instagram.GetHashCode();
                
                if (this.googleplus != null)
                    hash = hash * 59 + this.googleplus.GetHashCode();
                
                if (this.snippet != null)
                    hash = hash * 59 + this.snippet.GetHashCode();
                
                return hash;
            }
        }

    }
}
