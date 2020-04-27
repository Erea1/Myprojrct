/*
*Modify Data:2020-04-15
*Modifier:李智
*Modify Content: -用UIGU2D图片模拟3D物体的轮转功能
*/
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class RotationDiagram2D : MonoBehaviour
{
    #region 自定义变量

    public string sceneName;
    public float Offset;//偏移比例
    public float ScaleTimesMin;//缩放最小比例
    public float ScaleTimesMax;//缩放最大比例
    private List<RotationDiagramItem> _items;//信息容器
    private List<ItemPosData> _posData;//信息容器
    public  GameObject template;
    Button LeftChoice;
    Button RightChoice;
    string xmlPath;
    
    #endregion

    #region 系统函数
    void Start()
    {
        LeftChoice = transform.Find("LButton").GetComponent<Button>();
        RightChoice = transform.Find("RButton").GetComponent<Button>();
        LeftChoice.onClick.AddListener(delegate {
            _items[0]._moveAction(-1);

            
        });
        RightChoice.onClick.AddListener(delegate {
            _items[0]._moveAction(1);
        });
        _items = new List<RotationDiagramItem>();
        _posData = new List<ItemPosData>();
        CreateItem();
        CalulateData();
        SetItemData();
    }
    #endregion

    #region 自定义函数
    


    private void CreateItem()//创建按钮物体
    {
        xmlPath = Application.streamingAssetsPath + "/config.xml";
        string[] sceneInfo = Xml.ReadElements(xmlPath, "configuration/configInfo/scene");

        
        RotationDiagramItem itemTemp = null;
        for (int i = 0; i < sceneInfo.Length; i++)
        {
            itemTemp = Instantiate(template).GetComponent<RotationDiagramItem>();
            itemTemp.SetParent(transform);
            itemTemp.AddMoveListener(Change);
            itemTemp.gameObject.GetComponentInChildren<Text>().text = sceneInfo[i].Split('/')[1];
            if (sceneInfo[i].Split('/')[2]=="0")
            {
                itemTemp.GetComponent<Button>().interactable = false;
            }
            int sceneNum = i;
            itemTemp.GetComponent<Button>().onClick.AddListener(delegate()
            {
               
                Debug.Log(sceneNum);
                SendSceneMessage(sceneInfo[sceneNum].Split('/')[0]);
                
            });
            _items.Add(itemTemp);
        }

        

    }
    //点击场景按钮记录场景名 
    public void SendSceneMessage(string sceneName)
    {
        Debug.Log("点击了名为："+sceneName+"的场景");
        this.sceneName = sceneName;
    }


    private void Change(float offsetX)//移动方向
    {
        int symbol = offsetX > 0 ? 1 : -1;
        Change(symbol);
    }
    private void Change(int symbol)
    {
        foreach (RotationDiagramItem item in _items)
        {
            item.ChangeId(symbol, _items.Count);
        }

        for (int i = 0; i < _posData.Count; i++)
        {
            if (_items[i].PosId!=0&& _items[i].PosId != 1&& _items[i].PosId != _posData.Count-1)
            {
                _items[i].gameObject.SetActive(false);
            }
            else
            {
                _items[i].gameObject.SetActive(true);
            }
            _items[i].SetPosData(_posData[_items[i].PosId]);
        }
    }
    private void CalulateData()//容器管理
    {
        List<ItemData> itemDatas = new List<ItemData>();

       
        float radioOffset = 1/(float)6;

        float radio = 0;
        for (int i = 0; i < _items.Count; i++)
        {
            ItemData itemData = new ItemData();
            itemData.PosId = i;
            itemDatas.Add(itemData);

            _items[i].PosId = i;

            ItemPosData data = new ItemPosData();
            data.X = GetX(radio, Offset);
            
            data.ScaleTimes = GetScaleTimes(radio, ScaleTimesMax, ScaleTimesMin);

            radio += radioOffset;
            _posData.Add(data);
        }
        for (int i = 0; i < _posData.Count; i++)
        {

            if (_items[i].PosId != 0 && _items[i].PosId != 1 && _items[i].PosId != _posData.Count - 1)
            {
                _items[i].gameObject.SetActive(false);
            }
            else
            {
                _items[i].gameObject.SetActive(true);
            }

        }
        itemDatas = itemDatas.OrderBy(u => _posData[u.PosId].ScaleTimes).ToList();
        for (int i = 0; i < itemDatas.Count; i++)
        {
            _posData[itemDatas[i].PosId].Order = i;
        }

       
    }
    private void SetItemData()//设置图片属性
    {
        for (int i = 0; i < _posData.Count; i++)
        {
            _items[i].SetPosData(_posData[i]);
        }
    }
    private float GetX(float radio, float length)//获取x比例系数
    {
        if (radio > 1 || radio < 0)
        {
            Debug.LogError("当前比例必须是0-1的值");
            return 0;
        }

        if (radio >= 0 && radio < 0.25f)
        {
            return length * radio;
        }
        else if (radio >= 0.25f && radio < 0.75f)
        {
            return length * (0.5f - radio);
        }
        else
        {
            return length * (radio - 1);
        }
    }
    public float GetScaleTimes(float radio, float max, float min)//获取缩放比例系数
    {
        if (radio > 1 || radio < 0)
        {
            Debug.LogError("当前比例必须是0-1的值");
            return 0;
        }

        float scaleOffset = (max - min) / 0.5f;

        if (radio < 0.5f)
        {
            return max - scaleOffset * radio;
        }
        else
        {
            return max - scaleOffset * (1 - radio);
        }
    }
    #endregion  
}
#region 封装结构体属性
public class ItemPosData
{
    public float X;//x的偏移比例系数
    public float ScaleTimes;//缩放比例系数
    public int Order;//图片层级id
}
public struct ItemData
{
    public int PosId;//记录加载的id
}
#endregion
