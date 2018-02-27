// Fenix Ruler Screen 1.0
// © Ismael Heredia , Argentina , 2018
// Based in ruler by Jeff Key
// Thanks to Jeff Key

using System;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using System.IO;

namespace Ruler
{
    public class FormRuler : Form
    {
        // Variables

        private Rectangle rectangle;
        private int resize_border;
        private Point point;
        private Point mouse_point;
        private Position form_position;

        private enum Position
        {
            Unknown, North, South, East, West, Northeast, Southeast, Southwest, Northwest
        }

        // Form application

        public FormRuler()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.form_position = Position.Unknown;
            this.resize_border = 5;

            this.BackColor = Color.OrangeRed;
            this.Opacity = 0.30;
            this.Width = 400;
            this.Height = 75;
        }

        private static void Main(params string[] args)
        {
            if (File.Exists("options.zzz"))
            {
                File.Delete("options.zzz");
            }
            FormRuler form_ruler = new FormRuler();
            Application.Run(form_ruler);
        }

        // Mouse events

        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.form_position = Position.Unknown;
            base.OnMouseUp(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            int x = MousePosition.X - Location.X;
            int y = MousePosition.Y - Location.Y;
            this.point = new Point(x, y);
            this.mouse_point = MousePosition;
            this.rectangle = ClientRectangle;

            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (this.form_position == Position.Unknown)
            {
                Point position_cursor = PointToClient(MousePosition);

                Rectangle rectangle = ClientRectangle;

                rectangle.Inflate(-resize_border, -resize_border);

                bool is_resizable = ClientRectangle.Contains(position_cursor) && !rectangle.Contains(position_cursor);

                if (!is_resizable)
                {
                    Cursor = Cursors.Default;

                    if (e.Button == MouseButtons.Left)
                    {
                        int x = MousePosition.X - point.X;
                        int y = MousePosition.Y - point.Y;
                        Location = new Point(x, y);
                    }
                }
                else
                {
                    Position resizeRegion = this.get_resize_region(position_cursor);
                    this.resize_cursor(resizeRegion);

                    if (e.Button == MouseButtons.Left)
                    {
                        this.form_position = resizeRegion;
                        this.resize_it();
                    }
                }

                base.OnMouseMove(e);
            }
            else
            {
                this.resize_it();
            }
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            int width = this.Width;
            int height = this.Height;
            string dimensions = width + " x " + height;
            string result = dimensions + " px";
            if (write_file("Data/options.zzz", dimensions))
            {
                MessageBox.Show("Dimensions taked : " + result);
            }
            else
            {
                MessageBox.Show("Error taking dimensions");
            }
            Application.Exit();
        }

        // Get resize region

        private Position get_resize_region(Point mouse_position)
        {
            if (mouse_position.Y <= this.resize_border)
            {
                if (mouse_position.X <= this.resize_border)
                {
                    return Position.Northwest;
                }
                else if (mouse_position.X >= Width - this.resize_border)
                {
                    return Position.Northeast;
                }
                else
                {
                    return Position.North;
                }
            }
            else if (mouse_position.Y >= Height - this.resize_border)
            {
                if (mouse_position.X <= this.resize_border)
                {
                    return Position.Southwest;
                }
                else if (mouse_position.X >= Width - this.resize_border)
                {
                    return Position.Southeast;
                }
                else
                {
                    return Position.South;
                }
            }
            else
            {
                if (mouse_position.X <= this.resize_border)
                {
                    return Position.West;
                }
                else
                {
                    return Position.East;
                }
            }
        }

        // Resizes

        private void resize_it()
        {
            if (this.form_position == Position.East)
            {
                int x = MousePosition.X - this.mouse_point.X;
                Width = this.rectangle.Width + x;
            }
            else if (this.form_position == Position.South)
            {
                int y = MousePosition.Y - this.mouse_point.Y;
                Height = this.rectangle.Height + y;
            }
            else if (this.form_position == Position.Southeast)
            {
                int x = this.rectangle.Width + MousePosition.X;
                int y = this.rectangle.Height + MousePosition.Y;
                Width = x - this.mouse_point.X;
                Height = y - this.mouse_point.Y;
            }
        }

        private void resize_cursor(Position position)
        {
            if (position == Position.North || position == Position.South)
            {
                this.Cursor = Cursors.SizeNS;
            }
            else if (position == Position.East || position == Position.West)
            {
                this.Cursor = Cursors.SizeWE;
            }
            else if (position == Position.Northwest || position == Position.Southeast)
            {
                this.Cursor = Cursors.SizeNWSE;
            }
            else
            {
                this.Cursor = Cursors.SizeNESW;
            }
        }

        // Functions

        private bool write_file(string filename, string text)
        {
            try
            {
                var file = new StreamWriter(filename, true);
                file.WriteLine(text);
                file.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}