using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    [SerializeField] float[] pos = new float[2] ;
    // Start is called before the first frame update
    void Start()
    {

        //float a = transform.parent.GetComponent<Transform>().position.x ;
        float b = this.GetComponent<Transform>().position.x ;
        pos[0] = b ;
        //a = transform.parent.GetComponent<Transform>().position.y;
        b = this.GetComponent<Transform>().position.y;
        pos[1] = b ;

    }

    // Update is called once per frame
    void Update()
    {
        Usekey usekey = new Usekey();
        char resetkey = usekey.Thekey(0);
        if(resetkey == 'd')
        {
            GetComponent<Transform>().position = new Vector2( pos[0], pos[1]);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "player")
        {
            GetComponent<Transform>().position = new Vector2(-60, 1);
            //Destroy(gameObject);
        }
    }
}
