using CameraMonitorProj.Model;
using CYQ.Data;
using CYQ.Data.Aop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraMonitorProj.Util
{
    public static class SqlHelper
    {

        /// <summary>
        /// 获取单位名称根据单位ID
        /// </summary>
        /// <param name="organizeId"></param>
        /// <returns></returns>
        public static string GetOrganizeNameById(string organizeId)
        {
            using (MProc proc = new MProc(string.Format("SELECT FullName FROM Base_Organize WHERE OrganizeId='{0}'", organizeId)))
            {
                return proc.ExeScalar<string>();
            }
        }

        /// <summary>
        /// 获取单位编码根据单位 ID
        /// </summary>
        /// <param name="organizeId"></param>
        /// <returns></returns>
        public static string GetOrganizeCodeById(string organizeId)
        {
            using (MProc proc = new MProc(string.Format("SELECT UNITBM FROM WJ_Unit WHERE ID='{0}'", organizeId)))
            {
                return proc.ExeScalar<string>();
            }
        }

        public static string GetOrganizeEnCode(string organizeId)
        {
            using (MProc proc = new MProc(string.Format("SELECT EnCode FROM Base_Organize WHERE OrganizeId='{0}'", organizeId)))
            {
                return proc.ExeScalar<string>();
            }
        }

        /// <summary>
        /// 获取用户实体根据ID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static Base_Organize GetOrganizeById(string organizeId)
        {
            using (MAction action = new MAction("Base_Organize"))
            {
                //关闭缓存
                action.SetAopState(AopOp.CloseAll);
                if (action.Fill($"OrganizeId='" + organizeId + "'"))
                {
                    return action.Data.ToEntity<Base_Organize>();
                }
            }
            return null;
        }

        /// <summary>
        /// 根据学习室摄像头ID获取单位ID
        /// </summary>
        /// <param name="cameraId"></param>
        /// <returns></returns>
        public static string GetOrganizeIdByCameraId(string cameraId, string studyRoomName)
        {
            using (MProc proc = new MProc(string.Format("SELECT UNITID FROM WJ_KC_XXS WHERE ZSXT='{0}' AND MC='{1}'", cameraId, studyRoomName)))
            {
                return proc.ExeScalar<string>();
            }
        }

        /// <summary>
        /// 获取单位所有摄像头根据单位 ID
        /// </summary>
        /// <param name="organizeId"></param>
        /// <returns></returns>
        public static DataTable GetCameraListByUnitId(string organizeId)
        {
            try
            {
                using (MAction action = new MAction(string.Format("SELECT * FROM Device_Cameras WHERE UnitID='{0}'", organizeId)))
                {
                    action.SetAopState(AopOp.CloseAll);
                    return action.Select().ToDataTable();
                }
            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public static DataTable GetChildUnitListByUnitId(string organizeId)
        {
            using (MAction action = new MAction(string.Format("SELECT o.FullName FullName, o.OrganizeId OrganizeId, o.EnCode, u.UNITBM, u.DWJB FROM Base_Organize o JOIN WJ_Unit u ON o.OrganizeId = u.ID WHERE parentId = '{0}'", organizeId)))
            {
                action.SetAopState(AopOp.CloseAll);
                return action.Select("ORDER BY UNITBM").ToDataTable();
            }
        }

        /// <summary>
        /// 获取学习室主摄像头ID 通过单位ID
        /// </summary>
        /// <param name="organizeId"></param>
        /// <returns></returns>
        public static DataTable GetLearnRoomCamaraIdByUnitId(string unitId)
        {
            using (MAction action = new MAction(string.Format("SELECT ZSXT CameraId, MC RoomName FROM WJ_KC_XXS WHERE UNITID='{0}'", unitId)))
            {
                action.SetAopState(AopOp.CloseAll);
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取单位课程通过单位 ID 和日期
        /// </summary>
        /// <param name="organizeId"></param>
        /// <returns></returns>
        public static DataTable GetCourceInfoByUnitIdAndDate(string organizeId, DateTime teachScheduleDate)
        {
            //SELECT r.ID, r.SJMS, r.KSSJ, r.JSSJ, r.KCNR, r.FZRID, r.FZR, r.FZRZW, r.JCQK, r.PKRWID, r.MBID, r.SJDID, r.ZWRS, r.YDRS, r.SDRS FROM WJ_KC_PKRWB_KCNR r WHERE PKRWID = (SELECT b.ID FROM WJ_KC_PKRWB b WHERE UNITID = '{0}' AND DATEDIFF(day, PKRQ, GETDATE()) = 0)
            using (MAction action = new MAction(string.Format("SELECT r.ID, r.SJMS, r.KSSJ, r.JSSJ, r.KCNR, r.FZRID, r.FZR, r.FZRZW, r.JCQK, r.PKRWID, r.MBID, r.SJDID, r.ZWRS, r.YDRS, r.SDRS, b.RWMC FROM WJ_KC_PKRWB_KCNR r JOIN (SELECT b.ID, b.RWMC FROM WJ_KC_PKRWB b WHERE b.UNITID = '{0}' AND b.PKRQ = '{1}') b ON r.PKRWID=b.ID", organizeId, teachScheduleDate)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取人员名称通过人员 ID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static string GetRealNameByUserId(string userId)
        {
            using (MProc proc = new MProc(string.Format("SELECT RealName FROM Base_User WHERE UserId='{0}'", userId)))
            {
                return proc.ExeScalar<string>();
            }
        }

        /// <summary>
        /// 获取人员职务名称通过人员 ID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static string GetPostNameByUserId(string userId)
        {
            using (MProc proc = new MProc(string.Format("SELECT ZW FROM WJ_MEMBER WHERE ID = '{0}'", userId)))
            {
                return proc.ExeScalar<string>();
            }
        }

        /// <summary>
        /// 获取用户信息根据用户 ID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static DataTable GetUserInfoByUserId(string userId)
        {
            
            using (MAction action = new MAction(string.Format("SELECT u.RealName, r.ZW FROM Base_User u JOIN WJ_MEMBER r ON u.UserId = r.ID WHERE UserId = '{0}'", userId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取所有登录中队ID、状态集合
        /// </summary>
        /// <returns></returns>
        public static DataTable GetLoginSquadronUnitIdList()
        {
            //SELECT g.UNITID UnitId, g.ZT State FROM WJ_KC_PKRWB_LOG g LEFT JOIN (SELECT MAX(w.SJ) SJ, w.UNITID UNITID FROM WJ_KC_PKRWB_LOG w WHERE DATEDIFF(day, w.SJ, GETDATE()) = 0 GROUP BY w.UNITID) h ON g.UNITID=h.UNITID JOIN Base_Organize o ON g.UNITID=o.OrganizeId WHERE g.SJ=h.SJ AND o.EnCode='中队'
            using (MAction action = new MAction("SELECT g.UNITID UnitId, g.ZT State FROM WJ_KC_PKRWB_LOG g LEFT JOIN (SELECT MAX(w.SJ) SJ, w.UNITID UNITID FROM WJ_KC_PKRWB_LOG w WHERE DATEDIFF(day, w.SJ, GETDATE()) = 0 GROUP BY w.UNITID) h ON g.UNITID=h.UNITID JOIN Base_Organize o ON g.UNITID=o.OrganizeId WHERE g.SJ=h.SJ AND (o.EnCode='中队' OR o.EnCode='大队')"))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取排课任务信息
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTeachScheduleInfo()
        {
            try
            {
                //SELECT b.UNITID, b.ZWRS, b.SDRS, (case b.SFSH when '0' then '未审核' when '1' then '审核通过' when '2'  then '审核未通过' when '3' then '通过部分' end) State 
                //FROM WJ_KC_PKRWB b LEFT JOIN 
                //(SELECT MAX(w.PKRQ) PKRQ, w.UNITID UNITID FROM WJ_KC_PKRWB w WHERE DATEDIFF(day, w.PKRQ, GETDATE()) = 0 GROUP BY w.UNITID) h ON b.UNITID = h.UNITID JOIN Base_Organize o ON b.UNITID = o.OrganizeId 
                //WHERE b.PKRQ = h.PKRQ AND o.EnCode = '中队'
                using (MAction action = new MAction("SELECT b.UNITID, b.ZWRS, b.SDRS, (case b.SFSH when '0' then '未审核' when '1' then '审核通过' when '2'  then '审核未通过' when '3' then '通过部分' end) State FROM WJ_KC_PKRWB b LEFT JOIN (SELECT MAX(w.PKRQ) PKRQ, w.UNITID UNITID FROM WJ_KC_PKRWB w WHERE DATEDIFF(day, w.PKRQ, GETDATE()) = 0 GROUP BY w.UNITID) h ON b.UNITID = h.UNITID JOIN Base_Organize o ON b.UNITID = o.OrganizeId WHERE b.PKRQ = h.PKRQ AND (o.EnCode = '中队' OR o.EnCode='大队')"))
                {
                    return action.Select().ToDataTable();
                }
            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex.Message + ex.StackTrace);
                return null;
            }
        }

        /// <summary>
        /// 获取排课日期根据单位 ID
        /// </summary>
        /// <param name="organizeId"></param>
        /// <returns></returns>
        public static IList<DateTime> GetTeachScheduleDate(string organizeId)
        {
            using (MAction action = new MAction(string.Format("SELECT DISTINCT PKSJ FROM WJ_KC_PKRWB_KCNR WHERE UNITID = '{0}'", organizeId)))
            {
                return action.Select("ORDER BY PKSJ DESC").ToList<DateTime>();
            }
        }

        /// <summary>
        /// 获取排课模板集合
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTemplateList()
        {
            using (MAction action = new MAction("SELECT ID, MBMC FROM WJ_KC_MB"))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取人员信息根据单位 ID
        /// </summary>
        /// <param name="organizeId"></param>
        /// <returns></returns>
        public static DataTable GetUserInfoListByOrganzieId(string organizeId)
        {
            using (MAction action = new MAction(string.Format("SELECT u.UserId, u.RealName, r.ZW FROM Base_User u JOIN WJ_MEMBER r ON u.UserId=r.ID WHERE OrganizeId='{0}'", organizeId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取排课模板排课时间段信息
        /// </summary>
        /// <param name="templateId"></param>
        /// <returns></returns>
        public static DataTable GetTeachScheduleByTemplateId(string templateId)
        {
            using (MAction action = new MAction(string.Format("SELECT ID SJDID, KSSJ, JSSJ, SJMS, PX FROM WJ_KC_MB_SJD WHERE MBID='{0}'", templateId)))
            {
                return action.Select("ORDER BY PX").ToDataTable();
            }
        }

        /// <summary>
        /// 获取排课时间段信息根据时间段 ID
        /// </summary>
        /// <param name="timeSeatId"></param>
        /// <returns></returns>
        public static DataTable GetTimeSeatInfoBySeatId(string timeSeatId)
        {
            using (MAction action = new MAction(string.Format("SELECT SJMS, KSSJ, JSSJ FROM WJ_KC_MB_SJD WHERE ID='{0}'", timeSeatId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取课程内容根据内容 ID
        /// </summary>
        /// <param name="contentId"></param>
        /// <returns></returns>
        public static DataTable GetTeachContentById(string contentId)
        {
            using (MAction action = new MAction(string.Format("SELECT * FROM WJ_KC_PKRWB_KCNR WHERE ID='{0}'", contentId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 查看记录是否存在
        /// 结果为 1：记录存在；结果为 0：记录不存在。
        /// </summary>
        /// <returns></returns>
        public static int IsExist(string tableName, string where)
        {
            using (MProc proc = new MProc(string.Format("select isnull((select top(1) 1 from {0} where {1}), 0)", tableName, where)))
            {
                return proc.ExeScalar<int>();
            }
        }

        public static string GetTeachScheduleTaskId(DateTime teachScheduleDate, string unitId)
        {
            using (MProc proc = new MProc(string.Format("SELECT ID FROM WJ_KC_PKRWB WHERE PKRQ='{0}' AND UNITID='{1}'", teachScheduleDate, unitId)))
            {
                return proc.ExeScalar<string>();
            }
        }

        /// <summary>
        /// 获取排课任务信息，根据排课日期和单位 ID
        /// </summary>
        /// <param name="teachScheduleDate"></param>
        /// <param name="unitId"></param>
        /// <returns></returns>
        public static DataTable GetTeachScheduleTaskInfo(DateTime teachScheduleDate, string unitId)
        {
            using (MAction action = new MAction(string.Format("SELECT * FROM WJ_KC_PKRWB WHERE PKRQ='{0}' AND UNITID='{1}'", teachScheduleDate, unitId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取排课内容，根据排课 ID
        /// </summary>
        /// <param name="contentId"></param>
        /// <returns></returns>
        public static DataTable GetTeachScheduleContentById(string contentId)
        {
            using (MAction action = new MAction(string.Format("SELECT * FROM WJ_KC_PKRWB_KCNR WHERE ID='{0}'", contentId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取排课内容，根据排课日期和单位 ID
        /// </summary>
        /// <param name="teachScheduleDate"></param>
        /// <param name="unitId"></param>
        /// <returns></returns>
        public static DataTable GetTeachScheduleContent(DateTime teachScheduleDate, string unitId)
        {
            using (MAction action = new MAction(string.Format("SELECT * FROM WJ_KC_PKRWB_KCNR WHERE PKRWID = (SELECT ID FROM WJ_KC_PKRWB WHERE UNITID = '{0}' AND PKRQ = '{1}')", unitId, teachScheduleDate)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取排课内容，根据排课日期和单位 ID
        /// </summary>
        /// <param name="teachScheduleDate"></param>
        /// <param name="unitId"></param>
        /// <returns></returns>
        public static DataTable GetTeachScheduleContent2(DateTime teachScheduleDate, string unitId)
        {
            using (MAction action = new MAction(string.Format("SELECT * FROM WJ_KC_PKRWB_KCNR WHERE Unitid='{0}' AND PKSJ>='{1}' AND PKSJ<'{2}'", unitId, teachScheduleDate.Date, teachScheduleDate.Date.AddDays(1))))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取附件类型根据单位 ID
        /// </summary>
        /// <param name="organizeId"></param>
        /// <returns></returns>
        public static DataTable GetAttachmentTypeByUnitId(string organizeId)
        {
            using (MAction action = new MAction(string.Format("SELECT ID, Name FROM WJ_KC_FJLX WHERE UnitId='{0}'", organizeId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取附件类型名称
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static string GetAttachmentTypeNameById(string typeId)
        {
            using (MProc proc = new MProc(string.Format("SELECT Name FROM WJ_KC_FJLX WHERE ID='{0}'", typeId)))
            {
                return proc.ExeScalar<string>();
            }
        }

        /// <summary>
        /// 获取授课人信息根据单位 ID
        /// </summary>
        /// <param name="organizeId"></param>
        /// <returns></returns>
        public static DataTable GetTeacherInfoByUnitId(string organizeId)
        {
            using (MAction action = new MAction(string.Format("SELECT ID, ZJH, XM, ZW FROM WJ_KC_SKR WHERE UnitId='{0}'", organizeId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取授课人信息根据 ID
        /// </summary>
        /// <param name="teachStuffId"></param>
        /// <returns></returns>
        public static DataTable GetTeachStuffInfoById(string teachStuffId)
        {
            using (MAction action = new MAction(string.Format("SELECT * FROM WJ_KC_SKR WHERE ID='{0}'", teachStuffId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取用户权限根据人员 ID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static DataTable GetPriorityByUserId(string userId)
        {
            using (MAction action = new MAction(string.Format("SELECT * FROM WJ_KC_QX WHERE USERID='{0}'", userId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取已发送通知数量，根据单位 ID
        /// </summary>
        /// <param name="organizeId"></param>
        /// <returns></returns>
        public static int GetHadSendNoticeCountByUnitId(string organizeId)
        {
            using (MProc proc = new MProc(string.Format("SELECT COUNT(Id) FROM WJ_KC_NoticeSend WHERE UnitId='{0}'", organizeId)))
            {
                return proc.ExeScalar<int>();
            }
        }

        /// <summary>
        /// 获取已发送通知数量，根据用户 ID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static int GetHadSendNoticeCountByUserId(string userId)
        {
            using (MProc proc = new MProc(string.Format("SELECT COUNT(Id) FROM WJ_KC_NoticeSend WHERE UserId='{0}'", userId)))
            {
                return proc.ExeScalar<int>();
            }
        }

        /// <summary>
        /// 获取已接收通知数量，根据单位 ID
        /// </summary>
        /// <param name="organizeId"></param>
        /// <returns></returns>
        public static int GetHadReceiveNoticeCountByUnitId(string organizeId)
        {
            using (MProc proc = new MProc(string.Format("SELECT COUNT(Id) FROM WJ_KC_NoticeReceive WHERE UnitId='{0}'", organizeId)))
            {
                return proc.ExeScalar<int>();
            }
        }

        /// <summary>
        /// 获取已接收通知数量，根据用户 ID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static int GetHadReceiveNoticeCountByUserId(string userId)
        {
            using (MProc proc = new MProc(string.Format("SELECT COUNT(Id) FROM WJ_KC_NoticeReceive WHERE UserId='{0}'", userId)))
            {
                return proc.ExeScalar<int>();
            }
        }

        /// <summary>
        /// 获取已发送通知
        /// </summary>
        /// <param name="organizeId"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static DataTable GetHadSendNoticesByUnitId(string organizeId, int pageIndex, int pageSize)
        {
            using (MAction action = new MAction(string.Format("SELECT * FROM WJ_KC_NoticeSend WHERE UnitId='{0}'", organizeId)))
            {
                //关闭缓存
                action.SetAopState(AopOp.CloseAll);
                return action.Select(pageIndex, pageSize, "ORDER BY SendTime DESC").ToDataTable();
            }
        }

        public static DataTable GetHadSendNoticesByUserId(string userId, int pageIndex, int pageSize)
        {
            using (MAction action = new MAction(string.Format("SELECT * FROM WJ_KC_NoticeSend WHERE UserId='{0}'", userId)))
            {
                //关闭缓存
                action.SetAopState(AopOp.CloseAll);
                return action.Select(pageIndex, pageSize, "ORDER BY SendTime DESC").ToDataTable();
            }
        }

        /// <summary>
        /// 获取已接收通知根据单位 ID
        /// </summary>
        /// <param name="organizeId"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static DataTable GetHadReceiveNoticeByUnitId(string organizeId, int pageIndex, int pageSize)
        {
            using (MAction action = new MAction(string.Format("SELECT s.Id, n.ReceiveTime, u.RealName, s.Title, s.NoticeContent, n.State FROM WJ_KC_NoticeReceive n LEFT JOIN WJ_KC_NoticeSend s ON n.NoticeId=s.Id LEFT JOIN Base_User u ON s.UserId=u.UserId WHERE n.UserId='{0}'", organizeId)))
            {
                return action.Select(pageIndex, pageSize, "ORDER BY ReceiveTime DESC").ToDataTable();
            }
        }

        /// <summary>
        /// 获取已接收通知根据用户 ID
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static DataTable GetHadReceiveNoticeByUserId(string userId, int pageIndex, int pageSize)
        {
            using (MAction action = new MAction(string.Format("SELECT s.Id NoticeId, n.Id ReceiveId, n.ReceiveTime, u.RealName, s.Title, s.NoticeContent, n.State FROM WJ_KC_NoticeReceive n LEFT JOIN WJ_KC_NoticeSend s ON n.NoticeId=s.Id LEFT JOIN Base_User u ON s.UserId=u.UserId WHERE n.UserId='{0}'", userId)))
            {
                return action.Select(pageIndex, pageSize, "ORDER BY ReceiveTime DESC").ToDataTable();
            }
        }

        /// <summary>
        /// 获取通知，根据通知 ID
        /// </summary>
        /// <param name="noticeId"></param>
        /// <returns></returns>
        public static DataTable GetNoticeById(string noticeId)
        {
            using (MAction action = new MAction(string.Format("SELECT s.Title, s.NoticeContent, s.SendTime, s.UnitId, s.UserId, o.FullName, u.RealName FROM WJ_KC_NoticeSend s LEFT JOIN Base_Organize o ON s.UnitId=o.OrganizeId LEFT JOIN Base_User u ON s.UserId=u.UserId WHERE s.Id='{0}'", noticeId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取通知接收单位信息
        /// </summary>
        /// <param name="noticeId"></param>
        /// <returns></returns>
        public static DataTable GetNoticeReceiveUnits(string noticeId)
        {
            using (MAction action = new MAction(string.Format("SELECT o.OrganizeId, o.FullName FROM WJ_KC_NoticeReceive r JOIN Base_Organize o ON r.UnitId=o.OrganizeId WHERE r.NoticeId='{0}'", noticeId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取通知接收用户信息
        /// </summary>
        /// <param name="noticeId"></param>
        /// <returns></returns>
        public static DataTable GetNoticeReceiveUsers(string noticeId)
        {
                 using (MAction action = new MAction(string.Format("SELECT u.UserId, u.RealName FROM WJ_KC_NoticeReceive n LEFT JOIN Base_User u ON n.UserId=u.UserId WHERE n.NoticeId='{0}'", noticeId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取通知接收方信息
        /// </summary>
        /// <param name="noticeId"></param>
        /// <returns></returns>
        public static DataTable GetNoticeReceiveInfoById(string noticeId)
        {
            using (MAction action = new MAction(string.Format("SELECT n.*, u.RealName FROM WJ_KC_NoticeReceive n LEFT JOIN Base_User u ON n.UserId=u.UserId WHERE NoticeId='{0}'", noticeId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取通知接收方信息，通过接收 ID
        /// </summary>
        /// <param name="receiveId"></param>
        /// <returns></returns>
        public static DataTable GetNoticeReceiveInfoByReceiveId(string receiveId)
        {
            using (MAction action = new MAction(string.Format("SELECT r.*, o.FullName, u.RealName FROM WJ_KC_NoticeReceive r LEFT JOIN Base_Organize o ON r.UnitId=o.OrganizeId LEFT JOIN Base_User u ON r.UserId=u.UserId WHERE r.Id='{0}'", receiveId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取未接收通知信息，根据用户 ID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static DataTable GetUnReceiveNoticeInfoByUserId(string userId)
        {
            using (MAction action = new MAction(string.Format("SELECT n.Id, n.NoticeId, u.RealName FROM WJ_KC_NoticeReceive n LEFT JOIN Base_User u ON n.UserId=u.UserId WHERE n.State='0' AND n.UserId='{0}'", userId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 获取未接收通知信息，根据单位 ID
        /// </summary>
        /// <param name="unitId"></param>
        /// <returns></returns>
        public static DataTable GetUnReceiveNoticeInfoByUnitId(string unitId)
        {
            using (MAction action = new MAction(string.Format("SELECT n.Id, n.NoticeId, u.RealName FROM WJ_KC_NoticeReceive n LEFT JOIN Base_User u ON n.UserId=u.UserId WHERE n.State='0' AND n.UnitId='{0}'", unitId)))
            {
                return action.Select().ToDataTable();
            }
        }

        /// <summary>
        /// 执行 SQL 语句
        /// 增、删、改 等语句
        /// </summary>
        /// <param name="sql"></param>
        public static void ExecuteSql(string sql)
        {
            MProc proc = new MProc(sql);
            proc.ExeNonQuery();
        }
    }
}
