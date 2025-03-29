﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string Idsp { get; set; } = null!;
        public string MoTa { get; set; } = null!;
        public string CongDung { get; set; } = null!;
        public string ThanhPhanDinhDuong { get; set; } = null!;
        public string Hdsd { get; set; } = null!;
        public int SoLuongSp { get; set; }
        public string? HinhAnhSp { get; set; }
        public string IdchungNhan { get; set; } = null!;
        public string Idcategory { get; set; } = null!;
        /*public string Idnpp { get; set; } = null!;*/
        public string IdDaiLy { get; set; } = null!;
        public bool Confirm { get; set; } = false;
        public string SpName { get; set; } = null!;
        [Column(TypeName = "decimal(18,0)")]
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; } = false;

        public virtual Category IdcategoryNavigation { get; set; } = null!;
        public virtual ChungNhan IdchungNhanNavigation { get; set; } = null!;
        /*public virtual NhaPhanPhoi? IdnppNavigation { get; set; } = null;*/
        public virtual DaiLyOnline IddaiLyNavigation { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
