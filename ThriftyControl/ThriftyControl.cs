using MonoGame.Forms.Controls;

namespace ThriftyControl
{
    public class ThriftyControl : InvalidationControl
    {
        //Fields & Properties Here!

        protected override void Initialize()
        {
            base.Initialize();

            //Content Here!
        }

        /// <summary>
        /// Call outside to update this control just one single time.
        /// For example in your Form1.cs class.
        /// Don't call this to fast - if you need a GameLoop you should use a MonoGameControl instead.
        /// </summary>
        public new void Update()
        {
            Invalidate();
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
