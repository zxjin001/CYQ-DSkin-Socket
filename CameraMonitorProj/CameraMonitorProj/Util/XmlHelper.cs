using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CameraMonitorProj.Util
{
    public static class XmlHelper
    {
        /// <summary>
        /// 根据节点名称获取指定节点
        /// 这种方法只能查找一个节点，并且保证要查找的节点在XML目录树中的名称是唯一值 
        /// 要是目录树中存在多个同名称的节点，则返回最后一个节点
        /// </summary>
        /// <param name="selElement">返回指定节点</param>
        /// <param name="startElement">开始节点</param>
        /// <param name="elementName">查找名称</param>
        public static void GetElementByName(ref XElement selElement, XElement startElement, string elementName)
        {
            IList<XElement> subElementList = startElement.Elements().ToList();
            foreach (XElement subElement in subElementList)
            {
                if (string.Equals(subElement.Name.LocalName, elementName)) //判断节点名称是否相同
                {
                    selElement = subElement;
                    return;
                }
                else
                {
                    if (subElement.HasElements)
                    {
                        GetElementByName(ref selElement, subElement, elementName);
                    }
                }
            }
        }
    }
}
