using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public class MineButton:Button
    {
        public Score State { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }

        public MineButton()
        {
            State = Score.Empty;
            Click += new EventHandler(Cell_Click);
        }

        public void Cell_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            switch ((int)State)
            {
                case 1:
                    path += ((int)Score.One).ToString();
                    break;
                case 2:
                    path += ((int)Score.Two).ToString();
                    break;
                case 3:
                    path += ((int)Score.Three).ToString();
                    break;
                case 4:
                    path += ((int)Score.Four).ToString();
                    break;
                case 5:
                    path += ((int)Score.Five).ToString();
                    break;
                case 6:
                    path += ((int)Score.Six).ToString();
                    break;
                case 7:
                    path += ((int)Score.Seven).ToString();
                    break;
                case 8:
                    path += ((int)Score.Eight).ToString();
                    break;
                case 9:
                    path += "bomba";
                    break;
                case 10:
                    break;
                default:
                    BackColor = Color.Aquamarine;
                    break;
            }
            if (State != Score.Empty && State != Score.Marked)
            {
                path += @".jpg";
                BackgroundImage = Image.FromFile(@"C:\Users\Simone\Source\Repos\.NET\MineSweeper\Minesweeper\Resources\" + path);
                BackgroundImageLayout = ImageLayout.Zoom;
                Enabled = false;
                State = Score.Marked;
            }
            else if (State == Score.Empty && State != Score.Marked)
            {
                //Form.Field.prova(Row, Column);
            }
        }
    }
}
