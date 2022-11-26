using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuUIHandler : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject nameMenu;
    private string playerName;
    public TMP_InputField textBox;
    public GameObject highScoreMenu;
    public GameObject titleScreen;



    // Start is called before the first frame update
    void Start()
    {
        MainScreen();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainScreen()
    {
        titleScreen.SetActive(true);
        startMenu.SetActive(true);
        nameMenu.SetActive(false);
        highScoreMenu.SetActive(false);
    }

    //allows input of name
    private void EnterNameInput()
    {
        startMenu.SetActive(false);
        nameMenu.SetActive(true);
    }


    //saves name and starts game
    public void GetUserName()
    {
        playerName = textBox.text;
        GameManager.Instance.storeName(playerName);
        SceneManager.LoadScene(1);
    }

    //loads high score menu;
    public void OpenHighScores()
    {
        titleScreen.SetActive(false);
        highScoreMenu.SetActive(true);
    }

    public void exitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
