using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Rowg5.Scenes.Factories
{

    public class SceneFactory
    {

        #region Fields

        private readonly GraphicsDeviceManager m_graphicsDeviceManager;
        private readonly SpriteBatch m_spriteBatch;

        #endregion // Fields



        #region Constructors

        public SceneFactory (GraphicsDeviceManager graphicsDeviceManager, SpriteBatch spriteBatch)
        {
            m_graphicsDeviceManager = graphicsDeviceManager;
            m_spriteBatch = spriteBatch;
        }

        #endregion // Constructors



        #region Public methods

        public Scene CreateScene (int sceneID)
        {
            Scene scene;

            switch (sceneID)
            {
                case 0:
                    scene = new MainScene(m_graphicsDeviceManager, m_spriteBatch);
                    break;
                default:
                    scene = new BlankScene(m_graphicsDeviceManager, m_spriteBatch);
                    break;
            }


            return scene;
        }

        #endregion // Public methods

    }

}
