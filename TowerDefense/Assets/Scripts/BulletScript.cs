using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    Transform target;
    float speed = 10f;
    
    void Update()
    {
        Move();
    }

    public void SetTarget(Transform Enemy)
    {
      target = Enemy;   
    }
    
    private void Move()
    {
        
        if(target != null)
        {
            if(Vector3.Distance(transform.position, target.position) < 0.8f)
            {
                Destroy(gameObject);
            }
            else
            {
                Vector3 dir = target.position - transform.position;
                transform.Translate(dir.normalized * Time.deltaTime * speed);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
