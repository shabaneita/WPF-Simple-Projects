using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for InkCanvas.xaml
    /// </summary>
    public partial class InkCanvas : Window
    {
        public InkCanvas()
        {
            InitializeComponent();
            DrawingAttributes drawingAttributes = new DrawingAttributes
            {
                Color = Colors.Red,
                Width = 2,
                Height = 2,
                StylusTip = StylusTip.Rectangle,
                //FitToCurve = true,
                IsHighlighter = false,
                IgnorePressure = true,

            };

        }

        //  System.Windows.Controls.InkCanvas
        private void RadioButtonColor_Checked(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString().ToLower())
            {
                case "red":
                    Ink.DefaultDrawingAttributes.Color = Colors.Red;
                    break;
                case "green":
                    Ink.DefaultDrawingAttributes.Color = Colors.Green;

                    break;
                case "blue":
                    Ink.DefaultDrawingAttributes.Color = Colors.Blue;

                    break;
                case "magenta":
                    Ink.DefaultDrawingAttributes.Color = Colors.Magenta;

                    break;


            }
        }

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromRgb((byte)slColorR.Value, (byte)slColorG.Value, (byte)slColorB.Value);
            Ink.DefaultDrawingAttributes.Color = new SolidColorBrush(color).Color;
            lblColor.Background= new SolidColorBrush(color);
        }


        private void RadioButtonMode_Checked(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString().ToLower())
            {
                case "ink":
                    Ink.EditingMode = InkCanvasEditingMode.Ink;
                    break;
                case "select":
                    Ink.EditingMode = InkCanvasEditingMode.Select;


                    break;
                case "erase":
                    Ink.EditingMode = InkCanvasEditingMode.EraseByPoint;


                    break;
                case "erase by stroke":
                    Ink.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;


            }

        }

        private void RadioButtonDshape_Checked(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString().ToLower())
            {
                //case "ellipse":
                //    Ink.

                    //Ink.StylusTip = ellipseStylus;
                    //break;
                //case "rectangle":
                //    Ink.EditingMode = InkCanvasEditingMode.Select;
                //    break;

            }
        }




        private void ChangeWeight(object sender, RoutedEventArgs e)
        {
            var drawingAttributes = Ink.DefaultDrawingAttributes;
            Double newSize = Math.Round(20.20, 0);
            drawingAttributes.Width = 10;
            drawingAttributes.Height = 10;

            switch ((sender as RadioButton).Content.ToString())
            {
                case "small":
                    drawingAttributes.Width = 10;
                    drawingAttributes.Height = 10;


                    break;
                case "medium":
                    drawingAttributes.Width = 15;
                    drawingAttributes.Height = 15;
                    break;
                case "large":
                    drawingAttributes.Width = 25;
                    drawingAttributes.Height = 25;
                    break;
            }
        }

        private void ChangeShape(object sender, RoutedEventArgs e)
        {
            var drawingAttributes = Ink.DefaultDrawingAttributes;

            switch ((sender as RadioButton).Content.ToString())
            {
                case "Rectangle":
                    drawingAttributes.StylusTip = System.Windows.Ink.StylusTip.Rectangle;
                    Ink.DefaultDrawingAttributes = drawingAttributes;
                    drawingAttributes.Width = 10;
                    drawingAttributes.Height = 10;

                    break;
                case "Ellipse":
                    drawingAttributes.StylusTip = System.Windows.Ink.StylusTip.Ellipse;
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ink.Strokes.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ink.CopySelection();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Ink.CutSelection();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Ink.Paste();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FileStream f = new FileStream("D:/canvas.ink", FileMode.Create, FileAccess.Write);
            Ink.Strokes.Save(f);
            f.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            FileStream r = new FileStream("D:/canvas.ink", FileMode.Open, FileAccess.Read);
            StrokeCollection strokes = new StrokeCollection(r);
            Ink.Strokes = strokes;
            r.Close();
        }
       
    }
}
