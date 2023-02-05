using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            int scoreCounts = 7;
            DockPanel[] scoreDockPenals = DisplayAdder.GenerateDockPanels(scoreCounts);
            StackPanel scoreStackPanel = ScoreStackPanel;

            for (int i = 0; i < scoreCounts; i++)
            {
                scoreStackPanel.Children.Add(scoreDockPenals[i]);
            }

            DisplayAdder.AddGuardLine(PlayCanvas);
            DisplayAdder.AddGameOverMessage(PlayCanvas);

        }



        private void AnswerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Random random = new Random();
                DisplayAdder.AddNumText(PlayCanvas, random.Next(0, 10), (double)random.Next(0, 450));
            }
        }
    }


    public static class DisplayAdder
    {
        public static DockPanel[] GenerateDockPanels(int count)
        {
            var panels = new DockPanel[count];

            for (int i = 0; i < count; i++)
            {
                panels[i] = new DockPanel
                {
                    Name = "scorePanel" + i,
                    Margin = new Thickness(20, 5, 20, 0),
                };

                TextBlock[] texts = new TextBlock[2];

                texts[0] = new TextBlock
                {
                    Name = "playerName" + i,
                    Text = "playerName" + i,
                    FontSize = 20,
                    HorizontalAlignment = HorizontalAlignment.Left,
                };

                texts[1] = new TextBlock
                {
                    Name = "score" + i,
                    Text = "0",
                    FontSize = 20,
                    HorizontalAlignment = HorizontalAlignment.Right,
                };

                panels[i].Children.Add(texts[0]);
                panels[i].Children.Add(texts[1]);

                texts[0].SetValue(DockPanel.DockProperty, Dock.Left);
                texts[1].SetValue(DockPanel.DockProperty, Dock.Right);
            }

            return panels;
        }

        public static void AddNumText(Canvas canvas, int number, double xPosition)
        {
            TextBlock newTextBlock = new TextBlock
            {
                Text = number.ToString(),
                FontSize = 20,
                FontWeight = FontWeights.Bold,
            };

            canvas.Children.Add(newTextBlock);
            newTextBlock.SetValue(Canvas.TopProperty, (double)1);
            newTextBlock.SetValue(Canvas.LeftProperty, xPosition);
        }

        public static void AddGuardLine(Canvas playCanvas)
        {
            Rectangle guardLine = new Rectangle
            {
                Height = 10,
                Width = 500,
                Fill = new SolidColorBrush(Colors.Red),
            };

            playCanvas.Children.Add(guardLine);
            guardLine.SetValue(Canvas.TopProperty, 350.0);
        }

        public static void AddGameOverMessage(Canvas playCanvas)
        {
            TextBlock newTextBlock = new TextBlock
            {
                Text = "Game Over",
                FontSize = 50,
                Foreground = new SolidColorBrush(Colors.Red),
                FontWeight = FontWeights.Bold,
            };

            playCanvas.Children.Add(newTextBlock);
            newTextBlock.SetValue(Canvas.TopProperty, 150.0);
            newTextBlock.SetValue(Canvas.LeftProperty, 130.0);
        }
    }
}
