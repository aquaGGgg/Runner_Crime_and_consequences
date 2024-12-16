using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class GraundAnimation : MonoBehaviour
{
    [SerializeField]
    private float _scrollY = 0.5f;

    void Update()
    {
        float OrffsexY = Time.time * _scrollY;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, OrffsexY);
    }
}
