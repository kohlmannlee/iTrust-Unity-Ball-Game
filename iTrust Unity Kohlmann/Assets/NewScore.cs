using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text score;
    public static int initialScore;


    void Start()
    {
        initialScore = 0;
        score.text = initialScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = (initialScore).ToString();
    }
}
