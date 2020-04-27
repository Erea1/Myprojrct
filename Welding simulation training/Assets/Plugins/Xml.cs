/*
*R0-V1.0
*Modify Date:2019-2-26
*Modifier:ZoJet
*/
using System.IO;
using System.Xml;

public class Xml
{
    /// <summary>
    /// 读取某个单节点的数据
    /// </summary>
    /// <param name="xmlPath"></param>
    /// <param name="nodeNames"></param>
    /// <returns></returns>
    public static string ReadElement(string xmlPath, string nodeNames)
    {
        if (!File.Exists(xmlPath))
        {
            UnityEngine.Debug.Log("The file path is Not exist!");
            return string.Empty;
        }

        if (nodeNames == null || nodeNames.Trim() == "")
        {
            UnityEngine.Debug.Log("The node names is Null.");
            return string.Empty;
        }

        XmlDocument doc = new XmlDocument();
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.IgnoreComments = true;
        XmlReader reader = XmlReader.Create(xmlPath, settings);
        doc.Load(reader);

        XmlNode node = doc.SelectSingleNode(nodeNames);
        if (node == null)
        {
            UnityEngine.Debug.Log("Wrong with node names.");
            return string.Empty;
        }
        else
        {
            return node.InnerText;
        }
    }

    /// <summary>
    /// 读取某个节点下所有属性相同的子节点数据
    /// </summary>
    /// <param name="xmlPath"></param>
    /// <param name="nodeNames"></param>
    /// <returns></returns>
    public static string[] ReadElements(string xmlPath, string nodeNames)
    {
        if (!File.Exists(xmlPath))
        {
            UnityEngine.Debug.Log("The file path is Not exist!");
            return null;
        }

        if (nodeNames == null || nodeNames.Trim() == "")
        {
            UnityEngine.Debug.Log("The node names is Null.");
            return null;
        }

        XmlDocument doc = new XmlDocument();
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.IgnoreComments = true;
        XmlReader reader = XmlReader.Create(xmlPath, settings);
        doc.Load(reader);

        XmlNodeList nodeList = doc.SelectNodes(nodeNames);
        int nodeCount = nodeList.Count;
        if (nodeCount > 0)
        {
            string[] datas = new string[nodeCount];
            for (int i = 0; i < nodeCount; i++)
            {
                datas[i] = nodeList[i].InnerText;
            }
            return datas;
        }
        else
        {
            UnityEngine.Debug.Log("Wrong with node names.");
            return null;
        }
    }
}
