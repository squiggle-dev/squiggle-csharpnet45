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
            this.plain = null;
            this.rich = null;
            this.html = null;
            
        }

        
        /// <summary>
        /// Gets or Sets plain
        /// </summary>
        [DataMember(Name="plain", EmitDefaultValue=false)]
        public string plain { get; set; }
  
        
        /// <summary>
        /// Gets or Sets rich
        /// </summary>
        [DataMember(Name="rich", EmitDefaultValue=false)]
        public string rich { get; set; }
  
        
        /// <summary>
        /// Gets or Sets html
        /// </summary>
        [DataMember(Name="html", EmitDefaultValue=false)]
        public string html { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Signature {\n");
            sb.Append("  plain: ").Append(plain).Append("\n");
            sb.Append("  rich: ").Append(rich).Append("\n");
            sb.Append("  html: ").Append(html).Append("\n");
            
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
                    this.plain == other.plain ||
                    this.plain != null &&
                    this.plain.Equals(other.plain)
                ) && 
                (
                    this.rich == other.rich ||
                    this.rich != null &&
                    this.rich.Equals(other.rich)
                ) && 
                (
                    this.html == other.html ||
                    this.html != null &&
                    this.html.Equals(other.html)
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
                
                if (this.plain != null)
                    hash = hash * 59 + this.plain.GetHashCode();
                
                if (this.rich != null)
                    hash = hash * 59 + this.rich.GetHashCode();
                
                if (this.html != null)
                    hash = hash * 59 + this.html.GetHashCode();
                
                return hash;
            }
        }

    }
}
