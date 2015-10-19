using System.Drawing;

namespace QuadTrees.QTreeRect
{

    public class QuadTreeRectPointInvNode<T> : QuadTreeRectNode<T, PointF> where T : IRectQuadStorable
    {
        public QuadTreeRectPointInvNode(RectangleF rect) : base(rect)
        {
        }

        public QuadTreeRectPointInvNode(int x, int y, int width, int height) : base(x, y, width, height)
        {
        }

        internal QuadTreeRectPointInvNode(QuadTreeRectNode<T, PointF> parent, RectangleF rect)
            : base(parent, rect)
        {
        }
        protected override QuadTreeRectNode<T, PointF> CreateNode(RectangleF rectangleF)
        {
            return new QuadTreeRectPointInvNode<T>(this, rectangleF);
        }

        protected override bool CheckIntersects(PointF searchRect, T data)
        {
            return data.Rect.Contains(searchRect);
        }
        protected override bool QueryContains(PointF search, RectangleF rect)
        {
            return false;
        }

        protected override bool QueryIntersects(PointF search, RectangleF rect)
        {
            return rect.Contains(search);
        }
    }
}