using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject nameMenu;
    private string playerName;
    public TMP_InputField textBox;



    // Start is called before the first frame update
    void Start()
    {
        startMenu.SetActive(true);
        nameMenu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void EnterNameInput()
    {
        startMenu.SetActive(false);
        nameMenu.SetActive(true);
    }

    public void GetUserName()
    {
        playerName = textBox.text;
        GameManager.Instance.storeName(playerName);
        Debug.Log(GameManager.Instance.playerName);
        SceneManager.LoadScene(1);
    }

}
