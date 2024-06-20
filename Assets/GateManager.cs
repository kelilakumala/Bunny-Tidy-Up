using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GateManager : MonoBehaviour
{
    public TrashManager tm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tm.trashCount >= 20)
        {
            Destroy(this);
        }
    }
}
