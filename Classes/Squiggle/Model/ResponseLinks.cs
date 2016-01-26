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
    public class ResponseLinks :  IEquatable<ResponseLinks>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseLinks" /> class.
        /// </summary>
        public ResponseLinks()
        {
            this.self = null;
            this.related = null;
            this.next = null;
            this.last = null;
            
        }

        
        /// <summary>
        /// Gets or Sets self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public string self { get; set; }
  
        
        /// <summary>
        /// Gets or Sets related
        /// </summary>
        [DataMember(Name="related", EmitDefaultValue=false)]
        public string related { get; set; }
  
        
        /// <summary>
        /// Gets or Sets next
        /// </summary>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public string next { get; set; }
  
        
        /// <summary>
        /// Gets or Sets last
        /// </summary>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public string last { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseLinks {\n");
            sb.Append("  self: ").Append(self).Append("\n");
            sb.Append("  related: ").Append(related).Append("\n");
            sb.Append("  next: ").Append(next).Append("\n");
            sb.Append("  last: ").Append(last).Append("\n");
            
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
            return this.Equals(obj as ResponseLinks);
        }

        /// <summary>
        /// Returns true if ResponseLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.self == other.self ||
                    this.self != null &&
                    this.self.Equals(other.self)
                ) && 
                (
                    this.related == other.related ||
                    this.related != null &&
                    this.related.Equals(other.related)
                ) && 
                (
                    this.next == other.next ||
                    this.next != null &&
                    this.next.Equals(other.next)
                ) && 
                (
                    this.last == other.last ||
                    this.last != null &&
                    this.last.Equals(other.last)
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
                
                if (this.self != null)
                    hash = hash * 59 + this.self.GetHashCode();
                
                if (this.related != null)
                    hash = hash * 59 + this.related.GetHashCode();
                
                if (this.next != null)
                    hash = hash * 59 + this.next.GetHashCode();
                
                if (this.last != null)
                    hash = hash * 59 + this.last.GetHashCode();
                
                return hash;
            }
        }

    }
}
