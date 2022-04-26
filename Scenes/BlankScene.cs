﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Rowg5.Scenes
{

    public class BlankScene : Scene
    {

        #region Constructors

        public BlankScene (GraphicsDeviceManager graphicsDeviceManager, SpriteBatch spriteBatch) : base(graphicsDeviceManager, spriteBatch) { }

        #endregion // Constructors



        #region Public methods

        public override void OnEnter () { }

        public override void OnExit () { }

        public override void Update (GameTime gameTime) { }

        public override void Draw (GameTime gameTime) { }

        #endregion // Public methods

    }

}
