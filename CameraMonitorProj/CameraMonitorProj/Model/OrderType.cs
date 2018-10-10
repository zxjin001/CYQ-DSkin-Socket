using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraMonitorProj.Model
{
    public enum ZCommonOrderType
    {
        Null,//未知
        AlarmRecord,//报警
        ServerStartListen,//服务开启监听
        //ServerListenFailed,//服务监听失败
        ServerStopListen,//服务停止监听
        //ServerStopListenFailed,//服务停止监听失败
        ClientAccept,//客户端连接
        ClientClose,//客户端断线
        UserLogin,//客户端登录
        Message,//聊天消息
        Notice,//通知
        GuardChange,//哨兵换岗
        Exception,
        LoginUserCollection//登录用户集合
    }
}
