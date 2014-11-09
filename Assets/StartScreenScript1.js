var isQuit=false;

function OnMouseEnter()
{
	renderer.material.color = Color.red;
}

function OnMouseExit()
{
	renderer.material.color = Color.white;
}

function OnMouseUp()
{
	if (isQuit==true)
	{
		Application.Quit();
	}
	else
	{
		Application.LoadGame();
	}
}

function Update()
{
	if (Input.GetKey(KeyCode.Escape))
	{
		Application.Quit();
	}
}