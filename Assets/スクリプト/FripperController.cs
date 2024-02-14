using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJoint�R���|�[�l���g������
    private HingeJoint myHingeJoint;

    //�����̌X��
    private float defaultAngle = 20;
    //�e�������̌X��
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {
        //HingeJoint�R���|�[�l���g�擾
        this.myHingeJoint = GetComponent<HingeJoint>();

        //�t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {

        //�����L�[�EA�L�[�������������t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.S) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.DownArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //�E���L�[�ED�L�[�����������E�t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.S) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.DownArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //���L�[�EAD�L�[�����ꂽ���t���b�p�[�����ɖ߂�
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.S) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.DownArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.S) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.DownArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        //�X�}�z��ʂ̃^�b�`����

        if (Input.touchCount >0)
        {
            // �^�b�`���̎擾
            Touch tap = Input.GetTouch(0);//���������̕ϐ��͂ǂ��ɉ��̂������H������
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
            Touch tap1 = Input.GetTouch(1);//���������̕ϐ��͂ǂ��ɉ��̂������H������
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

    //�t���b�p�[�̌X����ݒ�
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}