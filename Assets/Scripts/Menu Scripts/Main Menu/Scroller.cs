using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
  
    public float speed;


    //The renderer for the background.
    [SerializeField]
    private Renderer bgRenderer;

    //X and Y offset for the background.
    private float x, y;
    
    // Update is called once per frame
    void Update()
    {

        //Scrolls the background on the X and Y axis.
        x += Time.deltaTime * speed;
        y += Time.deltaTime * speed;
        bgRenderer.enabled = true;
        bgRenderer.material.mainTextureOffset = new Vector2(x, y);
        
    }
}
