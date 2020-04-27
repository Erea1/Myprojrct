/****************************************************************************
 * 2020.4 DESKTOP-I056DAV
 ****************************************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
using UnityEngine.EventSystems;

namespace VRCTP
{
	public partial class EquippedParent : UIComponent
	{
        public List<Equipped> equippeds = new List<Equipped>();//装备列表
        public GameObject eqippedsItem;//装备预设物
        public Transform equippedParent;//装备格子的父物体
        public string profession;//专业名
        public GameObject canvas;//
        public GameObject eqInfoPanel;
        public ModleControl modleControl;
        public Button CheckButton;
        public List<EquippedItem> currinEq = new List<EquippedItem>();
        public string Profession
        {
            get { return profession;}
            set { profession = value; }
        }

        private void Start()
        {
            modleControl = GameObject.Find("Human").GetComponent<ModleControl>();
            modleControl.equippedParent = this.GetComponent<EquippedParent>();
            Profession = "profession";
            InitEquippdes();

            CheckButton.GetComponent<Button>().onClick.AddListener(() => { CheckEquippde(); });


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
                //creat装备
                CreatItem(equipped);
                
            }

            //for (int i = 0; i < equippeds.Count; i++)
            //{
            //    Debug.Log(equippeds[i].info+"   "+equippeds[i].isRightSult+"   "+equippeds[i].name+"  "+equippeds[i].sprite);
            //}


        }
        public void CreatItem(Equipped equipped)
        {
            GameObject item = Instantiate(eqippedsItem, equippedParent);
            item.name = equipped.sprite;
            EquippedItem Item = item.GetComponentInChildren<EquippedItem>();
            Item.thisEquipped = equipped;
           
            item.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("EquippedImage/" + equipped.sprite);
            item.GetComponentInChildren<Button>().onClick.AddListener(() =>
            {
                modleControl.SetEquipped(Item);
            });

        }
        //检查所穿戴的是否正确
        public void CheckEquippde()
        {
            Debug.Log(currinEq.Count);
            foreach (EquippedItem temEquippedItem in currinEq)
            {
                Debug.Log(temEquippedItem.thisEquipped.name);



            }
        }

        public void AddEquipped(string value)
        {
            
            Transform[] trans = equippedParent.GetComponentsInChildren<Transform>();
           
            foreach (Transform tem in trans)
            {
               
                if (tem.name==value)
                {
                  
                    currinEq.Add(tem.GetComponentInChildren<EquippedItem>());
                }
            }
        }

        public void RemoveEqipped(string value)
        {
            foreach (Transform tem in equippedParent)
            {
                if (tem.name == value)
                {
                    currinEq.Remove(tem.GetComponentInChildren<EquippedItem>());
                }
            }
        }

        protected override void OnBeforeDestroy()
		{
		}
	}
}