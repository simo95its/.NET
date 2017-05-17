using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class FieldForm : Form
    {
        public MineButton[,] Field { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int Mine { get; set; }
        public int FieldSize { get; set; }

        public FieldForm(int rows, int columns, int mine, int fieldSize)
        {
            InitializeComponent();
            Field = new MineButton[rows, columns];
            Rows = rows;
            Columns = columns;
            Mine = mine;
            FieldSize = FieldSize;
        }

        private void FieldForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FieldForm_Load(object sender, EventArgs e)
        {
            initializeField();
        }

        private void initializeField()
        {
            for (int r = 0; r < Rows; r++) //rows
            {
                for (int c = 0; c < Columns; c++) //columns
                {
                    Field[r, c] = new MineButton()
                    {
                        Width = FieldSize,
                        Height = FieldSize,
                        Left = FieldSize * c,
                        Top = FieldSize * r,
                    };
                    this.Controls.Add(Field[r, c]);
                }
            }
            randomMines();
        }

        private void randomMines()
        {
            Random rand = new Random();
            int r, c;
            for (int i = 0; i < Mine; i++)
            {
                do
                {
                    r = rand.Next(0, Field.GetLength(0));
                    c = rand.Next(0, Field.GetLength(1));
                } while (Field[r, c].State == Score.Mine);
                Field[r, c].State = Score.Mine;
            }
            countAllMines();
        }

        private void countAllMines()
        {
            for (int r = 0; r < Field.GetLength(0); r++)
            {
                for (int c = 0; c < Field.GetLength(1); c++)
                {
                    countMine(r, c);
                }
            }
        }

        private void countMine(int r, int c)
        {
            int n = 0;
            int k1 = 1;
            int k2 = 2;
            int k3 = 1;
            int k4 = 2;
            if (r < 1)
                k1--;
            else if (r > Field.GetLength(0) - 2)
                k2--;
            if (c < 1)
                k3--;
            else if (c > Field.GetLength(1) - 2)
                k4--;
            for (int i = r - k1; i < r + k2; i++)
            {
                for (int j = c - k3; j < c + k4; j++)
                {
                    if (Field[i, j].State == Score.Mine)
                        n++;
                }
            }
            if (Field[r, c].State != Score.Mine)
            {
                Field[r, c].State = adiacentMine(n);
            }
        }

        private Score adiacentMine(int n)
        {
            switch (n)
            {
                case 1:
                    return Score.One;
                case 2:
                    return Score.Two;
                case 3:
                    return Score.Three;
                case 4:
                    return Score.Four;
                case 5:
                    return Score.Five;
                case 6:
                    return Score.Six;
                case 7:
                    return Score.Seven;
                case 8:
                    return Score.Eight;
                default:
                    return Score.Empty;
            }
        }
    }
}
