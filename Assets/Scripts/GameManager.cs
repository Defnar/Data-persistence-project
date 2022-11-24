using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public string playerName;
    public string bestScoreUsername;
    public int bestScore;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void storeName(string userName)
    {
        playerName = userName;
    }

    public void BestScore(string highestName, int score)
    {
        bestScoreUsername = highestName;
        bestScore = score;
    }

}
