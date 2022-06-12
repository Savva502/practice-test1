using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    private Rigidbody2D rd;
    private SpriteRenderer sprite;

    private void Awake()
    {
        rd = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    private void Update()
    {
        if (Input.GetButton("Horizontal"))
            Run();
    }
    private void Run()
    {
        Vector dir = tansform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.posiyion, transform.position + dir, speed * Time.deltaTime);
    }
}

