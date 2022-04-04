//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.InputSystem;

//public class CameraMovement1 : MonoBehaviour
//{
//	private RTSControl cameraActions;
//	private InputAction movement;
//	private Transform cameraTransform;

//	[Tooltip("Horizontal Translation")]
//	[SerializeField]
//	private float _maxSpeed = 5f;
//	private float _speed;
//	[Tooltip("Horizontal Translation")]
//	[SerializeField]
//	private float _acceleration = 10f;
//	[Tooltip("Horizontal Translation")]
//	[SerializeField]
//	private float _damping = 15f;

//	[Tooltip("Vertical Translation")]
//	[SerializeField]
//	private float _stepSize = 2f;
//	[Tooltip("Vertical Translation")]
//	[SerializeField]
//	private float _zoomDampening = 7.5f;
//	[Tooltip("Vertical Translation")]
//	[SerializeField]
//	private float _minHeight = 5f;
//	[Tooltip("Vertical Translation")]
//	[SerializeField]
//	private float maxHeight = 50f;
//	[Tooltip("Vertical Translation")]
//	[SerializeField]
//	private float zoomSpeed = 2f;

//	[Tooltip("Rotation")]
//	[SerializeField]
//	private float maxRotationSpeed = 1f;

//	[Tooltip("Edge Movement")]
//	[SerializeField]
//	[Range(0f, 0.1f)]
//	private float edgeTolerance = 0.05f;

//	//value set in various functions 
//	//used to update the position of the camera base object.
//	private Vector3 targetPosition;

//	private float zoomHeight;

//	//used to track and maintain velocity w/o a rigidbody
//	private Vector3 horizontalVelocity;
//	private Vector3 lastPosition;

//	//tracks where the dragging action started
//	Vector3 startDrag;

//	private void Awake()
//	{
//		cameraActions = new RTSControl();
//		cameraTransform = this.GetComponentInChildren<Camera>().transform;
//	}

//	private void OnEnable()
//	{
//		zoomHeight = cameraTransform.localPosition.y;
//		cameraTransform.LookAt(this.transform);

//		lastPosition = this.transform.position;

//		movement = cameraActions.RTS.MoveCamera;
//		cameraActions.RTS.RotateCamera.performed += RotateCamera;
//		cameraActions.RTS.ZoomCamera.performed += ZoomCamera;
//		cameraActions.RTS.Enable();
//	}

//	private void OnDisable()
//	{
//		cameraActions.RTS.RotateCamera.performed -= RotateCamera;
//		cameraActions.RTS.ZoomCamera.performed -= ZoomCamera;
//		cameraActions.RTS.Disable();
//	}

//	private void Update()
//	{
//		//inputs
//		GetKeyboardMovement();
//		CheckMouseAtScreenEdge();
//		DragCamera();

//		//move base and camera objects
//		UpdateVelocity();
//		UpdateBasePosition();
//		UpdateCameraPosition();
//	}

//	private void UpdateVelocity()
//	{
//		horizontalVelocity = (this.transform.position - lastPosition) / Time.deltaTime;
//		horizontalVelocity.y = 0f;
//		lastPosition = this.transform.position;
//	}

//	private void GetKeyboardMovement()
//	{
//		Vector3 inputValue = movement.ReadValue<Vector2>().x * GetCameraRight()
//					+ movement.ReadValue<Vector2>().y * GetCameraForward();

//		inputValue = inputValue.normalized;

//		if (inputValue.sqrMagnitude > 0.1f)
//			targetPosition += inputValue;
//	}

//	private void DragCamera()
//	{
//		if (!Mouse.current.rightButton.isPressed)
//			return;

//		//create plane to raycast to
//		Plane plane = new Plane(Vector3.up, Vector3.zero);
//		Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());

//		if (plane.Raycast(ray, out float distance))
//		{
//			if (Mouse.current.rightButton.wasPressedThisFrame)
//				startDrag = ray.GetPoint(distance);
//			else
//				targetPosition += startDrag - ray.GetPoint(distance);
//		}
//	}

//	private void CheckMouseAtScreenEdge()
//	{
//		//mouse position is in pixels
//		Vector2 mousePosition = Mouse.current.position.ReadValue();
//		Vector3 moveDirection = Vector3.zero;

//		//horizontal scrolling
//		if (mousePosition.x < edgeTolerance * Screen.width)
//			moveDirection += -GetCameraRight();
//		else if (mousePosition.x > (1f - edgeTolerance) * Screen.width)
//			moveDirection += GetCameraRight();

//		//vertical scrolling
//		if (mousePosition.y < edgeTolerance * Screen.height)
//			moveDirection += -GetCameraForward();
//		else if (mousePosition.y > (1f - edgeTolerance) * Screen.height)
//			moveDirection += GetCameraForward();

//		targetPosition += moveDirection;
//	}

//	private void UpdateBasePosition()
//	{
//		if (targetPosition.sqrMagnitude > 0.1f)
//		{
//			//create a ramp up or acceleration
//			_speed = Mathf.Lerp(_speed, _maxSpeed, Time.deltaTime * _acceleration);
//			transform.position += targetPosition * _speed * Time.deltaTime;
//		}
//		else
//		{
//			//create smooth slow down
//			horizontalVelocity = Vector3.Lerp(horizontalVelocity, Vector3.zero, Time.deltaTime * _damping);
//			transform.position += horizontalVelocity * Time.deltaTime;
//		}

//		//reset for next frame
//		targetPosition = Vector3.zero;
//	}

//	private void ZoomCamera(InputAction.CallbackContext obj)
//	{
//		float inputValue = -obj.ReadValue<Vector2>().y / 100f;

//		if (Mathf.Abs(inputValue) > 0.1f)
//		{
//			zoomHeight = cameraTransform.localPosition.y + inputValue * _stepSize;

//			if (zoomHeight < _minHeight)
//				zoomHeight = _minHeight;
//			else if (zoomHeight > maxHeight)
//				zoomHeight = maxHeight;
//		}
//	}

//	private void UpdateCameraPosition()
//	{
//		//set zoom target
//		Vector3 zoomTarget = new Vector3(cameraTransform.localPosition.x, zoomHeight, cameraTransform.localPosition.z);
//		//add vector for forward/backward zoom
//		zoomTarget -= zoomSpeed * (zoomHeight - cameraTransform.localPosition.y) * Vector3.forward;

//		cameraTransform.localPosition = Vector3.Lerp(cameraTransform.localPosition, zoomTarget, Time.deltaTime * _zoomDampening);
//		cameraTransform.LookAt(this.transform);
//	}

//	private void RotateCamera(InputAction.CallbackContext obj)
//	{
//		if (!Mouse.current.middleButton.isPressed)
//			return;

//		float inputValue = obj.ReadValue<Vector2>().x;
//		transform.rotation = Quaternion.Euler(0f, inputValue * maxRotationSpeed + transform.rotation.eulerAngles.y, 0f);
//	}

//	//gets the horizontal forward vector of the camera
//	private Vector3 GetCameraForward()
//	{
//		Vector3 forward = cameraTransform.forward;
//		forward.y = 0f;
//		return forward;
//	}

//	//gets the horizontal right vector of the camera
//	private Vector3 GetCameraRight()
//	{
//		Vector3 right = cameraTransform.right;
//		right.y = 0f;
//		return right;
//	}
//}
