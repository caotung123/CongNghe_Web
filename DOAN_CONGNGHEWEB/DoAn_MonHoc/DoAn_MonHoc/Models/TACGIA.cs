//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_MonHoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class TACGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TACGIA()
        {
            this.THONGTINSACHes = new HashSet<THONGTINSACH>();
        }

        [Key]
        [Display(Name = "Mã tác giả")]
        public int MaTG { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên tác giả")]
        [Required(ErrorMessage = "Không được để trống")]
        public string TenTG { get; set; }

        [StringLength(250)]
        [Display(Name = "Quê quán")]
        public string QueQuan { get; set; }

        [Column(TypeName = "smalldatetime")]
        [Display(Name = "Ngày sinh")]
        public Nullable<System.DateTime> NgaySinh { get; set; }

        [Column(TypeName = "smalldatetime")]
        [Display(Name = "Ngày mất")]
        public Nullable<System.DateTime> NgayMat { get; set; }

        [StringLength(500)]
        [Display(Name = "Tiểu sử")]
        public string TieuSu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THONGTINSACH> THONGTINSACHes { get; set; }
    }
}
