using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class sleeve_leve_script : MonoBehaviour {
    public Slider Sld_sleeve;
    //sleeve level: 0.243f to 0.063f
    // Use this for initialization
    void Start () { 
	}
	
	// Update is called once per frame
	void Update () {
        if (Sld_sleeve.value <= 0.243f & Sld_sleeve.value >= 0.063f)
       GameObject.Find("leeve1_mASK").transform.localPosition = 
            new Vector3(Sld_sleeve.value, -0.458f, 0.0227f);


        //if (Sld_sleeve.value < 0.063f)
        //    topsUpperLevel.value = 0;

    }
}
