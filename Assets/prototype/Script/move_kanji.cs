using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_kanji : MonoBehaviour
{
    [SerializeField] GameObject kanjiobj = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown("space") == true)
        {
            // プレハブを元にオブジェクトを生成する
            GameObject instance = (GameObject)Instantiate(kanjiobj,
                                                          /*new Vector3(0.0f, 3.0f, 0.0f)*/this.transform.position,
                                                          Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            Vector3 nowvector3 = transform.position;
            nowvector3.x += 0.1f;
            transform.position = nowvector3;
            //this.transform.position = new Vector2(0f, 0.1f);
        }
        else if (Input.GetAxisRaw("Horizontal") == -1)
        {
            Vector3 nowvector3 = transform.position;
            nowvector3.x -= 0.1f;
            transform.position = nowvector3;
            //this.transform.position = new Vector2(0f, 0.1f);
        }
    }
}
