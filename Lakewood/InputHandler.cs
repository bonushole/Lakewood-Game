using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lakewood
{
    class InputHandler
    {
        Texture2D cursor;
        Vector2 cursorOffset;

        public InputHandler(ContentManager content) {

            cursor = content.Load<Texture2D>("cursor");
            cursorOffset = new Vector2(16, 16);

        }

        public void Update() {



        }
        public bool Interacting() {

            if (Mouse.GetState().LeftButton == ButtonState.Pressed || TouchPanel.GetState().Count > 0) {

                return true;
            }
            else {

                return false;

            }

        }
    }
}
