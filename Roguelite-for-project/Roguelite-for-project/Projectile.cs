using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roguelite_for_project
{
    internal class Projectile : Entity
    {
        public Projectile(Form form) : base(form)
        {
            sprite = new PictureBox();
            sprite.SizeMode = PictureBoxSizeMode.StretchImage;
            sprite.Size = new Size(sizeX, sizeY);

            sprite.BringToFront();
            sprite.Show();
            form.Controls.Add(sprite);
        }
    }
}