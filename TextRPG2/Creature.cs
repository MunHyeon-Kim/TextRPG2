using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG2
{


    class Creature
    {
        protected int hp;
        protected int attack;

        CreatureType type;

        public enum CreatureType
        { 
            None,
            Player = 1,
            Monster = 2
        }


        protected Creature(CreatureType type) {
            this.type = type;
        }

       

        public void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

        public int GetHp()
        {
            return hp;
        }

        public int GetAttack()
        {
            return attack;
        }


        public void OnDamaged(int damage)
        {
            hp -= damage;
            if (hp < 0)
                hp = 0;
        }

        public bool IsDead()
        {
            if (hp == 0)
                return true;
            else
                return false;
        }

    }


    
}
