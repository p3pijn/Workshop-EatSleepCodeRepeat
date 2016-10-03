using System.Collections.Generic;
using System.Drawing;
using Rectangle = eu.sig.training.ch05.boardpanel.v2.Rectangle;

namespace eu.sig.training.ch05.boardpanel.v3
{

    public class BoardPanel
    {
        /// <summary>
        /// Renders a single square on the given graphics context on the specified
        /// rectangle.
        /// <param name="square">The square to render.</param>
        /// <param name="g">The graphics context to draw on.</param>
        /// <param name="r">The position and dimension for rendering the square.</param>
        private void Render(Square square, Graphics g, Rectangle r)
        {
            square.Sprite.Draw(g, r);
            foreach (Unit unit in square.Occupants)
            {
                unit.Sprite.Draw(g, r);
            }
        }

        private class Sprite
        {
            public void Draw(Graphics g, Rectangle r)
            {

            }
        }

        private class Unit
        {
            public Sprite Sprite { get; set; }
        }

        private class Square : Unit
        {

            public IList<Unit> Occupants { get; set; }

        }
    }
}
