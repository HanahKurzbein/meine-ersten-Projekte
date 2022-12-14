// Laden der Webseite
window.onload = function ()
{
	// Zuordnung der Funktionen
	document.getElementById("deep-thought").onmouseout = onButtonOut;
	document.getElementById("deep-thought").onmouseover = onButtonOver;
}

// Funktion Deep-Thought-Picture
function onButtonOut()
{
	document.getElementById("deep-thought").src =
		"picture/deep-thought.png";
}

// Funktion Deep-Thought-Picture-42
function onButtonOver()
{
	document.getElementById("deep-thought").src =
		"picture/deep-thought-42.png";
}
