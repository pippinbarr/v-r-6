using UnityEngine;

public class DripFeedMan : MonoBehaviour
{
    public GameObject _baseMan;
    public GameObject _parent;
    public int maxDrops = 5;
    private int drops = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("DropMan", 2f, 2f);
    }

    void DropMan()
    {
        GameObject baseMan = (GameObject)Instantiate(_baseMan, _parent.transform);
        baseMan.transform.Rotate(90f, 0, 0);

        drops++;
        if (drops >= maxDrops)
        {
            CancelInvoke("DropMan");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
