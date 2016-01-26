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
    public class Address :  IEquatable<Address>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        public Address()
        {
            this.id = null;
            this.email = null;
            this.password = null;
            this.firstName = null;
            this.lastName = null;
            this.jobTitle = null;
            this.telMobile = null;
            this.telDirect = null;
            this.linkedin = null;
            this.facebook = null;
            this.twitter = null;
            this.instagram = null;
            this.googleplus = null;
            this.signatures = null;
            this.user = null;
            
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
        /// Gets or Sets signatures
        /// </summary>
        [DataMember(Name="signatures", EmitDefaultValue=false)]
        public List<Signature> signatures { get; set; }
  
        
        /// <summary>
        /// Gets or Sets user
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? user { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
            sb.Append("  signatures: ").Append(signatures).Append("\n");
            sb.Append("  user: ").Append(user).Append("\n");
            
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
            return this.Equals(obj as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="other">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address other)
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
                    this.password == other.password ||
                    this.password != null &&
                    this.password.Equals(other.password)
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
                    this.jobTitle == other.jobTitle ||
                    this.jobTitle != null &&
                    this.jobTitle.Equals(other.jobTitle)
                ) && 
                (
                    this.telMobile == other.telMobile ||
                    this.telMobile != null &&
                    this.telMobile.Equals(other.telMobile)
                ) && 
                (
                    this.telDirect == other.telDirect ||
                    this.telDirect != null &&
                    this.telDirect.Equals(other.telDirect)
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
                    this.signatures == other.signatures ||
                    this.signatures != null &&
                    this.signatures.SequenceEqual(other.signatures)
                ) && 
                (
                    this.user == other.user ||
                    this.user != null &&
                    this.user.Equals(other.user)
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
                
                if (this.password != null)
                    hash = hash * 59 + this.password.GetHashCode();
                
                if (this.firstName != null)
                    hash = hash * 59 + this.firstName.GetHashCode();
                
                if (this.lastName != null)
                    hash = hash * 59 + this.lastName.GetHashCode();
                
                if (this.jobTitle != null)
                    hash = hash * 59 + this.jobTitle.GetHashCode();
                
                if (this.telMobile != null)
                    hash = hash * 59 + this.telMobile.GetHashCode();
                
                if (this.telDirect != null)
                    hash = hash * 59 + this.telDirect.GetHashCode();
                
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
                
                if (this.signatures != null)
                    hash = hash * 59 + this.signatures.GetHashCode();
                
                if (this.user != null)
                    hash = hash * 59 + this.user.GetHashCode();
                
                return hash;
            }
        }

    }
}
