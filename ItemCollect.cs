using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollect : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private Text scoretext;
    [SerializeField] private AudioSource soundCollectApple;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("item_apple"))
        {
            Destroy(collision.gameObject);
            soundCollectApple.Play();
            score++;
            scoretext.text = ("Score: " +  score);
        }
    }


}
