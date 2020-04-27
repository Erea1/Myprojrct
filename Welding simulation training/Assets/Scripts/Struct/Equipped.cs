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

public struct Equipped
{
    public string name;//装备名字
    public string sprite;//英文名/贴图名
    public bool isRightSult;//装备是否是当前防护的正确装备
    public string info;//装备详细信息

    public Equipped(string _name,string _sprite,string _info, bool _isRight)
    {
        name = _name;
        sprite = _sprite;
        isRightSult = _isRight;
        info = _info;
    }

}
