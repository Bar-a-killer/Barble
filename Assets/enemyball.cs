using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyball : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int[] v = new int[2];
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(v[0] * Time.deltaTime, v[1] * Time.deltaTime, 0);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
    
        if (other.contacts[0].normal.x >= 0.5f || other.contacts[0].normal.x <= -0.5f)
        {
            v[0] = -v[0];
        }
        if (other.contacts[0].normal.y >= 0.5f || other.contacts[0].normal.y <= -1f)
        {
            v[1] = -v[1];
        }

    }
}
