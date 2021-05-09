using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private Rigidbody2D rigid2D;
  [SerializeField] private float jumpForce = 680.0f;
  [SerializeField] private float walkForce = 30.0f;
  [SerializeField] private float maxWalkSpeed = 2.0f;

  private void Start()
  {
    rigid2D = GetComponent<Rigidbody2D>();
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      rigid2D.AddForce(transform.up * jumpForce);
    }

    float key = Input.GetAxisRaw("Horizontal");

    float speedx = Mathf.Abs(rigid2D.velocity.x);

    if (speedx < maxWalkSpeed)
    {
      rigid2D.AddForce(transform.right * key * walkForce);
    }

    if (key != 0) transform.localScale = new Vector3(key, 1, 1);

  }
}