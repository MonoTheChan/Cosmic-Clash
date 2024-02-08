/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Variaveis
    public int vel;
    public GameObject enemy;
    public GameObject enemy1;
    public GameObject enemy2;
    public float time, timeRepeat;
    public float number, posY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", time, timeRepeat);
    }

    void SpawnEnemy(){

        number = Random.Range(0f, 4f);

        if(number > 1f && number < 2f )
            posY = 3f;
        if(number > 2f && number < 3f)
            posY = -0.04f;
        if(number > 3f )
            posY = -4.05f;

        Instantiate(enemy, new Vector3(transform.position.x, posY, transform.position.z), enemy.transform.rotation);
        Instantiate(enemy1, new Vector3(transform.position.x+7, posY-2, transform.position.z), enemy1.transform.rotation);
        Instantiate(enemy2, new Vector3(transform.position.x+6, posY+3, transform.position.z), enemy2.transform.rotation);
    }
}
*/