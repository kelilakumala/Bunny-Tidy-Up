using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;
public class TrashManager2 : MonoBehaviour
{
    public int trashCount;
    public Text trashText;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        trashText.text = trashCount.ToString();

        if (trashCount >= 11)
        {
            Destroy(door);
        }
    }
}
