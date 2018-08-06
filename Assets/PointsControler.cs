using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PointsControler : MonoBehaviour
{
    private int score = 0;


    //スコアを表示するテキスト
    private GameObject score_text;

    void Start()
    {
        //シーンの中のPointsを取得
        this.score_text = GameObject.Find("Points");
    }

    void Update()
    {
        //score_textの文字列を代入する
        this.score_text.GetComponent<Text>().text = score.ToString();

        Debug.Log(score);


    }



    //衝突したら呼ばれる関数
    void OnCollisionEnter(Collision other)
    {

        // タグによって点数を変える
        if (other.gameObject.tag == "SmallStarTag")
        {
            score = score + 10;

        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            score = score + 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            score = score + 30;
        }

    }
}

            
    
