using UnityEngine;

public class Followplayer : MonoBehaviour
{
    public Transform playerTransform;
     public float offSet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 cameraPos = transform.position;
       cameraPos.z = playerTransform.position.z + offSet ;
       transform.position =  cameraPos;
    }
}
