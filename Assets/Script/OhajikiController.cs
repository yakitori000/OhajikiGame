using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhajikiController : MonoBehaviour
{
    //「MainOhajiki」ゲームオブジェクト
    [SerializeField] GameObject mainOhajiki = null;
    //「MainOhajiki」のリジットボディ
    Rigidbody mainRigid = null;


    // Start is called before the first frame update
    void Start()
    {
        //「MainOhajiki」のリジットボディを取得
        mainRigid = mainOhajiki.GetComponent<Rigidbody>();
        //「MainOhajiki」に力を加える
        mainRigid.AddForce(new Vector3(50f, 0f, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
