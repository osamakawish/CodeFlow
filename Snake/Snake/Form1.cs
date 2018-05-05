using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle Food = new Circle();
        
        public Form1()
        {
            InitializeComponent();

            // Set settins to default.
            new Settings();

            // Set game timer.
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            // Start new game.
            StartGame();
        }

        private void UpdateScreen()
        {
            // Check if game is over.
            if(Settings.GameOver == true)
            {
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
                else
                {
                    if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    {
                        Settings.direction = Direction.Right;
                    } else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    {
                        Settings.direction = Direction.Left;
                    } else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    {
                        Settings.direction = Direction.Down;
                    } else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down) 
                    {
                        Settings.direction = Direction.Up;
                    }

                    //MovePlayer();
                }

                pbCanvas.Invalidate();
            }
        }

        private void StartGame()
        {
            new Settings();

            // Initiate snake.
            Snake.Clear();
            Circle head = new Circle();
            head.X = 10; head.Y = 5;
            Snake.Add(head);

            scoreLabel.Text = Settings.Score.ToString();
            GenerateFood();

        }

        // Place random food.
        private void GenerateFood()
        {
            int Xmax = pbCanvas.Size.Width / Settings.Width;
            int Ymax = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            Food = new Circle();

            Food.X = random.Next(0, Xmax);
            Food.Y = random.Next(0, Ymax);
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (Settings.GameOver)
            {
                // Set snake colour.
                Brush snakeColour;
                
                // Draw Snake.
                for (int i=0; i<Snake.Count; i++)
                {
                    // Draw head.
                    if (i == 0) { snakeColour = Brushes.Red; } 
                    else { snakeColour = Brushes.OrangeRed; }

                    // Draw snake.
                    canvas.FillEllipse(snakeColour, new Rectangle(Snake[i].X * Settings.Width,
                                                                  Snake[i].Y * Settings.Height,
                                                                  Settings.Width,
                                                                  Settings.Height
                                                                  )
                                      );

                    // Draw food.


                }

                // 

            } else
            {

            }
        }
    }
}
