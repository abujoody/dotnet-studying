using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tanks
{
    public partial class Controller_MainForm : Form
    {
        const int defSizeField = 260;
        const int defAmountTanks = 5;
        const int defAmountApples = 5;
        const int defSpeedGame = 40;

        View view;

        public Controller_MainForm() : this(defSizeField) {}
        public Controller_MainForm(int sizeField) : this(sizeField, defAmountTanks) {}
        public Controller_MainForm(int sizeField, int amountTanks) : this(sizeField, amountTanks, defAmountApples) {}
        public Controller_MainForm(int sizeField, int amountTanks, int amountApples) : this(sizeField, amountTanks, amountApples, defSpeedGame) {}
        public Controller_MainForm(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            InitializeComponent();

            view = new View();
            this.Controls.Add(view);
        }
    }
}
