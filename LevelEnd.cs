using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{

    [SerializeField] private AudioSource sound;
    private bool isfinished = false;
    private void Start()
    {
        sound.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !isfinished)
        {
           isfinished = true;
           sound.Play();
           Invoke("LevelComplete", 5f);           
        }
    }

    private void LevelComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
