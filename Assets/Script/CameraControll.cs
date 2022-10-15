using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CameraControll : MonoBehaviour
{

    public GameObject mainCamera;  //���C���J�����i�[
    public GameObject subCamera;   //�T�u�J�����i�[

    // Start is called before the first frame update
    void Start()
    {
        //�J�������擾
        mainCamera = GameObject.Find("MainCamera");
        subCamera = GameObject.Find("SubCamera");

        subCamera.SetActive(false); //�T�u�J�������A�N�e�B�u��
    }

    // Update is called once per frame
    void Update()
    {
        //�X�y�[�X�������ꂽ��J������؂�ւ���i�T�u�J�������A�N�e�B�u���j
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mainCamera.SetActive(!mainCamera.activeSelf);
            subCamera.SetActive(!subCamera.activeSelf);
        }
        //else
        //{
        //    subCamera.SetActive(false);
        //    mainCamera.SetActive(true);
        //}
    }
}
