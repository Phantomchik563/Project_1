using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roguelite_for_project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();  
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            bool isGameOver = false;

            List<Entity> entities = new List<Entity>();
            Player player = new Player(this);
            player.sprite.Image = Properties.Resources.Бункер;

            while (isGameOver)
            {
                foreach (Entity entity in entities) entity.Move();

                foreach (Entity entity in entities) entity.CheckCollision(entities);

                // Костыль для удаления мобов
                List<int> numbersOfEntitiesToDelete = new List<int>();
                foreach (Entity entity in entities) if (entity.health <= 0) numbersOfEntitiesToDelete.Add(entities.IndexOf(entity));
                foreach (int number in numbersOfEntitiesToDelete) entities.RemoveAt(number);

                if(player.health <= 0) isGameOver = true;
            }
        }
    }
}