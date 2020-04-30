/****************************************************************************
 * 2020.4 DESKTOP-I056DAV
 ****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
using UnityEngine.EventSystems;
using Random = System.Random;

namespace VRCTP
{
	public partial class EquippedParent : UIComponent
    {
        private EquippedPanel equippedPanel;

        private string xmlPath;
        public List<Equipped> equippeds = new List<Equipped>();//装备列表
        public List<Equipped> rightEquippe = new List<Equipped>();//正确的装备列表
        public Text guideText;
        public GameObject eqippedsItem;//装备预设物
        public Transform equippedParent;//装备格子的父物体
        string profession;//专业名
        private ModleControl modleControl;
        
        public List<Equipped> currinEq = new List<Equipped>();
        int maxSultEquipped;
        public string Profession
        {
            get
            {
                profession = Xml.ReadElement(xmlPath, "configuration/configInfo/professionInfo/name");
                return profession;
            }
            
        }
        public int MaxSultEquipped {
            get {
                maxSultEquipped =int.Parse(Xml.ReadElement(xmlPath, "configuration/configInfo/professionInfo/equippdeCount")) ;
                return maxSultEquipped;
            }

        }
        private void Start()
        {
            xmlPath = Application.streamingAssetsPath + "/config.xml";
            modleControl = GameObject.Find("Human").GetComponent<ModleControl>();
           
            guideText.text = Xml.ReadElement(xmlPath, "configuration/configInfo/professionInfo/guidetext");
            
            equippedPanel = UIMgr.GetPanel<EquippedPanel>();
            
            CheckButton.GetComponent<Button>().onClick.AddListener(() => { CheckEquippde(); });
            equippedPanel.GuidancePanel.CloseButton.GetComponent<Button>().onClick.AddListener(() => { InitEquippdes(); });
            modleControl.equippedParent = equippedPanel.EquippedParent;
        }
        public void InitEquippdes()
        {
            equippedPanel.GuidancePanel.gameObject.SetActive(false);
            string[] equippdesInfo = Xml.ReadElements(xmlPath, "configuration/configInfo/equippde");
            for (int i = 0; i < equippdesInfo.Length; i++)
            {
                string[] detalInfo = equippdesInfo[i].Split('/');
                Equipped equipped = new Equipped(detalInfo[0],detalInfo[1],detalInfo[2],detalInfo[3]== Profession);
                equippeds.Add(equipped);
                if (equipped.isRightSult)
                    rightEquippe.Add(equipped);
                //creat装备
                //CreatItem(equipped);
                
            }

           


        }

        public  List<Equipped> ListRandom(List<Equipped> newlist)
        {
            Random ran = new Random();
            List<Equipped> newList = new List<Equipped>();

        }


        //生成装备按钮
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
            //先检查穿戴数量是否足够
            if (currinEq.Count<MaxSultEquipped)
            {
                Debug.Log("未穿戴所有部位");
            }


            //检查正确装备库中存在且已装备的装备
            var exp = rightEquippe.Where(a => currinEq.Exists(t => a.name.Contains(t.name))).ToList();
            foreach (var temp in exp)
            {
                Debug.Log("装备正确的："+temp.name);
            }
            //正确装备库中没有 但装备的
            var exp2 = currinEq.Where(a => !rightEquippe.Exists(t => a.name.Contains(t.name))).ToList();
            foreach (var temp in exp2)
            {
                Debug.Log("装备错误的：" + temp.name);
            }

        }

        public void AddEquipped(string value)
        {
            
            Transform[] trans = equippedParent.GetComponentsInChildren<Transform>();
           
            foreach (Transform tem in trans)
            {
               
                if (tem.name==value)
                {
                  
                    currinEq.Add(tem.GetComponentInChildren<EquippedItem>().thisEquipped);
                }
            }
        }

        public void RemoveEqipped(string value)
        {
            foreach (Transform tem in equippedParent)
            {
                if (tem.name == value)
                {
                    currinEq.Remove(tem.GetComponentInChildren<EquippedItem>().thisEquipped);
                }
            }
        }

        protected override void OnBeforeDestroy()
		{
		}
	}
}