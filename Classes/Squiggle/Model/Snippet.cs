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
    public class Snippet :  IEquatable<Snippet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Snippet" /> class.
        /// </summary>
        public Snippet()
        {
            this.id = null;
            this.contentHtml = null;
            this.contentPlaintext = null;
            this.contentRichtext = null;
            this.thumbnail = null;
            this.user = null;
            
        }

        
        /// <summary>
        /// Gets or Sets id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets contentHtml
        /// </summary>
        [DataMember(Name="content_html", EmitDefaultValue=false)]
        public string contentHtml { get; set; }
  
        
        /// <summary>
        /// Gets or Sets contentPlaintext
        /// </summary>
        [DataMember(Name="content_plaintext", EmitDefaultValue=false)]
        public string contentPlaintext { get; set; }
  
        
        /// <summary>
        /// Gets or Sets contentRichtext
        /// </summary>
        [DataMember(Name="content_richtext", EmitDefaultValue=false)]
        public string contentRichtext { get; set; }
  
        
        /// <summary>
        /// Gets or Sets thumbnail
        /// </summary>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public string thumbnail { get; set; }
  
        
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
            sb.Append("class Snippet {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  contentHtml: ").Append(contentHtml).Append("\n");
            sb.Append("  contentPlaintext: ").Append(contentPlaintext).Append("\n");
            sb.Append("  contentRichtext: ").Append(contentRichtext).Append("\n");
            sb.Append("  thumbnail: ").Append(thumbnail).Append("\n");
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
            return this.Equals(obj as Snippet);
        }

        /// <summary>
        /// Returns true if Snippet instances are equal
        /// </summary>
        /// <param name="other">Instance of Snippet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Snippet other)
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
                    this.contentHtml == other.contentHtml ||
                    this.contentHtml != null &&
                    this.contentHtml.Equals(other.contentHtml)
                ) && 
                (
                    this.contentPlaintext == other.contentPlaintext ||
                    this.contentPlaintext != null &&
                    this.contentPlaintext.Equals(other.contentPlaintext)
                ) && 
                (
                    this.contentRichtext == other.contentRichtext ||
                    this.contentRichtext != null &&
                    this.contentRichtext.Equals(other.contentRichtext)
                ) && 
                (
                    this.thumbnail == other.thumbnail ||
                    this.thumbnail != null &&
                    this.thumbnail.Equals(other.thumbnail)
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
                
                if (this.contentHtml != null)
                    hash = hash * 59 + this.contentHtml.GetHashCode();
                
                if (this.contentPlaintext != null)
                    hash = hash * 59 + this.contentPlaintext.GetHashCode();
                
                if (this.contentRichtext != null)
                    hash = hash * 59 + this.contentRichtext.GetHashCode();
                
                if (this.thumbnail != null)
                    hash = hash * 59 + this.thumbnail.GetHashCode();
                
                if (this.user != null)
                    hash = hash * 59 + this.user.GetHashCode();
                
                return hash;
            }
        }

    }
}
