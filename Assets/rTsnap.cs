using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class rTsnap : MonoBehaviour
{
    public Camera go_cam;
    public GameObject go_cam1;
    public GameObject go_front_topF;
    public GameObject go_back_topB;
    public GameObject go_sleeveL;
    public GameObject go_sleeveR;
    public GameObject go_skirtAF;
    public GameObject go_skirtAB;
    public GameObject go_skirtBF;
    public GameObject go_skirtBB;
    public GameObject go_skirtCF;
    public GameObject go_skirtCB;
    public Text t1;
    int frame_count = 0;

    void Start()
    {


    }


    public static Texture2D saveTexture(RenderTexture rt)
    {
        // you have to set the active render texture before you read pixels
        // this lets ReadPixels() knows what it's reading from
        RenderTexture.active = rt; // new
        Texture2D image = new Texture2D(rt.width, rt.height, TextureFormat.ARGB32, false);
        image.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0); // new

        image.Apply();
        return image;
    }

    // Update is called once per frame
    void Update()
    {
        frame_count++;
        t1.text = frame_count.ToString();
        //if (frame_count % 4 == 0)
        {
            //go_cam1.transform.localPosition = new Vector3(-35f, 0f, 0f);
            go_front_topF.GetComponent<Renderer>().material.SetTexture("_MainTex",
                saveTexture(go_cam.GetComponent<Camera>().targetTexture));
        }
        //if (frame_count % 4 == 1)
        {
            //go_cam1.transform.localPosition = new Vector3(-38f, 0f, 0f);
            go_back_topB.GetComponent<Renderer>().material.SetTexture("_MainTex",
                saveTexture(go_cam.GetComponent<Camera>().targetTexture));
            //frame_count = 1;
        }
        //if (frame_count % 4 == 2)
        {
            //go_cam1.transform.localPosition = new Vector3(-35f, -4f, 0f);
            go_sleeveL.GetComponent<Renderer>().material.SetTexture("_MainTex",
                go_cam.GetComponent<Camera>().targetTexture);
            go_sleeveR.GetComponent<Renderer>().material.SetTexture("_MainTex",
                saveTexture(go_cam.GetComponent<Camera>().targetTexture));
        }

    }

}