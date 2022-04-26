using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Rowg5.Scenes
{

    public abstract class Scene
    {

        #region Fields

        protected readonly GraphicsDeviceManager m_graphicsDeviceManager;
        protected readonly SpriteBatch m_spriteBatch;

        #endregion // Fields



        #region Constructors

        public Scene (GraphicsDeviceManager graphicsDeviceManager, SpriteBatch spriteBatch)
        {
            m_graphicsDeviceManager = graphicsDeviceManager;
            m_spriteBatch = spriteBatch;
        }

        #endregion // Constructors



        #region Public methods

        public abstract void OnEnter ();

        public abstract void OnExit ();

        public abstract void Update (GameTime gameTime);

        public abstract void Draw (GameTime gameTime);

        #endregion // Public methods

    }

}
