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

    private Vector3 endPoint;
    private Quaternion endRotation;
    private bool endPointToSet = false;

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

        cc.enabled = false;

        player.transform.SetParent(playerParent.transform);

        room.transform.Rotate(0, rotationAmount, 0);
        player.transform.Rotate(0, -rotationAmount, 0);

        player.transform.SetParent(null);

        endPointToSet = true;

        endPoint = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        endRotation = player.transform.rotation;

        gpc.enabled = true;

        spun = true;
    }

    void FixedUpdate()
    {
        SetEndPoint();
    }

    void SetEndPoint()
    {
        if (endPointToSet)
        {
            player.transform.SetPositionAndRotation(endPoint, player.transform.rotation);

            endPointToSet = false;
            cc.enabled = true;
        }
    }
}
