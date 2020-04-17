/****************************************************************************
 * 2020.4 DESKTOP-I056DAV
 ****************************************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace VRCTP
{
	public partial class EquippedParent : UIComponent
	{
        public List<Equipped> equippeds = new List<Equipped>();
		private void Awake()
		{

		}
        public void InitEquippdes()
        {
            string xmlPath = Application.streamingAssetsPath + "/config";
            string[] equippdesInfo = Xml.ReadElements(xmlPath, "configuration/configInfo/equippde");
            for (int i = 0; i < equippdesInfo.Length; i++)
            {
                Equipped equipped = new Equipped();
                
                //creat×°±¸
                
            }
        }
        public void CreatItem()
        {
            GameObject item = null;

        }
		protected override void OnBeforeDestroy()
		{
		}
	}
}