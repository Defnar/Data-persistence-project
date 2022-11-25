using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public static class ListManager
{


    public static HighScores item = new HighScores();


    public static List<HighScores> CompareScore<T>(List<HighScores> S, HighScores current, int maxSize)
    {
        int itemCount = S.Count;

        //adds item to 1st spot if the high score history is empty
        if (S.Count == 0)
        {
            S.Add(current);
        }
        else
        {

            //iterates through all high scores to a maximum number
            for (int i = 0; i < maxSize; i++)
            {

                item = S[i];

                //if the list is not full and smallest score, adds to end


                //inserts score in proper position
                if (current.score > item.score)
                {
                    S.Insert(i, current);
                    break;
                }

                if (i == S.Count - 1)
                {
                    S.Add(current);
                    break;
                }
            }

            //culls the list down to max size
            {
                while (S.Count > maxSize)
                {
                    S.RemoveAt(maxSize);
                }
            }
        }
        return S;
    }

}
