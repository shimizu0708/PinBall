using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tokuten : MonoBehaviour
{
    //�C���X�y�N�^�[�ɕ\�����Text���͗�������
    public Text �\����e�L�X�g�I�u�W�F�N�g;
    //���v�_���i�[�p
    int ���v�_�� = 0;

    //�_�����Z
    
    private void OnCollisionEnter(Collision collision)�@//�Q�[���I�u�W�F�N�g�ɓ��������Ƃ�
    {
        if (collision.gameObject.CompareTag("LargeCloudTag"))//���������Q�[���I�u�W�F�N�g��LargeCloudTag�^�O�������Ƃ�
        {
            ���v�_�� += 20;
            �\����e�L�X�g�I�u�W�F�N�g.text = "Point    " + ���v�_��;
        }
        else if(collision.gameObject.CompareTag("SmallCloudTag"))//���������Q�[���I�u�W�F�N�g��SmallCloudTag�^�O�������Ƃ�
        {
            ���v�_�� += 10;
            �\����e�L�X�g�I�u�W�F�N�g.text = "Point    " + ���v�_��;
        }
        else if (collision.gameObject.CompareTag("LargeStarTag"))//���������Q�[���I�u�W�F�N�g��LargeStarTag�^�O�������Ƃ�
        {
            ���v�_�� += 30;
            �\����e�L�X�g�I�u�W�F�N�g.text = "Point    " + ���v�_��;
        }
        else if (collision.gameObject.CompareTag("SmallStarTag"))//���������Q�[���I�u�W�F�N�g��SmallStarTag�^�O�������Ƃ�
        {
            ���v�_�� += 5;
            �\����e�L�X�g�I�u�W�F�N�g.text = "Point    " + ���v�_��;
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        //�J�n���̕\��
        �\����e�L�X�g�I�u�W�F�N�g.text =�@"Point    " +���v�_��;

    }

    // Update is called once per frame
    void Update()
    {
   
    }

  
}
