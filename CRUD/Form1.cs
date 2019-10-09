using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // обращаемя к этоу методу
            Panel_top();
            // button закрыть форму
            btn_close.Click += (s, e) => { Close(); };
            // переход в панель при нажатии на кнопку 
            switch_add.Click += (s, e) => { Panel(pnl_create); };
            // переход в панель изменение данных 
            switch_edit.Click += (s, e) => { Panel(pnl_edit); };
        }
        // метод переключения формы
        void Panel(Panel panel) { panel.BringToFront(); }
        // метод передвижения формы
        private void Panel_top()
        {
            int move = 0, moveX = 0, moveY = 0;
            Top_pnl.MouseDown += (s, e) => { move = 1; moveX = e.X; moveY = e.Y; };
            Top_pnl.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY); };
            Top_pnl.MouseUp += (s, e) => { move = 0; };
        }


    }
}
