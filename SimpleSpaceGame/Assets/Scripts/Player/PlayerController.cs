using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 6;
    [SerializeField] GameObject bulletPrefab;

    float horizontal, vertical;

    float xMin, xMax, yMin, yMax;
    Camera mainCamera;

    SpriteRenderer playerSprite;
    float maxMovementVerical = 0.9f;

    [SerializeField] float fireRate = 0.1f;


    private void Start()
    {
        playerSprite = GetComponentInChildren<SpriteRenderer>();
        SetUpMoveBoundries();
       
      
    }


    private void Update()
    {
        //player movement (only horizontal for now)
        //Vector3 moveDirection = Vector3.right * horizontal;
        //transform.position += moveDirection * moveSpeed * Time.deltaTime;

        //beginning of the vertical movement (probably not what we want)
        //Vector3 moveDirection = Vector2.up * Mathf.Clamp(vertical,xMin,xMax) + Vector2.right * Mathf.Clamp(horizontal, xMin, xMax);

        float deltaX = horizontal * Time.deltaTime * moveSpeed;
        float deltaY = vertical * Time.deltaTime * moveSpeed;

        Vector3 moveDirection = new Vector3 (Mathf.Clamp(transform.position.x + deltaX, xMin, xMax), Mathf.Clamp(transform.position.y + deltaY, yMin, yMax));
        transform.position = moveDirection;

        

    }

    private void SetUpMoveBoundries()
    {
        mainCamera = Camera.main;
        //xMin = mainCamera.ViewportToWorldPoint(new Vector3 (0, 0, 0)).x;
        //xMax = mainCamera.ViewportToWorldPoint(new Vector3 (1, 0, 0)).x;
        //yMin = mainCamera.ViewportToWorldPoint(new Vector3 (0, 0, 0)).y;
        //yMax = mainCamera.ViewportToWorldPoint(new Vector3 (0, 1, 0)).y;

        xMin = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + playerSprite.bounds.extents.x;
        xMax = mainCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - playerSprite.bounds.extents.x;
        yMin = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + playerSprite.bounds.extents.y;
        yMax = mainCamera.ViewportToWorldPoint(new Vector3(0, maxMovementVerical, 0)).y;

    }

    //Called as Unity event fire in (GameManager object)
    public void onMoveInput(float horizontal, float vertical)
    {

        this.horizontal = horizontal;
        this.vertical = vertical;
        //Debug.Log($"Player Controller: Move Input : {horizontal} and {vertical}");
    }

    public void onShootInput()
    {
        StartCoroutine("shootingContinuously");
        //GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;


    }

    public void onStopShooting()
    {
        //GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;

        StopCoroutine("shootingContinuously");
    }
    IEnumerator shootingContinuously()
    {

        while (true)
        {
           
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
            yield return new WaitForSeconds(fireRate);
        }
    }


}
