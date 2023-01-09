using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roguelite_for_project
{
    internal class Entity
    {
        public bool upDir = false;
        public bool downDir = false;
        public bool leftDir = false;
        public bool rigthDir = false;

        public int speed = 5;
        public int sizeX = 50;
        public int sizeY = 50;

        public int damage = 1;
        public int armor = 0;
        public int health = 1;

        public PictureBox sprite;

        public virtual void Move()
        {
            if (upDir) sprite.Location = new Point
                    (sprite.Location.X, Math.Max(0, sprite.Location.Y - speed));

            if (downDir) sprite.Location = new Point
                    (sprite.Location.X, Math.Min(MainForm.ActiveForm.Size.Height - sizeY, sprite.Location.Y + speed));

            if (leftDir) sprite.Location = new Point
                    (Math.Max(0, sprite.Location.X - speed), sprite.Location.Y);

            if (rigthDir) sprite.Location = new Point
                    (Math.Min(MainForm.ActiveForm.Size.Width - sizeX, sprite.Location.X + speed), sprite.Location.Y);
        }

        public virtual void Shoot()
        {
            // Создать Projectile
        }

        public virtual void CheckCollision(List<Entity> entities)
        {
            foreach (Entity otherEntity in entities)
            {
                if (otherEntity.sizeX + sizeX >= Math.Abs(otherEntity.sprite.Location.X - sprite.Location.X) * 2 &&
                    otherEntity.sizeY + sizeY >= Math.Abs(otherEntity.sprite.Location.Y - sprite.Location.Y) * 2 &&
                    otherEntity != this)
                {
                    Collide(otherEntity);
                }
            }
        }

        public virtual void Collide(Entity entity)
        {
            health -= Math.Max(entity.damage - armor, 0);
            entity.health -= Math.Max(damage - entity.armor, 0);
        }

        public Entity(Form form)
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