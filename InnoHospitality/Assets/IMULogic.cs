using UnityEngine;

public class IMULogic : MonoBehaviour
{
    // icons
    public GameObject cameraHead;
    public GameObject lookupicon;
    public GameObject lookdownicon;
    public GameObject lookrighticon;
    public GameObject looklefticon;
    public GameObject tiltlefticon;
    public GameObject tiltrighticon;
    public AudioSource Music;

    // Flags to ensure music plays only once per icon
    private bool hasPlayedLookup = false;
    private bool hasPlayedLookdown = false;
    private bool hasPlayedLookright = false;
    private bool hasPlayedLookleft = false;
    private bool hasPlayedTiltleft = false;
    private bool hasPlayedTiltright = false;

    void Start()
    {
        lookupicon.SetActive(false);
        lookdownicon.SetActive(false);
        lookrighticon.SetActive(false);
        looklefticon.SetActive(false);
        tiltlefticon.SetActive(false);
        tiltrighticon.SetActive(false);
    }

    void Update()
    {
        float xRotation = cameraHead.transform.rotation.eulerAngles.x;
        float yRotation = cameraHead.transform.rotation.eulerAngles.y;
        float zRotation = cameraHead.transform.rotation.eulerAngles.z;

        // LOOK UP
        if (xRotation >= 300f && xRotation <= 320f)
        {
            lookupicon.SetActive(true);
            if (!hasPlayedLookup)
            {
                Music.Play();
                hasPlayedLookup = true;
            }
        }

        // LOOK DOWN
        else if (xRotation >= 60f && xRotation <= 75f)
        {
            lookdownicon.SetActive(true);
            if (!hasPlayedLookdown)
            {
                Music.Play();
                hasPlayedLookdown = true;
            }
        }

        // LOOK RIGHT
        else if (yRotation >= 100f && yRotation <= 110f)
        {
            lookrighticon.SetActive(true);
            if (!hasPlayedLookright)
            {
                Music.Play();
                hasPlayedLookright = true;
            }
        }

        // LOOK LEFT
        else if (yRotation >= 250f && yRotation <= 260f)
        {
            looklefticon.SetActive(true);
            if (!hasPlayedLookleft)
            {
                Music.Play();
                hasPlayedLookleft = true;
            }
        }

        

        // TILT LEFT
        else if (zRotation >= 70f && zRotation <= 80f)
        {
            tiltlefticon.SetActive(true);
            if (!hasPlayedTiltleft)
            {
                Music.Play();
                hasPlayedTiltleft = true;
            }
        }

        // TILT RIGHT
        else if (zRotation >= 270f && zRotation <= 300f)
        {
            tiltrighticon.SetActive(true);
            if (!hasPlayedTiltright)
            {
                Music.Play();
                hasPlayedTiltright = true;
            }
        }
    }
}
