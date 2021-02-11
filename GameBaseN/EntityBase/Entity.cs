using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameBaseN
{
    class Entity
    {

        private int uniqueId;       // unikt id för varje entitet.
        private int entityType;     // entitets typ.

        private bool isActive;      // true om den inte ska tas bort.

        private Entity nextEntity;  // en "pekare" till nästa entiteten i kedjan.


        public Entity()
        {
            UniqueId = 0;
            EntityType = 0;
            IsActive = true;
            NextEntity = null;
        }

        
        // public int EntityType { get => entityType; set => entityType = value; }
        public int EntityType
        {
            get
            {
                return entityType;
            }
            set
            {
                entityType = value;
            }
        }
        // public int UniqueId { get => uniqueId; set => uniqueId = value; }

        // public bool IsActive { get => isActive; set => isActive = value; }

        // public Entity NextEntity { get => nextEntity; set => nextEntity = value; }


        public virtual void Update(GameTime gameTime)
        {

        }
        
        public virtual void Draw(GameTime gameTime)
        {

        }

    }
}
