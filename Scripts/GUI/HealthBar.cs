using Godot;
using System;

public class HealthBar : ProgressBar
{
    private Globals _globals;
    public override void _Ready()
    {
        _globals = GetNode("/root/Globals") as Globals;
    }

   public override void _Process(float delta)
   {
        Value = _globals.PlayerHealth;
   }
}
