using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameBaseN
{
    static class EntityManager
    {

        static public Entity firstEntity;
        static public Entity lastEntity;
        static private int entityUniqueId;

        static public void Initialize()
        {
            firstEntity = null;
            lastEntity = null;
            entityUniqueId = 0;
        }


        static public void Update(GameTime gameTime)
        {
            Entity stepEntity = firstEntity;
            while(stepEntity != null)
            {
                if(stepEntity.isActive)
                {
                    stepEntity.Update(gameTime);
                }
                else
                {
                    RemoveEntityWithId(stepEntity.uniqueId);
                    
                }

                stepEntity = stepEntity.nextEntity;
            }


        }

        static public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            Entity stepEntity = firstEntity;
            while(stepEntity != null)
            {

                stepEntity.Draw(gameTime, spriteBatch);
                stepEntity = stepEntity.nextEntity;

            }

        }

        static public void AddEntity(Entity entityToAdd)
        {
            entityUniqueId++;
            entityToAdd.uniqueId = entityUniqueId;

            Entity stepEntity = firstEntity;
            
            if(firstEntity != null)
            {
                while(stepEntity.nextEntity != null)
                {
                    stepEntity = stepEntity.nextEntity;

                }

                stepEntity.nextEntity = entityToAdd;
                return;
            }
                firstEntity = entityToAdd;
        }

        static public Entity FindEntityWithId(int idToFind)
        {

            Entity stepEntity = firstEntity;

            while(stepEntity != null)
            {
                if(stepEntity.uniqueId == idToFind)
                {

                    return stepEntity;
                
                }

                stepEntity = stepEntity.nextEntity;
            }
            
            return null;
        }

        static public bool RemoveEntityWithId(int idToRemove)
        {
            Entity stepEntity;

            if(firstEntity != null)
            {
                if(firstEntity.uniqueId == idToRemove)
                {
                    firstEntity = firstEntity.nextEntity;
                    return true;
                
                }

                stepEntity = firstEntity;
                while(stepEntity?.nextEntity.uniqueId != idToRemove)
                {
                    stepEntity = stepEntity.nextEntity;
                
                }

                if(stepEntity?.nextEntity.uniqueId == idToRemove)
                {
                    stepEntity.nextEntity = stepEntity.nextEntity.nextEntity;
                    return true;
            
                }
            }

            return false;
        }

        static public void ClearAllEntities()
        {
            
            firstEntity = null;
            System.GC.Collect();

        }

    }
}
