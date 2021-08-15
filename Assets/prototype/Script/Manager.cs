using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] GameObject kanjiimg=null;
    bool beforecreate = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")&&beforecreate == true)
        {
            // プレハブを元にオブジェクトを生成する
            GameObject instance = (GameObject)Instantiate(kanjiimg,
                                                          new Vector3(0.0f, 3.0f, 0.0f),
                                                          Quaternion.identity);
            beforecreate = false;
        }
        else if(Input.GetKeyDown("space") && beforecreate == false)
        {
            beforecreate = true;
        }
    }

}

