using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
  [Table("t_Order")]
  public class Order :BaseEntity
  {

    public bool IsDistribution
    {
      get;
      set;
    }
    [Key]
    public new Guid ID { get; set; }
    public string Number { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public Guid? UpdatedBy { get; set; }

    public string FromName { get; set; }
    public Guid FromID { get; set; }

    public Guid BusinessID { get; set; }

    public Guid ProjectID { get; set; }


    public decimal ActualPaid { get; set; }

    public string FullAddress { get; set; }

    public string Address { get; set; }

    public string CountryCode { get; set; }

    public string ProvinceCode { get; set; }

    public string CityCode { get; set; }

    public string DistrictCode { get; set; }

    public string StreetCode { get; set; }

    public string ZipCode { get; set; }

    public string Receiver { get; set; }

    public string Phone { get; set; }

    public string IdCard { get; set; }

    public DateTime DeliveryDate { get; set; }

    public bool IsDel { get; set; }

    public int Status { get; set; }

    public string Remark { get; set; }

    public decimal Prepayment { get; set; }

    /// <summary>
    /// 商品总金额
    /// </summary>
    public decimal Total { get; set; }
    /// <summary>
    /// 活动优惠金额
    /// </summary>
    public decimal DiscountPromotion { get; set; }
    /// <summary>
    /// 额外优惠金额
    /// </summary>
    public decimal DiscountExtra { get; set; }
    /// <summary>
    /// 运费
    /// </summary>
    public decimal Freight { get; set; }
    /// <summary>
    /// 订单应付金额
    /// </summary>

    public decimal Balance { get; set; }
    public bool HasFinished { get; set; }
    /// <summary>
    /// 退款金额
    /// </summary>
    public decimal RefundAmount { get; set; }

   
  }
}
