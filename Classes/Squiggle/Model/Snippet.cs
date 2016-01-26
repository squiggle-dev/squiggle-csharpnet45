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
            
        }

        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ContentHtml
        /// </summary>
        [DataMember(Name="content_html", EmitDefaultValue=false)]
        public string ContentHtml { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ContentPlaintext
        /// </summary>
        [DataMember(Name="content_plaintext", EmitDefaultValue=false)]
        public string ContentPlaintext { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ContentRichtext
        /// </summary>
        [DataMember(Name="content_richtext", EmitDefaultValue=false)]
        public string ContentRichtext { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public string Thumbnail { get; set; }
  
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Snippet {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContentHtml: ").Append(ContentHtml).Append("\n");
            sb.Append("  ContentPlaintext: ").Append(ContentPlaintext).Append("\n");
            sb.Append("  ContentRichtext: ").Append(ContentRichtext).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ContentHtml == other.ContentHtml ||
                    this.ContentHtml != null &&
                    this.ContentHtml.Equals(other.ContentHtml)
                ) && 
                (
                    this.ContentPlaintext == other.ContentPlaintext ||
                    this.ContentPlaintext != null &&
                    this.ContentPlaintext.Equals(other.ContentPlaintext)
                ) && 
                (
                    this.ContentRichtext == other.ContentRichtext ||
                    this.ContentRichtext != null &&
                    this.ContentRichtext.Equals(other.ContentRichtext)
                ) && 
                (
                    this.Thumbnail == other.Thumbnail ||
                    this.Thumbnail != null &&
                    this.Thumbnail.Equals(other.Thumbnail)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                
                if (this.ContentHtml != null)
                    hash = hash * 59 + this.ContentHtml.GetHashCode();
                
                if (this.ContentPlaintext != null)
                    hash = hash * 59 + this.ContentPlaintext.GetHashCode();
                
                if (this.ContentRichtext != null)
                    hash = hash * 59 + this.ContentRichtext.GetHashCode();
                
                if (this.Thumbnail != null)
                    hash = hash * 59 + this.Thumbnail.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                return hash;
            }
        }

    }
}
