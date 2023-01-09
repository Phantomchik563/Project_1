using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roguelite_for_project
{
    internal class Player : Entity
    {
        public int coins = 0;

        public Player(Form form) : base(form)
        {
            damage = 0;
            health = 5;
            
            sprite = new PictureBox();
            sprite.SizeMode = PictureBoxSizeMode.StretchImage;
            sprite.Size = new Size(sizeX, sizeY);

            sprite.BringToFront();
            sprite.Show();
            form.Controls.Add(sprite);
        }
        
        public void SetDirectionByKey(Keys key, bool value)
        {
            if (key == Keys.W || key == Keys.Up)
            {
                upDir = value;
            }
            else if (key == Keys.S || key == Keys.Down)
            {
                downDir = value;
            }
            else if (key == Keys.D || key == Keys.Right)
            {
                rigthDir = value;
            }
            else if (key == Keys.A || key == Keys.Left)
            {
                leftDir = value;
            }
        }
    }
}