using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
  [SerializeField] float xSpeed = 15.0f;
  [SerializeField] float yValue = 0.0f;
  [SerializeField] float zSpeed = 15.0f;
  // Start is called before the first frame update
  void Start()
  {
    PrintInstruction();
  }

  // Update is called once per frame
  void Update()
  {
    MovePlayer();
  }

  void PrintInstruction()
  {
    Debug.Log("Welcome to the game");
    Debug.Log("Move your player with wasd or arrow keys");
    Debug.Log("Don't hit the wall");
  }

  void MovePlayer()
  {
    float xValue = Input.GetAxis("Horizontal") * xSpeed * Time.deltaTime;
    float zValue = Input.GetAxis("Vertical") * zSpeed * Time.deltaTime;
    transform.Translate(xValue, yValue, zValue);
  }

}
