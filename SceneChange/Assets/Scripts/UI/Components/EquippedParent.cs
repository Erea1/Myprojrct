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
        public string profession;

        public string Profession
        {
            get { return profession;}
            set { profession = value; }
        }

        private void Awake()
        {
            Profession = "profession";
            InitEquippdes();

        }
        public void InitEquippdes()
        {
            string xmlPath = Application.streamingAssetsPath + "/config.xml";
            string[] equippdesInfo = Xml.ReadElements(xmlPath, "configuration/configInfo/equippde");
            for (int i = 0; i < equippdesInfo.Length; i++)
            {
                string[] detalInfo = equippdesInfo[i].Split('/');
                Equipped equipped = new Equipped(detalInfo[0],detalInfo[1],detalInfo[2],detalInfo[3]== Profession);
                equippeds.Add(equipped);
                //creat×°±¸
                
            }

            for (int i = 0; i < equippeds.Count; i++)
            {
                Debug.Log(equippeds[i].info+"   "+equippeds[i].isRightSult+"   "+equippeds[i].name+"  "+equippeds[i].sprite);
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