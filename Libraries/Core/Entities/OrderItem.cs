using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{

  [Table("t_OrderItem")]
  public class OrderItem :BaseEntity
  {
    public new Guid ID { get; set; }
    public Guid OrderID { get; set; }

    public Guid? SubOrderID { get; set; }

    public Guid ProductID { get; set; }
    /// <summary>
    /// 商品单价(最终的)
    /// </summary>
    public decimal Price { get; set; }

    public int Amount { get; set; }

    public string Image { get; set; }

    public string Name { get; set; }

    public string ProductSn { get; set; }

    public string SpecKey { get; set; }

    public string SpecKeyName { get; set; }

    public string Remark { get; set; }

    public string Unit { get; set; }
    public bool Customized { get; set; }
    public bool Standard { get; set; }

    public bool IsDel { get; set; }
    /// <summary>
    /// 已发货数量
    /// </summary>
    public int SendAmount { get; set; }
    /// <summary>
    /// 供应商ID
    /// </summary>
    public Guid ProviderID { get; set; }
    /// <summary>
    /// 供应商名称
    /// </summary>
    public string ProviderName { get; set; }

    public Int64 CateID { get; set; }

    public string BrandName { get; set; }
    /// <summary>
    /// 根目录ID
    /// </summary>
    public Int64 TopCateID { get; set; }
    /// <summary>
    /// 根目录名称
    /// </summary>
    public string TopCateName { get; set; }
    /// <summary>
    /// 等级优惠(弃用)
    /// </summary>
    public decimal DiscountLevel { get; set; }
    /// <summary>
    /// 活动优惠(弃用)
    /// </summary>
    public decimal DiscountPromotion { get; set; }
    /// <summary>
    /// 额外优惠(弃用)
    /// </summary>
    public decimal DiscountExtra { get; set; }
    /// <summary>
    /// 供货价
    /// </summary>
    public decimal CostPrice { get; set; }
    public Int64 BrandID { get; set; }

    /// <summary>
    /// 众销商成本
    /// </summary>
    public decimal RateCampaign { get; set; }
    /// <summary>
    /// 服务商成本
    /// </summary>
    public decimal RateService { get; set; }
    /// <summary>
    /// 其他(备用)成本
    /// </summary>
    public decimal RateOther { get; set; }
    public Order Order { get; set; }
   
  }
}
