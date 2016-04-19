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
    public class Template :  IEquatable<Template>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        public Template()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }
  
        
        /// <summary>
        /// Gets or Sets GlobalTemplate
        /// </summary>
        [DataMember(Name="global_template", EmitDefaultValue=false)]
        public int? GlobalTemplate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
  
        
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
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public int? Thumbnail { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public string Settings { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
  
        
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Template {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  GlobalTemplate: ").Append(GlobalTemplate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ContentHtml: ").Append(ContentHtml).Append("\n");
            sb.Append("  ContentPlaintext: ").Append(ContentPlaintext).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            
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
            return this.Equals(obj as Template);
        }

        /// <summary>
        /// Returns true if Template instances are equal
        /// </summary>
        /// <param name="other">Instance of Template to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Template other)
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
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.GlobalTemplate == other.GlobalTemplate ||
                    this.GlobalTemplate != null &&
                    this.GlobalTemplate.Equals(other.GlobalTemplate)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                    this.Thumbnail == other.Thumbnail ||
                    this.Thumbnail != null &&
                    this.Thumbnail.Equals(other.Thumbnail)
                ) && 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
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
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.GlobalTemplate != null)
                    hash = hash * 59 + this.GlobalTemplate.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.ContentHtml != null)
                    hash = hash * 59 + this.ContentHtml.GetHashCode();
                
                if (this.ContentPlaintext != null)
                    hash = hash * 59 + this.ContentPlaintext.GetHashCode();
                
                if (this.Thumbnail != null)
                    hash = hash * 59 + this.Thumbnail.GetHashCode();
                
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                
                return hash;
            }
        }

    }
}
