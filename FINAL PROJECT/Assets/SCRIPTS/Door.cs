using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool playerDetected;
    public Transform doorPos;
    public float width;
    public float height;

    public LayerMask whatIsPlayer;

    [SerializeField]
    private string sceneName;

    SwitchScene sceneSwitch;

    private void Start()
    {
        sceneSwitch = FindObjectOfType<SwitchScene>();
    }

    private void Update()
    {
        playerDetected = Physics2D.OverlapBox(doorPos.position, new Vector2(width, height), 0,whatIsPlayer);

        if (playerDetected == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                sceneSwitch.SceneSwitch(sceneName);
            }

        }

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(doorPos.position, new Vector3(width, height, 1));
    }
}
