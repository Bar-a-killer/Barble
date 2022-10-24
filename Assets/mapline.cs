using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapline : MonoBehaviour
{
    [SerializeField] public float[] map = new float[2];
    [SerializeField] GameObject[] mapPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.contacts[0].normal == new Vector2(1f, 0f))
        {
            Checkmap checkmap = new Checkmap();
            checkmap.Nextmap(map[1]);
            
        }

        else if (other.contacts[0].normal == new Vector2(-1f, 0f))
        {
            Checkmap checkmap = new Checkmap();
            checkmap.Nextmap(map[0]);
          
        }

        if (other.contacts[0].normal == new Vector2(0f, 1f))
        {
            Checkmap checkmap = new Checkmap();
            checkmap.Nextmap(map[1]);

        }

        else if (other.contacts[0].normal == new Vector2(0f, -1f))
        {
            Checkmap checkmap = new Checkmap();
            checkmap.Nextmap(map[0]);

        }
    }
}
public class Checkmap
{
    static float map;
    public void Nextmap(float a)
    {
        map = a;
    }
    public float Getmap()
    {
        return map;
    }
}
