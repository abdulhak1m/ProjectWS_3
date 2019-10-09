namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Top_pnl = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pnl_create = new System.Windows.Forms.Panel();
            this.pnl_edit = new System.Windows.Forms.Panel();
            this.switch_add = new System.Windows.Forms.Button();
            this.switch_edit = new System.Windows.Forms.Button();
            this.switch_deleted = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.Top_pnl.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.pnl_create.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top_pnl
            // 
            this.Top_pnl.BackColor = System.Drawing.Color.BlueViolet;
            this.Top_pnl.Controls.Add(this.btn_close);
            this.Top_pnl.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Top_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_pnl.Location = new System.Drawing.Point(0, 0);
            this.Top_pnl.Name = "Top_pnl";
            this.Top_pnl.Size = new System.Drawing.Size(1015, 25);
            this.Top_pnl.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(990, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Controls.Add(this.switch_deleted);
            this.pnl_menu.Controls.Add(this.switch_edit);
            this.pnl_menu.Controls.Add(this.switch_add);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 25);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(179, 515);
            this.pnl_menu.TabIndex = 1;
            // 
            // pnl_create
            // 
            this.pnl_create.Controls.Add(this.add);
            this.pnl_create.Controls.Add(this.cmb_status);
            this.pnl_create.Controls.Add(this.panel3);
            this.pnl_create.Controls.Add(this.panel2);
            this.pnl_create.Controls.Add(this.panel4);
            this.pnl_create.Controls.Add(this.panel1);
            this.pnl_create.Controls.Add(this.label3);
            this.pnl_create.Controls.Add(this.label2);
            this.pnl_create.Controls.Add(this.label4);
            this.pnl_create.Controls.Add(this.label1);
            this.pnl_create.Controls.Add(this.textBox3);
            this.pnl_create.Controls.Add(this.textBox2);
            this.pnl_create.Controls.Add(this.textBox1);
            this.pnl_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_create.Location = new System.Drawing.Point(179, 25);
            this.pnl_create.Name = "pnl_create";
            this.pnl_create.Size = new System.Drawing.Size(836, 515);
            this.pnl_create.TabIndex = 2;
            // 
            // pnl_edit
            // 
            this.pnl_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_edit.Location = new System.Drawing.Point(179, 25);
            this.pnl_edit.Name = "pnl_edit";
            this.pnl_edit.Size = new System.Drawing.Size(836, 515);
            this.pnl_edit.TabIndex = 0;
            // 
            // switch_add
            // 
            this.switch_add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switch_add.BackColor = System.Drawing.Color.BlueViolet;
            this.switch_add.FlatAppearance.BorderSize = 0;
            this.switch_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.switch_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switch_add.ForeColor = System.Drawing.Color.White;
            this.switch_add.Location = new System.Drawing.Point(22, 175);
            this.switch_add.Name = "switch_add";
            this.switch_add.Size = new System.Drawing.Size(130, 45);
            this.switch_add.TabIndex = 0;
            this.switch_add.Text = "добавить";
            this.switch_add.UseVisualStyleBackColor = false;
            // 
            // switch_edit
            // 
            this.switch_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switch_edit.BackColor = System.Drawing.Color.BlueViolet;
            this.switch_edit.FlatAppearance.BorderSize = 0;
            this.switch_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.switch_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switch_edit.ForeColor = System.Drawing.Color.White;
            this.switch_edit.Location = new System.Drawing.Point(22, 239);
            this.switch_edit.Name = "switch_edit";
            this.switch_edit.Size = new System.Drawing.Size(130, 45);
            this.switch_edit.TabIndex = 0;
            this.switch_edit.Text = "изменить";
            this.switch_edit.UseVisualStyleBackColor = false;
            // 
            // switch_deleted
            // 
            this.switch_deleted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switch_deleted.BackColor = System.Drawing.Color.BlueViolet;
            this.switch_deleted.FlatAppearance.BorderSize = 0;
            this.switch_deleted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.switch_deleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switch_deleted.ForeColor = System.Drawing.Color.White;
            this.switch_deleted.Location = new System.Drawing.Point(22, 303);
            this.switch_deleted.Name = "switch_deleted";
            this.switch_deleted.Size = new System.Drawing.Size(130, 45);
            this.switch_deleted.TabIndex = 0;
            this.switch_deleted.Text = "удаленное";
            this.switch_deleted.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(267, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 19);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Location = new System.Drawing.Point(267, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 5);
            this.panel1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(267, 262);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(307, 19);
            this.textBox2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Location = new System.Drawing.Point(267, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 5);
            this.panel2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(267, 334);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(307, 19);
            this.textBox3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Instagram:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlueViolet;
            this.panel3.Location = new System.Drawing.Point(267, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 5);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.BlueViolet;
            this.panel4.Location = new System.Drawing.Point(267, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 5);
            this.panel4.TabIndex = 2;
            // 
            // cmb_status
            // 
            this.cmb_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Доступен (-а)",
            "Не доступен ( -а)"});
            this.cmb_status.Location = new System.Drawing.Point(267, 111);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(307, 27);
            this.cmb_status.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Статус:";
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add.BackColor = System.Drawing.Color.BlueViolet;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(353, 380);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(130, 45);
            this.add.TabIndex = 0;
            this.add.Text = "добавить";
            this.add.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 540);
            this.Controls.Add(this.pnl_create);
            this.Controls.Add(this.pnl_edit);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.Top_pnl);
            this.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Top_pnl.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_create.ResumeLayout(false);
            this.pnl_create.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_pnl;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_create;
        private System.Windows.Forms.Panel pnl_edit;
        private System.Windows.Forms.Button switch_deleted;
        private System.Windows.Forms.Button switch_edit;
        private System.Windows.Forms.Button switch_add;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add;
    }
}

