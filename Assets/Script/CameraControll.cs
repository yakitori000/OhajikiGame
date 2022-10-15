using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CameraControll : MonoBehaviour
{

    public GameObject mainCamera;  //メインカメラ格納
    public GameObject subCamera;   //サブカメラ格納

    // Start is called before the first frame update
    void Start()
    {
        //カメラを取得
        mainCamera = GameObject.Find("MainCamera");
        subCamera = GameObject.Find("SubCamera");

        subCamera.SetActive(false); //サブカメラを非アクティブ化
    }

    // Update is called once per frame
    void Update()
    {
        //スペースが押されたらカメラを切り替える（サブカメラをアクティブ化）
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
