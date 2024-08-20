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

 // Constants 
 public const float MaxFall = 160f;
 private const float Gravity = 900f;
 private const float HalfGravThreshold = 40f;

 private const float FastMaxFall = 240f;
 private const float FastMaxAccel = 300f;

 public const float MaxRun = 90f;
 public const float RunAccel = 1000f;
 private const float RunReduce = 400f;
 private const float AirMult = .65f;
 public const float WalkSpeed = 64f;

 private const float DashSpeed = 240f;
 private const float EndDashSpeed = 160f;
 private const float EndDashUpMult = .75f;
 private const float DashTime = .15f;
 private const float DashCooldown = .2f;
 private const float DashRefillCooldown = .1f;
 private const int DashHJumpThruNudge = 6;
 private const int DashCornerCorrection = 4;
 private const int DashVFloorSnapDist = 3;
 private const float DashAttackTime = .3f;

 public float fallMultiplier = 2.5f;
 public float lowJumpMultiplier = 2f;

 private Collision coll;
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
  //if (coll.onGround)
  //     hasDashed = false;
 }

 #endregion
 

 private void Jump(Vector2 dir, bool wall)
 {

  rb.velocity = new Vector2(rb.velocity.x, 0);
  rb.velocity += dir * jumpForce;




 }
}

