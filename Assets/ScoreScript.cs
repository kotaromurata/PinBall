using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    //スコアを表示するテキスト
    public GameObject ScoreText;
    public int Score = 0;

    // Use this for initialization
    void Start()
    {
        //シーン中のScoreTextオブジェクトを取得
        ScoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        //それぞれのオブジェクトの得点を設定
        if (other.gameObject.tag == "SmallStarTag")
        {
            Score += 5;
            Debug.Log("5");
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            Score += 10;
            Debug.Log("10");
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            Score += 15;
            Debug.Log("15");
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            Score += 20;
            Debug.Log("20");
        }
        ScoreText.GetComponent<Text>().text = "Score:" + Score;
    }
    void Update()
    {
    }
}