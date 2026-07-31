using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadManRotation : MonoBehaviour
{
    public GameObject entry;
    public GameObject exit;
    public Camera playerCamera;
    public GameObject player;
    public GameObject room;
    public CharacterController cc;
    public Hertzole.GoldPlayer.GoldPlayerController gpc;
    public bool spun = false;
    public float rotationAmount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter()
    {
        Renderer entryRenderer = entry.GetComponent<Renderer>();
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(playerCamera);
        bool canSee = GeometryUtility.TestPlanesAABB(planes, entryRenderer.bounds);

        Debug.Log(canSee);

        if (spun || canSee)
        {
            return;
        }

        // Vector3 teleportTarget = new Vector3(0, 10, 0);
        // goldPlayer.Movement.SetVelocity(Vector3.zero); // Optional: stop momentum
        // goldPlayer.transform.position = teleportTarget;

        gpc.enabled = false;
        cc.enabled = false;
        player.transform.SetParent(room.transform);
        // player.transform.Rotate(0, 90f, 0);
        // player.transform.Translate(100f, 0, 0);
        room.transform.Rotate(0, rotationAmount, 0);
        player.transform.Rotate(0, -rotationAmount, 0);
        // player.transform.Rotate(0, 90f, 0);
        // room.transform.rotation = Quaternion.Euler(0, -45f, 0);
        player.transform.SetParent(null);
        gpc.enabled = true;
        cc.enabled = true;

        spun = true;
    }
}
