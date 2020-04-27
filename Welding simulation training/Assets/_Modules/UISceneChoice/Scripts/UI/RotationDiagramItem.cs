/*
*Modify Data:2019-09-08
*Modifier:杨成超
*Modify Content: -用UIGU2D图片模拟3D物体的轮转功能
*/
using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RotationDiagramItem : MonoBehaviour, IDragHandler, IEndDragHandler
{
    #region 自定义变量
    public int PosId;//记录id
    [HideInInspector]public Action<float> _moveAction;//移动回调事件
    private Image _image;//加载动态图
    private float _offsetX;//UI位置x的偏移量
    private float _aniTime = 0.3f;//切换图片的动画时间
   
    private RectTransform _rect;
   
    private RectTransform Rect
    {
        get
        {
            if (_rect == null)
                _rect = GetComponent<RectTransform>();

            return _rect;
        }
    }
    #endregion
   
    #region 自定义函数
    public void SetParent(Transform parent)//设置自身父物体 面对对象思想，自身类设置自身的方法
    {
        transform.SetParent(parent);
    }
   
    public void SetPosData(ItemPosData data)//设置动画
    {
        Rect.DOLocalMove(Vector2.right * data.X, _aniTime);
        Rect.DOScale(Vector3.one * data.ScaleTimes, _aniTime);
        //StartCoroutine(Wait(data));
    }
    private IEnumerator Wait(ItemPosData data)
    {
        yield return new WaitForSeconds(_aniTime * 0.5f);
        transform.SetSiblingIndex(data.Order);
    }
    public void OnDrag(PointerEventData eventData)//拖拽
    {
        _offsetX += eventData.delta.x;
    }
    public void OnEndDrag(PointerEventData eventData)//结束拖拽
    {
        _moveAction(_offsetX);
        _offsetX = 0;
    }
    public void AddMoveListener(Action<float> onMove)//添加移动事件
    {
        _moveAction = onMove;
    }
    public void ChangeId(int symbol, int totalItemNum)//更新id
    {
        int id = PosId;
        id += symbol;
        if (id < 0)
        {
            id += totalItemNum;
        }
        PosId = id % totalItemNum;
    }
    #endregion
}
