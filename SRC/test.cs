using Godot;
using System;

public class test : Node2D {

    private Label myLabel;


    public override void _Ready() {
        myLabel = GetNode<Label>("CanvasLayer/Control/Label");
    }

    public override void _Process(float delta){
        
        if (Input.IsActionJustPressed("leftclick")) { myLabel.Text = "Left Click"; }
        if (Input.IsActionJustPressed("rightclick")) { myLabel.Text = "Right Click"; }
        if (Input.IsActionJustPressed("middleclick")) { myLabel.Text = "Middle Click"; }

    }


    private void _on_Button_button_up() {
        myLabel.Text = "GUI Button pressed";
    }

    public override void _UnhandledInput(InputEvent @event) {
        if (@event is InputEventScreenTouch eventKey) {
            if (eventKey.Index == 0) { myLabel.Text = "TouchScreen Event index 0.  1 finger"; }
            if (eventKey.Index == 1) { myLabel.Text = "TouchScreen Event index 1.  2 fingers"; }
            if (eventKey.Index == 2) { myLabel.Text = "TouchScreen Event index 2.  3 fingers"; }
            if (eventKey.Index == 3) { myLabel.Text = "TouchScreen Event index 3.  4 fingers"; }
            if (eventKey.Index == 4) { myLabel.Text = "TouchScreen Event index 4.  5 fingers"; }

        }
                
    }



}
