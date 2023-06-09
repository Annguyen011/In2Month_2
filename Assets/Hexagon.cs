using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    public Rigidbody2D rb;
    public float shrinkSpeed = 3f;
    private void Start()
    {
        rb.rotation =Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;

    }
    private void Update()
    {
        transform.localScale -= Time.deltaTime * shrinkSpeed * Vector3.one;
        if (transform.localScale.x <= .5f  )
        {
            Destroy(gameObject);
        }
    }
}
