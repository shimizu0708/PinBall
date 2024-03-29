using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJointコンポーネントを入れる
    private HingeJoint myHingeJoint;

    //初期の傾き!
    private float defaultAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {
        //HingeJointコンポーネント取得
        this.myHingeJoint = GetComponent<HingeJoint>();

        //フリッパーの傾きを設定
        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {

        //左矢印キー・Aキーを押した時左フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.S) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.DownArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //右矢印キー・Dキーを押した時右フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.S) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.DownArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //矢印キー・ADキー離された時フリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.S) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.DownArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.S) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.DownArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        //スマホ画面のタッチ入力

        if (Input.touchCount >0)
        {
            // タッチ情報の取得
            Touch tap = Input.GetTouch(0);//☆☆☆この変数はどこに奥のが正解？☆☆☆
            if (tap.position.x <= Screen.width / 2 && tag == "LeftFripperTag" )
            {
                SetAngle(this.flickAngle);
            }
            if (tap.position.x > Screen.width / 2 && tag == "RightFripperTag")
            {
                SetAngle(this.flickAngle);
            }


            if (tap.phase == TouchPhase.Ended)
            {
                SetAngle(this.defaultAngle);
            }


        }
        if (Input.touchCount >1)
        {
            Touch tap1 = Input.GetTouch(1);//☆☆☆この変数はどこに奥のが正解？☆☆☆
            if (tap1.position.x <= Screen.width / 2 && tag == "LeftFripperTag")
            {
                SetAngle(this.flickAngle);
            }
                if (tap1.position.x > Screen.width / 2 && tag == "RightFripperTag")
            {
                SetAngle(this.flickAngle);
            }
           
 
            
            if (tap1.phase == TouchPhase.Ended)
            {
                SetAngle(this.defaultAngle);
            }
        }
        
    }

    //フリッパーの傾きを設定
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}