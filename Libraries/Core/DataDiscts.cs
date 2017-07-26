using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
  public class ConstantValue
  {
    public const string Mobile = "^((17[0-9])|(14[0-9])|(13[0-9])|(15[^4,\\D])|(18[012,5-9]))\\d{8}$";
  }

  /// <summary>
  /// 请求结果代码枚举
  /// </summary>
  [Description("请求结果代码")]
  public enum ResultCode
  {
    #region 系统相关,1000开始
    /// <summary>
    /// 操作成功
    /// </summary>
    [Description("操作成功")]
    Success = 1000,

    /// <summary>
    /// 无权限访问
    /// </summary>
    [Description("无权限访问")]
    Nopermit = 1001,

    /// <summary>
    /// 访问次数达到上限
    /// </summary>
    [Description("访问次数达到上限")]
    Limited = 1002,

    /// <summary>
    /// 无该记录
    /// </summary>
    [Description("无该记录")]
    NULL = 1003,

    /// <summary>
    /// 服务器处理失败
    /// </summary>
    [Description("服务器处理失败")]
    ServerError = 1004,

    /// <summary>
    /// 操作失败
    /// </summary>
    [Description("操作失败")]
    Fail = 1005,

    /// <summary>
    /// 参数不全
    /// </summary>
    [Description("参数不全")]
    ParmsError = 1006,

    /// <summary>
    /// SoapHead检测不通过
    /// </summary>
    [Description("SoapHead检测不通过")]
    SoapHeadError = 1007,

    /// <summary>
    /// 请登录
    /// </summary>
    [Description("未登录")]
    NotLogin = 1008,

    /// <summary>
    /// 会话超时
    /// </summary>
    [Description("会话超时")]
    SessionOvertime = 1009,

    /// <summary>
    /// 数据操作错误
    /// </summary>
    [Description("数据操作错误")]
    DataBaseError = 1010,

    /// <summary>
    /// 没有数据
    /// </summary>
    [Description("没有数据")]
    NoData = 1012,

    /// <summary>
    /// 上传文件错误
    /// </summary>
    [Description("上传文件错误")]
    UploadFileError = 1013,

    /// <summary>
    /// 上传图片错误
    /// </summary>
    [Description("上传图片错误")]
    UploadImgError = 1014,
    #endregion

    #region 账号相关，2000开始

    /// <summary>
    /// 账号已存在
    /// </summary>
    [Description("账号已存在")]
    AccountExists = 2000,

    #endregion

    #region 订单相关，3000开始
    /// <summary>
    /// 订单已经存在
    /// </summary>
    [Description("订单已经存在")]
    OrderExists = 3000,

    /// <summary>
    /// 支付状态错误
    /// </summary>
    [Description("支付状态错误")]
    PayStatusError = 3001,

    /// <summary>
    /// 订单不存在
    /// </summary>
    [Description("订单不存在")]
    OrderNotExists = 3002,

    /// <summary>
    /// 订单已经支付
    /// </summary>
    [Description("订单已经支付")]
    OrderHasPayed = 3003,

    /// <summary>
    /// 订单已经处理过
    /// </summary>
    [Description("订单已经处理过")]
    OrderHasHand = 3004,

    /// <summary>
    /// 已经发货
    /// </summary>
    [Description("已经发货")]
    OrderHasDeliveryed = 3005,

    /// <summary>
    /// 订单不需要推送
    /// </summary>
    [Description("订单不需要推送")]
    OrderNotneedPush = 3006,

    /// <summary>
    /// 订单已经推送
    /// </summary>
    [Description("订单已经推送")]
    OrderHasPushed = 3007,

    /// <summary>
    /// 订单正在推送中
    /// </summary>
    [Description("订单正在推送中")]
    OrderPushHanding = 3008,

    /// <summary>
    /// 未支付
    /// </summary>
    [Description("未支付")]
    PayNot = 3009,

    /// <summary>
    /// 支付方式错误
    /// </summary>
    [Description("支付方式错误")]
    PaymentError = 3010,

    /// <summary>
    /// 没有支付成功交易流水号
    /// </summary
    [Description("没有支付成功交易流水号")]
    PayNoTrade = 3012,
    #endregion

    #region 产品类 4000开始
    /// <summary>
    /// 产品已经下架
    /// </summary>
    [Description("产品已经下架")]
    Product_Takenoff = 4000,
    #endregion

    #region 库存类 5000开始
    /// <summary>
    /// 库存不足
    /// </summary>
    [Description("库存不足")]
    Product_Stock_Notenough = 5000,
    #endregion

    #region 支付类 6000开始
    #endregion

    #region 手机号码/短信相关
    /// <summary>
    /// 验证码已发送
    /// </summary>
    [Description("验证码已发送")]
    SmsSent = 10000,

    /// <summary>
    /// 错误的手机号码
    /// </summary>
    [Description("错误的手机号码")]
    MobileNumberError = 10001,

    /// <summary>
    /// 注册时：该手机号码已经注册过，请找回密码
    /// </summary>
    [Description("该手机号码已经注册过，请找回密码")]
    MobileRegistered = 10002,

    /// <summary>
    /// 登录时：该手机号还没注册，请先注册
    /// </summary>
    [Description("该手机号还没注册，请先注册")]
    MobileNotRegister = 10003,

    /// <summary>
    /// 验证码类型不对
    /// </summary>
    [Description("验证码类型不对")]
    SmsTypeError = 10004,

    /// <summary>
    /// 请勿频繁发送验证码
    /// </summary>
    [Description("请勿频繁发送验证码")]
    SmsFrequently = 10005,

    /// <summary>
    /// 验证码发送失败
    /// </summary>
    [Description("验证码发送失败")]
    SmsSentFail = 10006,

    /// <summary>
    /// 短信内容错误
    /// </summary>
    [Description("短信内容错误")]
    SmsContentError = 10007,

    /// <summary>
    /// 超出当日限额
    /// </summary>
    [Description("超出当日限额")]
    SmsLimit = 10008,

    ///<summary>
    /// 错误的邮箱
    /// </summary>
    [Description("错误的邮箱")]
    EmailError = 10009,

    ///<summary>
    /// 错误的邮箱
    /// </summary>
    [Description("邮箱不存在")]
    EmailNotExist = 10010,

    ///<summary>
    /// 错误的邮箱
    /// </summary>
    [Description("邮箱已经存在")]
    EmailExisted = 10011,

    ///<summary>
    ///邮箱验证码发送失败
    /// </summary>
    [Description("邮箱验证码发送失败")]
    EmailSentFail = 10012,

    ///<summary>
    /// 邮箱验证码不正确
    /// </summary>
    [Description("邮箱验证码不正确")]
    EmailCodeError = 10013,

    #endregion
  }
}
