﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sake_Snake
{
    class Snake
    {
        public int HorizontalVelocity { get; set; } = 0;
        public int VerticalVelocity { get; set; } = 0;
        public int Step { get; set; } = 20;

        public List<PictureBox> snakePixels = new List<PictureBox>();

        public Snake()
        {
            InitializeSnake();
        }

        private void InitializeSnake()
        {
            AddSnakePixel(300, 300);
            AddSnakePixel(300, 320);
            AddSnakePixel(300, 340);
        }

        private void AddSnakePixel(int left, int top)
        {
            PictureBox snakePixel;
            snakePixel = new PictureBox();
            snakePixel.Height = 20;
            snakePixel.Width = 20;
            snakePixel.BackColor = Color.Tomato;
            snakePixel.Left = left;
            snakePixel.Top = top;
            snakePixels.Add(snakePixel);
        }

        public void Render(Form form)
        {
            foreach(var sp in snakePixels)
            {
                form.Controls.Add(sp);
                sp.BringToFront();
            }
        }

        public void Move()
        {
            if (this.HorizontalVelocity == 0 && this.VerticalVelocity == 0)
            {
                return;
            }

            for(int i = snakePixels.Count -1; i > 0; i--)
            {
                snakePixels[i].Location = snakePixels[i - 1].Location;
            }

            snakePixels[0].Left += this.HorizontalVelocity * this.Step;
            snakePixels[0].Top += this.VerticalVelocity * this.Step;
        }
    }
}
