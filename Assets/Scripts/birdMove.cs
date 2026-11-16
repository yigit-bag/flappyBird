using TMPro;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class birdMove : MonoBehaviour
{

    public float birdSpeed;
    Rigidbody2D rb;
    public TextMeshProUGUI scoreText;
    public float score;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.up * birdSpeed;
        }

        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "scoreArea")
        {
            score++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "deathArea")
        {
            SceneManager.LoadScene(0);
        }
    }
}
