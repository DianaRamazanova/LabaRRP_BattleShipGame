using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabaRRP_BattleShip
{
    public partial class InstructionsForm : Form
    {
        public InstructionsForm()
        {
            InitializeComponent();
            this.Text = "Инструкция";
            Label instructionLabel = new Label();
            instructionLabel.Text = "1. Выберите размер корабля из выпадающего списка.\n" +
                                    "2. Выберите ориентацию корабля (горизонтально или вертикально).\n" +
                                    "3. Кликните на клетку на поле, чтобы разместить корабль.\n" +
                                    "4. После размещения всех кораблей нажмите 'Готово'.\n" +
                                    "5. Для выстрела кликните на клетку на поле противника.";
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new Point(10, 10);
            this.Controls.Add(instructionLabel);
        }
    }
}