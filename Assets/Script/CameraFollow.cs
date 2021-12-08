using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]//загугли по братски че это делает 
    private GameObject objectToFollow; //переменная для слежки за объектом (переменная видна в юнити) 

    [SerializeField]
    private Vector3 offset = new Vector3(0f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        if (objectToFollow == null)
        {
            Debug.Log("CameraFollowScript: Et ole asettanut" + "seurattavaa objektia");//Выводит текст в консоль, если функция была выполнена
            this.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objectToFollow.transform.position + offset;

    }
}
