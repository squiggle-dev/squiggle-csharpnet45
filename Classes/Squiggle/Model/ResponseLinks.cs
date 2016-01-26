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
            
        }

        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public string Self { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Related
        /// </summary>
        [DataMember(Name="related", EmitDefaultValue=false)]
        public string Related { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public string Next { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public string Last { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Related: ").Append(Related).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            
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
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.Related == other.Related ||
                    this.Related != null &&
                    this.Related.Equals(other.Related)
                ) && 
                (
                    this.Next == other.Next ||
                    this.Next != null &&
                    this.Next.Equals(other.Next)
                ) && 
                (
                    this.Last == other.Last ||
                    this.Last != null &&
                    this.Last.Equals(other.Last)
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
                
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                
                if (this.Related != null)
                    hash = hash * 59 + this.Related.GetHashCode();
                
                if (this.Next != null)
                    hash = hash * 59 + this.Next.GetHashCode();
                
                if (this.Last != null)
                    hash = hash * 59 + this.Last.GetHashCode();
                
                return hash;
            }
        }

    }
}
