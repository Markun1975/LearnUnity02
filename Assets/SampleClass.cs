using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//キーボード入力
//・方向キー
//・ボタン入力

public class SampleClass : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Rawは整数値(-1,0,1)
        float rawX = Input.GetAxisRaw("Horizontal");
        Debug.Log(rawX);
        float rawZ = Input.GetAxisRaw("Vertical");
        Debug.Log(rawZ);

        //ボタン入力
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("Jを押した");
        }
    }
}
