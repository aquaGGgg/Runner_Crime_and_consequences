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
    }

}
