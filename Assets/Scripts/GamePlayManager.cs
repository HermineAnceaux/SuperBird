using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    public GameObject originalPipe;
    public float pipeSpacing = 3f;

    void Start()
    {
        GenerateLevel();
    }

    void Update()
    {

    }

    public void GenerateLevel()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject pipe = Instantiate(originalPipe);
            pipe.transform.position = new Vector3(i * pipeSpacing, Random.Range(-1f, 1f), 0);
        }
    }
}
