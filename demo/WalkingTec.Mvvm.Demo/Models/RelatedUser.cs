using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using WalkingTec.Mvvm.Core;

namespace WalkingTec.Mvvm.Demo.Models
{
    [Table("FrameworkUsers")]
    public class RelatedUser : FrameworkUserBase, ITreeData<FrameworkUserBase>
    {

        [Display(Name = "������Ϣ1")]
        public string Extra1 { get; set; }

        [Display(Name = "������Ϣ2")]
        public string Extra2 { get; set; }

        [NotMapped]
        public virtual List<FrameworkUserBase> Children { get; }

        [Display(Name = "�ϼ�")]
        public virtual Guid? ParentId { get; set; }

        [Display(Name = "�ϼ�")]
        public virtual FrameworkUserBase Parent { get; }
    }
}
