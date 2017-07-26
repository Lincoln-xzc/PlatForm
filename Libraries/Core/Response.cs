using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
  public class Response
  {
    public bool Status = true;
    public string Message = "操作成功";
    public ResultCode Code = ResultCode.Success;
    public dynamic Result;
  }
}
