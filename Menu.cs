using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject[] button;
    private int index = 0;
    private GameObject selector;

    private void Start()
    {
        selector = GameObject.Find("Select Icon");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Translate()
    {
        selector.transform.position = new Vector3(button[1].transform.position.x - 80f, button[1].transform.position.y, transform.position.z);
    }
}
