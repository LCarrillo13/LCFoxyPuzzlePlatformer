using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
 public Camera cam;
 public Rigidbody2D rb;
 public GameObject wallJumpable;
 // Constants 
 public const float MaxFall = 160f;
 private const float Gravity = 900f;
 public const float WalkSpeed = 64f;
 private const float DashSpeed = 240f;
 private Collision coll;
 // vars
 public bool canMove = true;
 public bool wallGrab = false;
 public bool wallJumped = false;
 public float wallJumpLerp = 1f;
 public float speed = 1f;
 public float jumpForce = 1f;

 void Start()
 {
  rb = GetComponent<Rigidbody2D>();
 }
 private void Update()
 {
  float x = Input.GetAxis("Horizontal");
  float y = Input.GetAxis("Vertical");
  float xRaw = Input.GetAxisRaw("Horizontal");
  float yRaw = Input.GetAxisRaw("Vertical");
  Vector2 dir = new Vector2(x, y);

  Walk(dir);
  if (Input.GetButtonDown("Jump"))
  {
   //if (coll)
   Jump(Vector2.up, false);
   //if (coll.onWall && !coll.onGround)
   //  TODO IMPLEMENT AND DEFINE WallJump(); 
  }
 }

 # region Movement

 private void Walk(Vector2 dir)
 {
  if (!canMove)
   return;

  if (wallGrab)
   return;

  if (!wallJumped) 
  {
    rb.velocity = new Vector2(dir.x * speed, rb.velocity.y);
  }
  else 
  {
   rb.velocity = Vector2.Lerp(rb.velocity, (new Vector2(dir.x * speed, rb.velocity.y)), wallJumpLerp * Time.deltaTime);
  }
 }

 private void Dash(float x, float y)
 {
  rb.velocity = Vector2.zero;
  Vector2 dir = new Vector2(x, y);
  rb.velocity += dir.normalized * DashSpeed;
  StartCoroutine(DashWait());
 }
 IEnumerator DashWait()
 {
  StartCoroutine(GroundDash());

  rb.gravityScale = 0;
  yield return new WaitForSeconds(.3f);
  rb.gravityScale = 3;
 }

 IEnumerator GroundDash()
 {
  yield return new WaitForSeconds(.15f);
 }

 #endregion
 

 private void Jump(Vector2 dir, bool wall)
 {
  rb.velocity = new Vector2(rb.velocity.x, 0);
  rb.velocity += dir * jumpForce;
  if (wallGrab)
  {
   Debug.Log("grabable wall");
  }
 }

 private void OnCollisionEnter(Collision other)
 {
  if (other.gameObject == wallJumpable)
  {
   Debug.Log("jumpable wall");
  }
 }
}

