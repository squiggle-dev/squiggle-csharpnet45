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
    public class SignatureResponseMultiple : Response,  IEquatable<SignatureResponseMultiple>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureResponseMultiple" /> class.
        /// </summary>
        public SignatureResponseMultiple()
        {
            this.data = null;
            this.links = null;
            
        }

        
        /// <summary>
        /// Gets or Sets data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<Signature> data { get; set; }
  
        
        /// <summary>
        /// Gets or Sets links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public ResponseLinks links { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignatureResponseMultiple {\n");
            sb.Append("  data: ").Append(data).Append("\n");
            sb.Append("  links: ").Append(links).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(obj as SignatureResponseMultiple);
        }

        /// <summary>
        /// Returns true if SignatureResponseMultiple instances are equal
        /// </summary>
        /// <param name="other">Instance of SignatureResponseMultiple to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureResponseMultiple other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.data == other.data ||
                    this.data != null &&
                    this.data.SequenceEqual(other.data)
                ) && 
                (
                    this.links == other.links ||
                    this.links != null &&
                    this.links.Equals(other.links)
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
                
                if (this.data != null)
                    hash = hash * 59 + this.data.GetHashCode();
                
                if (this.links != null)
                    hash = hash * 59 + this.links.GetHashCode();
                
                return hash;
            }
        }

    }
}
