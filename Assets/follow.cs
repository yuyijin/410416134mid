using UnityEngine;
using System.Collections;
public class follow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    bool bnear = false;
    void Update()
    {
        bool bk = Input.GetKey(KeyCode.Q);
        if (bk)
            bnear = true;
    }
    void LateUpdate()
    {
        if (bnear)
        {
            transform.position = player.transform.position + offset + new Vector3(0, -1, 0);
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}