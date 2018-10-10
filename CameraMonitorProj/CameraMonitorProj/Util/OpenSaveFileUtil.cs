using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraMonitorProj.Util
{
     public static class OpenSaveFileUtil
    {
        /// <summary>
        /// 打开文件对话框
        /// </summary>
        /// <param name="filterStr">筛选条件</param>
        /// <param name="titleStr">对话框标题</param>
        /// <param name="isMultiSelect">是否多选</param>
        /// <returns></returns>
        public static string OpenFileDialog(string filterStr, string titleStr, bool isMultiSelect)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
                openFileDialog.Title = titleStr;
                openFileDialog.Filter = filterStr;
                openFileDialog.Multiselect = isMultiSelect;
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    return openFileDialog.FileName;
                else
                    return string.Empty;
            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex.Message + Environment.NewLine + ex.StackTrace);
                return string.Empty;
            }
        }

        /// <summary>
        /// 保存文件对话框
        /// </summary>
        /// <param name="filterStr">保存条件，后缀名</param>
        /// <param name="titleStr">对话框标题</param>
        /// <returns></returns>
        public static string SaveFileDialog(string filterStr, string titleStr, string fullName = "")
        {
            try
            {
                System.Windows.Forms.SaveFileDialog SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
                SaveFileDialog.CheckPathExists = true;
                SaveFileDialog.Title = titleStr;
                SaveFileDialog.Filter = filterStr;
                if (fullName != "")
                    SaveFileDialog.FileName = fullName;
                if (SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    return SaveFileDialog.FileName;
                else
                    return string.Empty;
            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex.Message + Environment.NewLine + ex.StackTrace);
                return string.Empty;
            }
        }

        /// <summary>
        /// 文件夹路径选择
        /// </summary>
        /// <param name="desc"></param>
        /// <returns></returns>
        public static string SelectFolderDialog(string desc = "请选择要保存的文件路径")
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = desc;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.SelectedPath;
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex.Message + Environment.NewLine + ex.StackTrace);
                return string.Empty;
            }
        }

        /// <summary>
        /// 将流保存成文件
        /// </summary>
        /// <param name="blobData"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool SaveBlobToFile(Byte[] blobData, string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath)) return false;
                System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                fs.Write(blobData, 0, blobData.Length);
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex.Message + Environment.NewLine + ex.StackTrace);
                return false;
            }
        }
    }
}
