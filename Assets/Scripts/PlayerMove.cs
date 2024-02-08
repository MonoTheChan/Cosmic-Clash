using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour{
    public int vel = 3;
    public int velBala = 3;
    public GameObject bullet;

    public int vida;
    private GameObject vida1, vida2, vida3;
    private Image vida1Im, vida2Im, vida3Im;
    public string gameover;

    // Start is called before the first frame update
    void Start()
    {
        vida1 = GameObject.FindWithTag("Vida1");
        vida1Im = vida1.GetComponent<Image>();
        vida2 = GameObject.FindWithTag("Vida2");
        vida2Im = vida2.GetComponent<Image>();
        vida3 = GameObject.FindWithTag("Vida3");
        vida3Im = vida3.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Fire();

        if(vida == 0)
            vida1Im.enabled = false;
        if(vida == 1)
            vida2Im.enabled = false;
        if(vida == 2)
            vida3Im.enabled = false;
        if(vida < 0){
            SceneManager.LoadScene(gameover);
        }
    }

    void Move(){
        //Direita
        if(Input.GetAxis("Horizontal") > 0){
            transform.Translate(vel * Time.deltaTime ,0,0);
        }
        //Esquerda
        if(Input.GetAxis("Horizontal") < 0){
            transform.Translate(-vel * Time.deltaTime ,0,0);
        }
        //Frente
        if(Input.GetAxis("Vertical") > 0){
            transform.Translate(0, vel * Time.deltaTime , 0);
        }
        //Atras
        if(Input.GetAxis("Vertical") < 0){
            transform.Translate(0,-vel * Time.deltaTime ,0);
        }
    }

    void Fire(){
        if(Input.GetButtonDown("Fire1")){
            GameObject clone;
            clone = Instantiate(bullet, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), transform.rotation);
           // Vector2.right * velBala * Time.deltaTime
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Enemy"){
            vida = vida - 1;
            Destroy(col.gameObject, 0.001f);
        }
    }
}
