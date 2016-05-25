using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Dd_script_Skirts : MonoBehaviour {
    public Dropdown dDSkirt; 

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (dDSkirt.value == 4)
        { 
                // NOTE: gameObject.name MUST BE UNIQUE!!!!
                GetImage.GetImageFromUserAsync(gameObject.name, "ReceiveImage");
        }
        dDSkirt.value = 0;
    }

    static string s_dataUrlPrefix = "data:image/png;base64,";
    public void ReceiveImage(string dataUrl)
    {
        if (dataUrl.StartsWith(s_dataUrlPrefix))
        {
            byte[] pngData = System.Convert.FromBase64String(dataUrl.Substring(s_dataUrlPrefix.Length));

            // Create a new Texture (or use some old one?)
            Texture2D tex = new Texture2D(1, 1); // does the size matter?
            if (tex.LoadImage(pngData))
            {
                //Renderer renderer = GetComponent<Renderer>();
                GameObject.Find("SkirtA/skirt_front").GetComponent<Renderer>().material.SetTexture("_MainTex", tex);
                GameObject.Find("SkirtA/skirt_back").GetComponent<Renderer>().material.SetTexture("_MainTex", tex);

                GameObject.Find("SkirtB/skirt_front").GetComponent<Renderer>().material.SetTexture("_MainTex", tex);
                GameObject.Find("SkirtB/skirt_back").GetComponent<Renderer>().material.SetTexture("_MainTex", tex);

                GameObject.Find("SkirtC/skirt_front").GetComponent<Renderer>().material.SetTexture("_MainTex", tex);
                GameObject.Find("SkirtC/skirt_back").GetComponent<Renderer>().material.SetTexture("_MainTex", tex);
                 //renderer.material.mainTexture = tex;
            }
            else
            {
                Debug.LogError("could not decode image");
            }
        }
        else
        {
            Debug.LogError("Error getting image:" + dataUrl);
        }
    }
}
