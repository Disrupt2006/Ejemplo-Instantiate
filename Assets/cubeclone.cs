using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeclone : MonoBehaviour
{

    public GameObject prefab;
    public GameObject clon;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i<3; i++)
        {
            // insancia este objeto (duplica)
            clon = Instantiate(prefab);
            clon.transform.Translate(i, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
