using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadManRotation : MonoBehaviour
{
    public GameObject entry;
    public GameObject exit;
    public GameObject deadMan;
    public Camera playerCamera;
    public GameObject player;
    public GameObject room;
    public GameObject playerParent;
    public CharacterController cc;
    public Hertzole.GoldPlayer.GoldPlayerController gpc;
    public Hertzole.GoldPlayer.GoldPlayerInput gpi;
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
        Renderer entryRenderer = deadMan.GetComponent<Renderer>();
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(playerCamera);
        bool canSee = GeometryUtility.TestPlanesAABB(planes, entryRenderer.bounds);

        if (spun || !canSee)
        {
            return;
        }


        cc.Move(Vector3.zero);
        // gpc.enabled = false;
        // cc.enabled = false;
        // gpi.enabled = false;


        // VELOCITY?
        // ONLY ROTATE THE CONCRETE?

        player.transform.SetParent(playerParent.transform);

        room.transform.Rotate(0, rotationAmount, 0);
        player.transform.Rotate(0, -rotationAmount, 0);

        player.transform.SetParent(null);


        // gpc.enabled = true;
        // cc.enabled = true;
        // gpi.enabled = true;


        spun = true;
    }
}
