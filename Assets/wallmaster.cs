using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallmaster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Usekey
{
    static char key;
    public char Thekey(int keyskey)
    {
        if (keyskey == 0)
        {
            return key;
        }
        else
        {
            return 'n';
        }
    }
    public void Change_key(char keyy)
    {
        if (keyy == '0')
        {
            key = 'b';
        }
        else if (keyy == 't')
        {
            key = 'r';
        }
        else if (keyy == '1')
        {
            key = 'd';           
        }
        else if (keyy == '2')
        {
            key = 'y';
        }
        else
        {
            key = 'n';
        }
    }
}
