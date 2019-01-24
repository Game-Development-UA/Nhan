using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float speed = 5f;
    Renderer rend;
    private void Start()
    {
        rend = GetComponent<Renderer>();
    
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.time * speed;
        rend.material.mainTextureOffset = new Vector2(offset, 0);
    }
}
