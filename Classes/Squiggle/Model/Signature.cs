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
    public class Signature :  IEquatable<Signature>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Signature" /> class.
        /// </summary>
        public Signature()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public int? Address { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public int? Template { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Plain
        /// </summary>
        [DataMember(Name="plain", EmitDefaultValue=false)]
        public string Plain { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Rich
        /// </summary>
        [DataMember(Name="rich", EmitDefaultValue=false)]
        public string Rich { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name="html", EmitDefaultValue=false)]
        public string Html { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Signature {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Plain: ").Append(Plain).Append("\n");
            sb.Append("  Rich: ").Append(Rich).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            
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
            return this.Equals(obj as Signature);
        }

        /// <summary>
        /// Returns true if Signature instances are equal
        /// </summary>
        /// <param name="other">Instance of Signature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Signature other)
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
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.Plain == other.Plain ||
                    this.Plain != null &&
                    this.Plain.Equals(other.Plain)
                ) && 
                (
                    this.Rich == other.Rich ||
                    this.Rich != null &&
                    this.Rich.Equals(other.Rich)
                ) && 
                (
                    this.Html == other.Html ||
                    this.Html != null &&
                    this.Html.Equals(other.Html)
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
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                
                if (this.Plain != null)
                    hash = hash * 59 + this.Plain.GetHashCode();
                
                if (this.Rich != null)
                    hash = hash * 59 + this.Rich.GetHashCode();
                
                if (this.Html != null)
                    hash = hash * 59 + this.Html.GetHashCode();
                
                return hash;
            }
        }

    }
}
