using UnityEngine;
     using UnityEngine.UI;
     using System.Collections;

public class bShape : MonoBehaviour
{
    public Slider slider;
    public SkinnedMeshRenderer skinnedMeshRenderer_F;
    public SkinnedMeshRenderer skinnedMeshRenderer_B; 
    int blendShapeCount;
    float sld_val_F = 0f;
    float sld_val_B = 0f;
    //int n = 20;
    int nB = 0;
    float swfl = 0f;
    float swflB = 0f;

    public Dropdown neckBool;
    public Slider Sld_sleeve;
    float sslv;

    //public Slider neckHtdSliderF;
    //public Slider neckHtdSliderB;

    void Awake()
    {
        skinnedMeshRenderer_F = GameObject.Find("model_J").GetComponent<SkinnedMeshRenderer>();
        skinnedMeshRenderer_B = GameObject.Find("model_J_back").GetComponent<SkinnedMeshRenderer>();
    }

    void Start()
    { 
    }

    void Update()
    {
        nB = neckBool.value;
        sslv = Sld_sleeve.value;
        if (sslv >= 0.063f)
        {
            //neckBool.Show();
            neckBool.transform.localScale = new Vector3(1f, 1f, 1f);

            if (nB == 1)
            {
                if (swfl == 0f)
                {
                    slider.value = sld_val_F;
                    swfl++;
                    swflB = 0f;
                }
                else
                {
                    sld_val_F = neck_type(sld_val_F);
                }
            }
            if (nB == 2)
            {
                if (swflB == 0f)
                {
                    slider.value = sld_val_B;
                    swflB++;
                    swfl = 0f;
                }
                else
                {
                    sld_val_B = neck_type(sld_val_B);
                }
            }
            if (nB == 0)
            {
                sld_val_F = 0f;
                sld_val_B = 0f;
                swfl = 0f;
                swflB = 0f;
                slider.value = 0f;
                neckBool.value = 0;
            }
        }
    }

    public float neck_type(float sldval)
    {
        nB = neckBool.value;
        sldval = slider.value;

        if ((sldval > 0) & (sldval < 100) )
        {
            if (nB == 1)
            {
                skinnedMeshRenderer_F.SetBlendShapeWeight(0, sldval);
                skinnedMeshRenderer_F.SetBlendShapeWeight(1, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(2, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(3, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(4, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(5, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(6, (0f)); 
            }
            if (nB == 2)
            {
                skinnedMeshRenderer_B.SetBlendShapeWeight(0, sldval);
                skinnedMeshRenderer_B.SetBlendShapeWeight(1, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(2, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(3, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(4, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(5, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(6, (0f)); 
            }
        }
        if ((sldval > 100) & (sldval < 100 *2) )
        {
            if (nB == 1)
            {
                skinnedMeshRenderer_F.SetBlendShapeWeight(0, (200f - sldval));
                skinnedMeshRenderer_F.SetBlendShapeWeight(1, (sldval-100f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(2, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(3, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(4, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(5, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(6, (0f)); 
            }
                if (nB == 2)
            {
                skinnedMeshRenderer_B.SetBlendShapeWeight(0, (200f - sldval));
                skinnedMeshRenderer_B.SetBlendShapeWeight(1, (sldval - 100f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(2, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(3, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(4, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(5, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(6, (0f)); 
            }
        }
        if ((sldval > 100*2) & (sldval < 100*3 ))
        {
            if (nB == 1)
            {
                skinnedMeshRenderer_F.SetBlendShapeWeight(0, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(1, (300f - sldval));
                skinnedMeshRenderer_F.SetBlendShapeWeight(2, (sldval - 200f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(3, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(4, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(5, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(6, (0f)); 
            }
                if (nB == 2)
            {
                skinnedMeshRenderer_B.SetBlendShapeWeight(0, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(1, (300f - sldval));
                skinnedMeshRenderer_B.SetBlendShapeWeight(2, (sldval - 200f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(3, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(4, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(5, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(6, (0f)); 
            }
        }
        if ((sldval > 100*3) & (sldval < 100*4 ))
        {
            if (nB == 1)
            {
                skinnedMeshRenderer_F.SetBlendShapeWeight(0, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(1, (400f - sldval));
                skinnedMeshRenderer_F.SetBlendShapeWeight(2, (sldval - 300f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(3, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(4, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(5, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(6, (0f)); 
            }
                if (nB == 2)
            {
                skinnedMeshRenderer_B.SetBlendShapeWeight(0, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(1, (400f - sldval));
                skinnedMeshRenderer_B.SetBlendShapeWeight(2, (sldval - 300f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(3, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(4, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(5, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(6, (0f)); 
            }
        }
        if ((sldval > 100 *4) & (sldval < 100*5 ))
        {
            if (nB == 1)
            {
                skinnedMeshRenderer_F.SetBlendShapeWeight(0, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(1, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(2, (500f - sldval));
                skinnedMeshRenderer_F.SetBlendShapeWeight(3, (sldval - 400f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(4, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(5, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(6, (0f)); 
            }
                if (nB == 2)
            {
                skinnedMeshRenderer_B.SetBlendShapeWeight(0, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(1, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(2, (500f - sldval));
                skinnedMeshRenderer_B.SetBlendShapeWeight(3, (sldval - 400f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(4, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(5, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(6, (0f)); 
            }
        }
        if ((sldval > 100 *5) & (sldval < 100*6))
        {
            if (nB == 1)
            {
                skinnedMeshRenderer_F.SetBlendShapeWeight(0, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(1, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(2, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(3, (600f - sldval));
                skinnedMeshRenderer_F.SetBlendShapeWeight(4, (sldval - 500f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(5, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(6, (0f)); 
            }
                if (nB == 2)
            {
                skinnedMeshRenderer_B.SetBlendShapeWeight(0, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(1, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(2, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(3, (600f - sldval));
                skinnedMeshRenderer_B.SetBlendShapeWeight(4, (sldval - 500f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(5, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(6, (0f)); 
            }
        }
        if ((sldval > 100 * 6) & (sldval < 100 * 7))
        {
            if (nB == 1)
            {
                skinnedMeshRenderer_F.SetBlendShapeWeight(0, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(1, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(2, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(3, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(4, (700f - sldval));
                skinnedMeshRenderer_F.SetBlendShapeWeight(5, (sldval - 600f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(6, (0f));
            }
            if (nB == 2)
            {
                skinnedMeshRenderer_B.SetBlendShapeWeight(0, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(1, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(2, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(3, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(4, (700f - sldval));
                skinnedMeshRenderer_B.SetBlendShapeWeight(5, (sldval - 600f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(6, (0f));
            }
        }
        if ((sldval > 100 * 7) & (sldval < 100 * 8))
        {
            if (nB == 1)
            {
                skinnedMeshRenderer_F.SetBlendShapeWeight(0, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(1, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(2, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(3, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(4, (0f));
                skinnedMeshRenderer_F.SetBlendShapeWeight(5, (800f - sldval));
                skinnedMeshRenderer_F.SetBlendShapeWeight(6, (sldval - 700f));
            }
            if (nB == 2)
            {
                skinnedMeshRenderer_B.SetBlendShapeWeight(0, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(1, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(2, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(3, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(4, (0f));
                skinnedMeshRenderer_B.SetBlendShapeWeight(5, (800f - sldval));
                skinnedMeshRenderer_B.SetBlendShapeWeight(6, (sldval - 700f)); 
            }
        }

        return sldval;
    }
}
