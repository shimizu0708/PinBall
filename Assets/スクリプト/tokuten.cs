using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tokuten : MonoBehaviour
{
    //インスペクターに表示先のText入力欄を入れる
    public Text 表示先テキストオブジェクト;
    //合計点数格納用
    int 合計点数 = 0;

    //点数加算
    
    private void OnCollisionEnter(Collision collision)　//ゲームオブジェクトに当たったとき
    {
        if (collision.gameObject.CompareTag("LargeCloudTag"))//当たったゲームオブジェクトがLargeCloudTagタグだったとき
        {
            合計点数 += 20;
            表示先テキストオブジェクト.text = "Point    " + 合計点数;
        }
        else if(collision.gameObject.CompareTag("SmallCloudTag"))//当たったゲームオブジェクトがSmallCloudTagタグだったとき
        {
            合計点数 += 10;
            表示先テキストオブジェクト.text = "Point    " + 合計点数;
        }
        else if (collision.gameObject.CompareTag("LargeStarTag"))//当たったゲームオブジェクトがLargeStarTagタグだったとき
        {
            合計点数 += 30;
            表示先テキストオブジェクト.text = "Point    " + 合計点数;
        }
        else if (collision.gameObject.CompareTag("SmallStarTag"))//当たったゲームオブジェクトがSmallStarTagタグだったとき
        {
            合計点数 += 5;
            表示先テキストオブジェクト.text = "Point    " + 合計点数;
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        //開始時の表示
        表示先テキストオブジェクト.text =　"Point    " +合計点数;

    }

    // Update is called once per frame
    void Update()
    {
   
    }

  
}
