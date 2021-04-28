using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public GameObject roulette_text = null;
    float z;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text result = roulette_text.GetComponent<Text>();
        Quaternion angle = GameObject.Find("roulette").transform.rotation;
        this.z = angle.eulerAngles.z;
        if (330 < this.z || this.z < 30)   // 0-30, 330-390,
        {
            result.text = "‹¥";
        }
        else if (30 < this.z && this.z < 90)  // 30-90,390-450,
        {
            result.text = "‘å‹g";
        }
        else if (90 < this.z && this.z < 150)
        {
            result.text = "‘å‹¥";
        }
        else if (150 < this.z && this.z < 210)
        {
            result.text = "¬‹g";
        }
        else if (210 < this.z && this.z < 270)
        {
            result.text = "––‹g";
        }
        else if (270 < this.z && this.z < 330)
        {
            result.text = "’†‹g";
        }
    }
}
