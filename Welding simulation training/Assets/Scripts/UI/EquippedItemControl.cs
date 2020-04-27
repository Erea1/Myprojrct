/*
 * 版本号：v1.0
 * Modify：修改日期
 * Modifier：李智
 * Modify Reason：修改原因
 * Modify Content：修改内容说明
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EquippedItemControl : MonoBehaviour {

    #region 定义变量
    RectTransform rectTransform;
    RectTransform canvasRectTransform;
    Vector2 pos;
    public GameObject equippedInfo;
    public GameObject canvas;
    #endregion
    #region 系统函数
    // Use this for initialization
    void Start () {
        canvas = GameObject.Find("UIRoot");
        rectTransform = equippedInfo.transform as RectTransform;
        canvasRectTransform = canvas.transform as RectTransform;
    }
	
	// Update is called once per frame
	void Update () {
        if (GetOverUI()==null)
        {
            return;
        }

        if (GetOverUI().tag == "Equipped")
        {
            equippedInfo.SetActive(true);
            equippedInfo.GetComponentInChildren<Text>().text =  GetOverUI().GetComponentInChildren<EquippedItem>().thisEquipped.info;


            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRectTransform, Input.mousePosition, canvas.GetComponent<Canvas>().worldCamera, out pos);
            rectTransform.anchoredPosition = new Vector2(pos.x+rectTransform.sizeDelta.x/2,pos.y+rectTransform.sizeDelta.y/2); 

            
        } else
        {
            
            equippedInfo.SetActive(false);
        }
    }
    #endregion
    #region 自定义函数
    public GameObject GetOverUI()
    {
        PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
        pointerEventData.position = Input.mousePosition;
        GraphicRaycaster gr = canvas.GetComponent<GraphicRaycaster>();
        List<RaycastResult> results = new List<RaycastResult>();
        gr.Raycast(pointerEventData, results);
        if (results.Count != 0)
        {
            return results[0].gameObject;
        }

        return null;
    }
    #endregion
}
