using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using VRCTP;

public class ModleControl : MonoBehaviour
{
    public Transform[] transforms;

    public EquippedParent equippedParent;
    // Use this for initialization
    void Start () {
       
    }
	// Update is called once per frame
	void Update () {




        if (Input.GetMouseButton(0))
        {//控制上下左右旋转
            transform.Rotate(Vector3.down, Time.deltaTime * 700 * Input.GetAxis("Mouse X"), Space.World);
            //transform.Rotate(Vector3.right, Time.deltaTime * 700 * Input.GetAxis("Mouse Y"), Space.World);
        }
    }
    //按装备按钮时调用这个方法
    public void SetEquipped( EquippedItem eqName)
    {

        Transform eq = null;
        for (int i = 0; i < transforms.Length; i++)
        {
            eq = transforms[i].Find(eqName.thisEquipped.sprite);
            if (eq!=null)
                break;
            
        }
        foreach (Transform temp in eq.parent)
        {
            if (temp.name==eqName.thisEquipped.sprite)
            {
                temp.gameObject.SetActive(true);
                equippedParent.AddEquipped(temp.name); 
            }
            else
            {
                temp.gameObject.SetActive(false);
                equippedParent.RemoveEqipped(temp.name);
            }
        }
    }

   

}
