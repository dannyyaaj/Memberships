using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Memberships.Entities
{
    [Table("Item")]
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Title { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }

        [MaxLength(1024)]
        public string Url { get; set; }

        [MaxLength(1024)]
        [DisplayName("Image Url")]
        public string ImageUrl { get; set; }

        //Below property is to allow db to store and use HTML in MVC
        [AllowHtml]
        public string HTML { get; set; }

        [DefaultValue(0)]
        [DisplayName("Wait Days")]
        public int WaitDays { get; set; }

        public string HTMLShort
        {
            //readonly property, no need for set
            get
            {
                return HTML == null || HTML.Length <= 50 ?
                  HTML : HTML.Substring(0, 50);
            }
        }

        public int ProductId { get; set; }
        public int ItemTypeId { get; set; }
        public int SectionId { get; set; }
        public int PartId { get; set; }
        public bool IsFree { get; set; }

        //create collection for lazy loading
        [DisplayName("Item Type")]
        public ICollection<ItemType> ItemTypes { get; set; }
        //create collection for lazy loading
        public ICollection<Section> Sections { get; set; }
        //create collection for lazy loading
        public ICollection<Part> Parts { get; set; }
    }
}