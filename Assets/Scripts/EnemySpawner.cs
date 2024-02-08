using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int vel;
    public GameObject enemy;
    public GameObject enemy1;
    public GameObject enemy2;
    public float timeRepeat;
    public float number, posY;
    private Camera mainCamera;
    private float screenRightEdge;
    public float screenTopEdge;
    public float screenBottomEdge;

    private void Start()
    {
        mainCamera = Camera.main;
        screenRightEdge = mainCamera.ViewportToWorldPoint(new Vector3(1, 0, mainCamera.nearClipPlane)).x;
        screenTopEdge = mainCamera.ViewportToWorldPoint(new Vector3(0, 1, mainCamera.nearClipPlane)).y;
        screenBottomEdge = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane)).y;
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            number = Random.Range(0f, 4f);

            if (number > 1f && number < 2f)
                posY = Random.Range(screenBottomEdge, screenTopEdge);
            else if (number > 2f && number < 3f)
                posY = Random.Range(screenBottomEdge, screenTopEdge);
            else if (number > 3f)
                posY = Random.Range(screenBottomEdge, screenTopEdge);

            float spawnPosX = screenRightEdge;
            Vector3 spawnPos = new Vector3(spawnPosX, posY, transform.position.z);

            Instantiate(enemy, spawnPos + GetRandomOffset(), enemy.transform.rotation);
            yield return new WaitForSeconds(0.5f);

            Instantiate(enemy1, spawnPos + new Vector3(7f, -2f, 0f) + GetRandomOffset(), enemy1.transform.rotation);
            yield return new WaitForSeconds(0.5f);

            Instantiate(enemy2, spawnPos + new Vector3(6f, 3f, 0f) + GetRandomOffset(), enemy2.transform.rotation);
            yield return new WaitForSeconds(timeRepeat);
        }
    }

    private Vector3 GetRandomOffset()
    {
        float offsetX = Random.Range(-1f, 1f);
        float offsetY = Random.Range(-1f, 1f);
        return new Vector3(offsetX, offsetY, 0f);
    }
}