using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCode_PopGain : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform parentTrans; 
    public Transform spawnPos; 
    public EffectPlayer_PopGather effect;

    Vector2 pointP => spawnPos.position;
    public float length = 50;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (true)
            {
                Vector2 randomPosition = GetRandomPosition(pointP, length) * Random.Range(0.9f, 1.3f);
                effect.PlayEffect_byV3(spawnPos.position + (Vector3)randomPosition, spawnPos.position);
            }
        }
    }

    Vector2 GetRandomPosition(Vector2 point, float distance)
    {
        float angle = Random.Range(0f, Mathf.PI * 2); 
        float x = point.x + distance * Mathf.Cos(angle); 
        float y = point.y + distance * Mathf.Sin(angle); 
        return new Vector2(x, y);
    }
}