using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lakewood
{
    class TitleMenu : Scene
    {
        ContentManager content;
        SpriteFont font;
        Vector2 titlePos;
        Vector2 buttonPos;
        String titleText = "Lakewood Game(working title)";
        String buttonText = "Start Game";
        float titleScale = 2;

        Rectangle buttonRect;
        

        public TitleMenu(ContentManager content)
        {
            this.content = content;
        }

        public override void LoadContent(GameWindow window)
        {
            font = content.Load<SpriteFont>("spriteFont");

            titlePos = new Vector2(
                (window.ClientBounds.Size.X - titleScale * font.MeasureString(titleText).X) / 2,
                window.ClientBounds.Size.Y / 4
                );

            buttonPos = new Vector2(
                (window.ClientBounds.Size.X - font.MeasureString(buttonText).X) / 2,
                3 * window.ClientBounds.Size.Y / 4
                );

            buttonRect = new Rectangle(buttonPos.ToPoint(), font.MeasureString(buttonText).ToPoint());
            
        }

        public override void Update(GameTime gametime)
        {
            
        }

        public override void Draw(SpriteBatch spriteBatch, GameWindow window)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(font, titleText, titlePos, Color.Yellow, 0, Vector2.Zero, titleScale, SpriteEffects.None, 1);
            spriteBatch.DrawString(font, buttonText, buttonPos, Color.WhiteSmoke, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.End();
        }
    }
}

