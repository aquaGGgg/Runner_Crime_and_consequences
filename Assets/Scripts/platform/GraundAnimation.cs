using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using System;

public class GraundAnimation : MonoBehaviour
{
    [SerializeField]
    private float _scrollY = 0.5f;
    [SerializeField]
    private float _scrollX = 0.5f;

    void FixedUpdate()
    {
        float OrffsexY = Time.time * _scrollY;
        float OrffsexX = Time.time * _scrollX;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(OrffsexX, OrffsexY);

        if(Math.Round(Time.time, 1)%10 ==0){
            //_scrollY*=1.1f;
            //_scrollX+=100f;
        }
    }

}
