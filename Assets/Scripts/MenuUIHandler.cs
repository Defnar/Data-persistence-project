using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject nameField;
    public GameObject playButton;
    public GameObject highScoreButton;
    public GameObject startButton;
    public GameObject exitButton;
    private string playerName;
    public TMP_InputField textBox;



    // Start is called before the first frame update
    void Start()
    {
        titleScreen.SetActive(true);
        nameField.SetActive(false);
        playButton.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void EnterNameInput()
    {
        startButton.SetActive(false);
        highScoreButton.SetActive(false);
        exitButton.SetActive(false);
        nameField.SetActive(true);
        playButton.SetActive(true);
    }

    public void GetUserName()
    {
        playerName = textBox.text;
        GameManager.Instance.storeName(playerName);
        Debug.Log(GameManager.Instance.playerName);
        SceneManager.LoadScene(1);
    }

}
