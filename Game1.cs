using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Rowg5.Scenes;
using Rowg5.Scenes.Factories;

namespace Rowg5
{

    public class Game1 : Game
    {

        #region Enums

        public enum EState { Init, Run }

        #endregion // Enums



        #region Fields

        private readonly GraphicsDeviceManager m_graphicsDeviceManager;
        private SpriteBatch m_spriteBatch = null;

        private EState m_state = EState.Init;

        private SceneFactory m_sceneFactory = null;
        private Scene m_scene = null;

        #endregion // Fields



        #region Constructors

        public Game1 ()
        {
            m_graphicsDeviceManager = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        #endregion // Constructors



        #region Game overrides

        protected override void Initialize ()
        {
            m_spriteBatch = new SpriteBatch(GraphicsDevice);
            m_sceneFactory = new SceneFactory(m_graphicsDeviceManager, m_spriteBatch);
            m_scene = m_sceneFactory.CreateScene(0);
            m_scene.OnEnter();

            base.Initialize();
        }

        protected override void LoadContent ()
        {

        }

        protected override void UnloadContent ()
        {
            m_scene.OnExit();
            m_spriteBatch.Dispose();
            m_graphicsDeviceManager.Dispose();
        }

        protected override void Update (GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            m_scene.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw (GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            m_scene.Draw(gameTime);

            base.Draw(gameTime);
        }

        #endregion // Game overrides

    }

}
