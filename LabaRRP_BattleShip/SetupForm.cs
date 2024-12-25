using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabaRRP_BattleShip
{
    public partial class SetupForm : Form
    {
        private Game _game;
        private int _shipLength = 4;
        private bool _isVertical = true;

        public SetupForm(Game game)
        {
            InitializeComponent();
            _game = game;
            InitializeGrid();
            InitializeControls();
        }

        private void InitializeGrid()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.Location = new Point(i * 30, j * 30);
                    btn.Tag = new Point(i, j);
                    btn.Click += Btn_Click;
                    pnlGrid.Controls.Add(btn);
                }
            }
        }

        private void InitializeControls()
        {
            ComboBox comboBoxShipSize = new ComboBox();
            comboBoxShipSize.Items.AddRange(new object[] { 1, 2, 3, 4 });
            comboBoxShipSize.SelectedIndex = 0;
            comboBoxShipSize.Location = new Point(320, 10);
            comboBoxShipSize.SelectedIndexChanged += (sender, e) =>
            {
                _shipLength = (int)comboBoxShipSize.SelectedItem;
            };
            this.Controls.Add(comboBoxShipSize);

            ComboBox comboBoxOrientation = new ComboBox();
            comboBoxOrientation.Items.AddRange(new object[] { "Горизонтально", "Вертикально" });
            comboBoxOrientation.SelectedIndex = 0;
            comboBoxOrientation.Location = new Point(320, 50);
            comboBoxOrientation.SelectedIndexChanged += (sender, e) =>
            {
                _isVertical = comboBoxOrientation.SelectedIndex == 1;
            };
            this.Controls.Add(comboBoxOrientation);

            Button btnDone = new Button();
            btnDone.Text = "Готово";
            btnDone.Location = new Point(320, 90);
            btnDone.Click += BtnDone_Click;
            this.Controls.Add(btnDone);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Point cell = (Point)btn.Tag;

            bool isPlaced = _game.Player1.PlaceShip(new Ship(_shipLength), cell.X, cell.Y, _isVertical);

            if (isPlaced)
            {
                btn.BackColor = Color.Blue;
            }
            else
            {
                MessageBox.Show("Невозможно разместить корабль на этой позиции.");
            }
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}