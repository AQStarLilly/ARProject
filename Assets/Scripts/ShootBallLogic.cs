using UnityEngine;

public class ShootBallLogic : MonoBehaviour
{
    private Camera mainCam;

    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float ballForwardForce = 500f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCam = FindFirstObjectByType<Camera>();
        UIButtonHandler.OnUIShootButtonClicked += ShootBallOnButton;
    }

    private void ShootBallOnButton()
    {
        Vector3 spawnPosition = mainCam.transform.position + mainCam.transform.forward * 0.1f;
        Quaternion spawnRotation = mainCam.transform.rotation;

        GameObject spawnedBall = Instantiate(ballPrefab, spawnPosition, spawnRotation);
        Rigidbody rb = spawnedBall.GetComponent<Rigidbody>();

        if(rb != null)
        {
            rb.AddForce(mainCam.transform.forward * ballForwardForce);
        }

        Destroy(spawnedBall, 5f);
    }

}
