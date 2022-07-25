using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody rb;
    public int HitPoints = 3;
    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }
    Vector3 a = new Vector3(-2,0,0);
    int i = 0;
    void Update()
    {
        Ray ray = new Ray(transform.position, -transform.right);
        Debug.DrawRay(transform.position, -transform.right*100f, Color.yellow);

        int layerMask = 1 << 6;
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, layerMask))
        {
            
            
            
            
            if(hit.distance > 2)
            {
                rb.velocity = a;
            }
            else
            {
                
                i += 1;
                if(i == 1)
                {
                    a = new Vector3(0,0,2);
                    transform.Rotate(0,90,0);
                }
                
                
                if(i == 2)
                {   
                    a = new Vector3(2,0,0);
                    transform.Rotate(0,90,0);
                    
                }
                if(i==3)
                {
                    i = 0;
                    a = new Vector3(-2,0,0);
                    transform.Rotate(0,180,0);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        HitPoints -= 1;
    }

 }
 