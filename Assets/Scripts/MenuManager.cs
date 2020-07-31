using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "QuitBox")
        {
            QuitGame();
        }
        if (collision.tag == "LevelSelectBox")
        {
            LevelSelect();
        }
        if (collision.tag == "PlayBox")
        {
            StartGame();
        }
        if (collision.tag == "LevelSelect1")
        {
            SceneManager.LoadScene("Level1");
        }
        if (collision.tag == "LevelSelect2")
        {
            SceneManager.LoadScene("Level2");
        }
        if (collision.tag == "LevelSelect3")
        {
            SceneManager.LoadScene("Level3");
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void QuitGame()
    {
        Debug.Log("QuitGame");
        Application.Quit();
    }
}