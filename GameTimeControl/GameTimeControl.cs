using Microsoft.Xna.Framework;
using MonoGame.Forms.Controls;

namespace GameTimeControl
{
    public class GameTimeControl : MonoGameControl
    {
        //Fields & Properties Here!

        protected override void Initialize()
        {
            base.Initialize();

            //Content Here!
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            //Update Here!
        }

        protected override void Draw()
        {
            base.Draw();

            Editor.spriteBatch.Begin();

            //Draw Here!

            Editor.spriteBatch.End();
        }
    }
}
