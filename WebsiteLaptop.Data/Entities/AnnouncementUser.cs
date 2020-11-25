using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebsiteLaptop.Infrastructure.SharedKernel;

namespace WebsiteLaptop.Data.Entities
{
    [Table("AnnouncementUsers")]
    public class AnnouncementUser : DomainEntity<int>
    {
        [Required]
        public int AnnouncementId { get; set; }

        [StringLength(450)]
        [Required]
        public string UserId { get; set; }

        public bool? HasRead { get; set; }

        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }

        [ForeignKey("AnnouncementId")]
        public virtual Announcement Announcement { get; set; }
    }
}
