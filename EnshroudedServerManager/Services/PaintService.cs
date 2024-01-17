
namespace EnshroudedServerManager.Services
{
    public class PaintService
    {
        public void CustomBackgroundPainter(Form form, PaintEventArgs e, int linethickness = 2, Color linecolor = new Color(), int offsetborder = 6)
        {
            Rectangle rect = new Rectangle(offsetborder, offsetborder, form.ClientSize.Width - 1 - (offsetborder * 2), form.ClientSize.Height - 1 - (offsetborder * 2));

            Pen pen = new Pen(new Color());
            pen.Width = linethickness;
            if (linecolor != new Color())
            {
                pen.Color = linecolor;
            }
            else
            {
                pen.Color = Color.Black;
            }

            e.Graphics.DrawRectangle(pen, rect);
        }
    }
}
