using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ohajiki : MonoBehaviour
{
    /// <summary>
    /// ��������
    /// </summary>
    private Rigidbody physics = null;

    /// <summary>
    /// ����������
    /// </summary>
    public void Awake()
    {
        this.physics = this.GetComponent<Rigidbody>();
    }

    /// <summary>
    /// ���t���[�����Ƃ̏���
    /// </summary>
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.Flip(new Vector3(3f, 6f, 0));
        }
    }

    /// <summary>
    /// �{�[�����͂���
    /// </summary>
    /// <param name="force"></param>
    public void Flip(Vector3 force)
    {
        // �u�ԓI�ɗ͂������Ă͂���
        this.physics.AddForce(force, ForceMode.Impulse);
    }
}
