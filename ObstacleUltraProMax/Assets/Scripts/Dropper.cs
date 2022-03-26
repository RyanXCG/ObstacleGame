using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

  MeshRenderer dropperRenderer;
  Rigidbody dropperRigidbody;
  [SerializeField] float timeToWait = 5f;


  // Start is called before the first frame update
  void Start()
  {
    dropperRenderer = GetComponent<MeshRenderer>();
    dropperRenderer.enabled = false;
    dropperRigidbody = GetComponent<Rigidbody>();
    dropperRigidbody.useGravity = false;
  }

  // Update is called once per frame
  void Update()
  {
    if (Time.time > timeToWait)
    {
      dropperRenderer.enabled = true;
      dropperRigidbody.useGravity = true;
    }
  }
}
