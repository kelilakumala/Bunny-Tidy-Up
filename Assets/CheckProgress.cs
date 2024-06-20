using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckProgress : MonoBehaviour
{
    public GameObject level1Check;
    public GameObject level2Check;
    public GameObject level3Check;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("level1Status") == 0)
        {
            level1Check.SetActive(true);
        }
        else
        {
            level1Check.SetActive(false);
        }

        if (PlayerPrefs.GetInt("level2Status") == 0)
        {
            level2Check.SetActive(true);
        }
        else
        {
            level2Check.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
