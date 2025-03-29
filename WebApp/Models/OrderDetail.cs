using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public partial class OrderDetail
    {
        public string OrderDetailId { get; set; } = null!;
        public int Quantity { get; set; }
        public string Idsp { get; set; } = null!;
        public string OrderId { get; set; } = null!;
        [Column(TypeName = "decimal(18,0)")]
        public decimal Price { get; set; }

        public virtual SanPham IdspNavigation { get; set; } = null!;

        //Thêm khóa ngoại nhiều nhiều tới Order
        public virtual Order OrderIdNavigation { get; set; } = null!;


    }
}
