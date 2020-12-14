using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russianbullet
{
   public class RBclass
    {
        //below code for shooting logic
        public int ShootingAwayChances = 2;  //2 chnaces for shooting away
        public int Bullet = 0;
        public int FireRemain = 4;
       

        public void LoadBullet()

        {  
         
            Bullet = 6;
        }

        public int SpinChamber()

        {
            //spining the chmaber
            Random rand = new Random();
            Bullet = rand.Next(1, 7); 
            return Bullet;
        }

        public int Fire()
        {
            

            if(Bullet == 1)
            {
                //code for message box
                MessageBox.Show("You are dead , do you want to play again?!");
                Application.Restart(); //how we play again using the code
            }
            else if(FireRemain > 1)
            {
                //code for message box
                MessageBox.Show("keep it up ");
                Bullet--;
                FireRemain--;
            }
            else
            {
                Bullet--;
                FireRemain--;
            }

            

            return FireRemain;
        }

        public int ShootingAway()
        {

            if (Bullet == 1)
            {
                //code for message box
                MessageBox.Show("You survived, do you want to play again?");
                Application.Restart();
            }
            else if (ShootingAwayChances > 1)
            {
                //code for message box
                MessageBox.Show("Keep it up");
                Bullet--;
                ShootingAwayChances--;
            }
            else
            {
                Bullet--;
                ShootingAwayChances--;
            }
            
            //return the bullet code
            return ShootingAwayChances;

        }
    }
}
