using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;


public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public string playerName;
    public int score;
    public List<HighScores> highScoreList = new List<HighScores>();

    // Start is called before the first frame update
    void Start()
    {
        if (LoadData() != null)
        {
            highScoreList = LoadData().ToList();
        };
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

    public void addToHighScores()
    {
        HighScores newItem = new HighScores();
        newItem.name = playerName;
        newItem.score = score;
        ListManager.CompareScore<HighScores>(highScoreList, newItem, 10);
        SaveData();
    }


    [Serializable]
    private class Wrapper<T>
    {
        public T[] Items;
    }

    public void SaveData()
    {
        Wrapper<HighScores> wrapper = new Wrapper<HighScores>();
        wrapper.Items = highScoreList.ToArray();
        string json = JsonUtility.ToJson(wrapper);


        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public HighScores[] LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string data = File.ReadAllText(path);
            if (!string.IsNullOrEmpty(data))
            {
                Wrapper<HighScores> wrapper = JsonUtility.FromJson<Wrapper<HighScores>>(data);
                return wrapper.Items;
            }
            else
            {
                return null;
            }
        }
        return null;
    }

}
