using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turtle_play
{
    public partial class formTurtle : Form
    {
        public formTurtle()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Delay = 250;
            Nakov.TurtleGraphics.Turtle.PenSize = 5;
            
            Turtle.Rotate(30);
            Turtle.Forward(200);                     // triangles forming a cross with a line in the middle of each triangle
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show T";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide T";
            }
        }

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Delay = 250;
            Nakov.TurtleGraphics.Turtle.PenSize = 5;
            Nakov.TurtleGraphics.Turtle.PenColor = Color.DarkGreen;
            for (int i = 0; i <= 5; i++)
            {
                Turtle.Rotate(60);
                Turtle.Forward(120);                     // hexagon
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Delay = 250;
            Nakov.TurtleGraphics.Turtle.PenSize = 5;
            Nakov.TurtleGraphics.Turtle.PenColor = Color.PaleGreen;
            Turtle.Rotate(30);
            Turtle.Forward(200);                     // triangle
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
        }

        private void buttonStarFive_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Delay = 250;
            Nakov.TurtleGraphics.Turtle.PenSize = 5;
            Nakov.TurtleGraphics.Turtle.PenColor = Color.DarkRed;
            for (int i = 0; i < 5; i++)
            {
                Turtle.Rotate(144);                  // 5  star
                Turtle.Forward(180);
            }
        }

        private void buttonStarNine_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Delay = 250;
            Nakov.TurtleGraphics.Turtle.PenSize = 5;
            Nakov.TurtleGraphics.Turtle.PenColor = Color.LightSeaGreen;
            for (int i = 0; i < 9; i++)
            {
                Turtle.Forward(150);
                Turtle.Rotate(160);               // 9 star
            }
        }

        private void buttonSpiral_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Delay = 200;
            Nakov.TurtleGraphics.Turtle.PenSize = 3;
            Nakov.TurtleGraphics.Turtle.PenColor = Color.LightSteelBlue;
            int move = 3;
            for (int i = 1; i <= 30; i++)
            {
                Turtle.Forward(move += 3);              // spiral
                Turtle.Rotate(60);
            }
        }

        private void buttonDandelion_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Delay = 200;
            Nakov.TurtleGraphics.Turtle.PenSize = 3;
            Nakov.TurtleGraphics.Turtle.PenColor = Color.DarkCyan;
            for (int i = 1; i <= 36; i++)
            {
                Turtle.Forward(-100);
                Turtle.Rotate(10);                        // dandellion
                Turtle.Forward(100);
            }
        }

        private void buttonSun_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Delay = 200;
            Nakov.TurtleGraphics.Turtle.PenSize = 7;
            Nakov.TurtleGraphics.Turtle.PenColor = Color.DarkOrange;
            for (int i = 0; i <= 36; i++)
            {
                Turtle.Forward(200);                  // sun with 36
                Turtle.Rotate(170);
            }
        }

        private void buttonLinkedTriangles_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Delay = 200;
            Nakov.TurtleGraphics.Turtle.PenSize = 5;
            Nakov.TurtleGraphics.Turtle.PenColor = Color.PaleGoldenrod;
            int move = 180;
            for (int i = 0; i < 17; i++)
            {
                Turtle.Forward(move -= 10);       // linked triangles
                Turtle.Rotate(120);
            }
        }
    }
}
