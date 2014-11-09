#pragma strict

function Start () {

}

function Update () 
{

}

function OnTriggerEnter (other : Collider) 
{
  // destroy all game objects that enter this area
  Destroy(other.gameObject);
}