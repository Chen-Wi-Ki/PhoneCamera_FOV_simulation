using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPlaneCtrl : MonoBehaviour
{
    public GameObject[] MyGridPlaneObj;
    public Material _Materia, _Materia_None;
    public void GridPlaneCtrlEventToOff()
    {
        for (int i = 0; i < MyGridPlaneObj.Length; i++)
        {
            MyGridPlaneObj[i].GetComponent<MeshRenderer>().material = _Materia_None;
        }
    }
    public void GridPlaneCtrlEventToOn()
    {
        for (int i = 0; i < MyGridPlaneObj.Length; i++)
        {
            MyGridPlaneObj[i].GetComponent<MeshRenderer>().material = _Materia;
        }
    }
}
