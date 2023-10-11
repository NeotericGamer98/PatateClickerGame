using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
    [SerializeField] private RawImage ScrollingBackground;
    [SerializeField] private float _x, _y;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

        ScrollingBackground.uvRect = new Rect(ScrollingBackground.uvRect.position + (new Vector2(_x, _y) * Time.deltaTime), ScrollingBackground.uvRect.size);
        
    }
}
