using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItemHover : MonoBehaviour
{

    private GameObject selector;


    
    public void Translate()
    {
        selector.transform.position = new Vector3(transform.position.x - 80f, transform.position.y, transform.position.z);
    } 
}
