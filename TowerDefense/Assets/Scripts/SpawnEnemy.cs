using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    private void Start() 
    {
        StartCoroutine(SpawnTime());
    }
IEnumerator SpawnTime()
        {
            for(int i = 0; i <= 4; i++)
            {
                yield return new WaitForSeconds(1.5f);
                
                Instantiate(Enemy, new Vector3(12,1.71000004f,-13.1300001f), Quaternion.Euler(0,0,0));
            }

        }
}