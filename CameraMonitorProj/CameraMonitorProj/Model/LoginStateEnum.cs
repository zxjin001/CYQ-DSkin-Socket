using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraMonitorProj.Model
{
    public enum LoginStateEnum
    {
        /// <summary>
        /// 默认
        /// 作用：一般人员登录预览
        /// </summary>
        Default,

        /// <summary>
        /// 编辑
        /// 作用：编辑人员编辑课程编辑录入数据
        /// </summary>
        Edit,

        /// <summary>
        /// 审核
        /// 作用：审核人员审批工作
        /// </summary>
        Check
    }
}
