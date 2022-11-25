using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreMenu : MonoBehaviour
{
    private int highScoreCount;
    public TMP_Text highScoreList;

    // Start is called before the first frame update
    void Start()
    {
        HighScores item = new HighScores();
        List<HighScores> currentList = new List<HighScores>();
        currentList = GameManager.Instance.highScoreList;
        highScoreCount = GameManager.Instance.highScoreList.Count;
        Debug.Log(currentList);

        if (highScoreCount == 0)
        {
            highScoreList.text = "Play some games!";
        }
        else
        {
            for (int i = 0; i < highScoreCount; i++)
            {
                highScoreList.text += $"{currentList[i].name}: {currentList[i].score} \n";

            }
        }
    }

    // Update is called once per frame

}
