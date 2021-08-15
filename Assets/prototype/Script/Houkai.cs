using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Houkai : MonoBehaviour
{
    public GameObject kokoro2 = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        //gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(0,0,0), 0.1f);
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, kokoro2.transform.position, 1f);
    }
}
