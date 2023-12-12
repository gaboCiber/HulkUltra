using Godot;
using System;
using System.Text;

public partial class main : Control
{
	StringBuilder history;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.GetChild<LineEdit>(1).TextSubmitted += LineTextSubmitted; 
		history = new StringBuilder();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void LineTextSubmitted(string newText)
	{
		if(this.GetChild<TextEdit>(0).Text != string.Empty)
		{
			for (int i = 0; i < 210; i++)
			{
				history.Append("-");
			}

			history.Append("\n");
		}

		
		history.Append(newText + "\n");
		history.Append("`the output`" + "\n"); //EvaluateCode(newText) + "\n";
		
		this.GetChild<TextEdit>(0).Editable = true;
		this.GetChild<TextEdit>(0).Text = history.ToString();
		this.GetChild<TextEdit>(0).Editable = false;
		this.GetChild<LineEdit>(1).Text = string.Empty;
	}

	public string EvaluateCode(string newText)
	{
		throw new NotImplementedException();
	}
}
