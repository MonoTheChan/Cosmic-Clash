using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour{

    public float vel;

    void Start()
    {
        Destroy(gameObject, 8);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * vel * Time.deltaTime);

    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Bullet"){
            Destroy(col.gameObject, 0.001f);
            Destroy(gameObject, 0.001f);
        }
    }
}
