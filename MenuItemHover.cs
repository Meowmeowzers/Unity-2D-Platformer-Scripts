using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItemHover : MonoBehaviour
{
    [SerializeField] private GameObject selector;

    void Start()
    {
        selector = GameObject.Find("Select Icon");
    }

    void Update()
    {
        
    }

    public void Translate()
    {
        selector.transform.position = new Vector2(transform.position.x - 80f, transform.position.y);

    }
}
