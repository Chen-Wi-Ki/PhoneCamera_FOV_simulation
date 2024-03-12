using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridForEvent : MonoBehaviour
{
    public GameObject GridObj;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 OriginGridVector3 = GridObj.transform.position;
        Quaternion OriginGridQuaternion = GridObj.transform.rotation;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Instantiate(GridObj,
                   new Vector3(OriginGridVector3.x - (j * 10f), OriginGridVector3.y, OriginGridVector3.z + (i* 10f)),
                   OriginGridQuaternion);
            }
        }
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Instantiate(GridObj,
                   new Vector3(OriginGridVector3.x + (j * 10f), OriginGridVector3.y, OriginGridVector3.z + (i * 10f)),
                   OriginGridQuaternion);
            }
        }
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Instantiate(GridObj,
                   new Vector3(OriginGridVector3.x + (j * 10f), OriginGridVector3.y, OriginGridVector3.z - (i * 10f)),
                   OriginGridQuaternion);
            }
        }
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Instantiate(GridObj,
                   new Vector3(OriginGridVector3.x - (j * 10f), OriginGridVector3.y, OriginGridVector3.z - (i * 10f)),
                   OriginGridQuaternion);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
