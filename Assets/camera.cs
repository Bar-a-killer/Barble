using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    float maphight = 38, mapwigh = 70;

    //[SerializeField] GameObject player = GameObject.Find("frog");
    //[SerializeField] GameObject[] mapPrefab;
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("frog").transform.position.x > transform.position.x + mapwigh / 2)
            transform.Translate(mapwigh, 0, 0);
        if (GameObject.Find("frog").transform.position.x < transform.position.x - mapwigh / 2)
            transform.Translate(-mapwigh, 0, 0);
        if (GameObject.Find("frog").transform.position.y < transform.position.y - maphight / 2)
            transform.Translate(0, -maphight, 0);
        if (GameObject.Find("frog").transform.position.y > transform.position.y + maphight / 2)
            transform.Translate(0, maphight, 0);
    }
}
