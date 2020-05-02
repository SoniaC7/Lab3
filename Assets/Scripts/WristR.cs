using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WristR : MonoBehaviour
{
    private int count;
    public Text count_text;
    public Material material;

    void Start()
    {
        count = 0;
        SetCountText();
    }

    void OnTriggerEnter(Collider other)
    {
    	if(other.gameObject.tag == "capsule")
    	{
    		other.gameObject.SetActive(false);
    		count = count + 1;
            SetCountText();
    	}

        if(other.gameObject.tag == "ball")
        {
            other.GetComponent<Renderer>().material = material;
        }
    }

    void SetCountText()
    {
        count_text.text = "Count: " + count.ToString();
    }
}
