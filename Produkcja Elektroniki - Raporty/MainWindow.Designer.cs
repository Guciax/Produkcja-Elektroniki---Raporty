namespace Produkcja_Elektroniki___Raporty
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            this.tabControlMain = new Manina.Windows.Forms.TabControl();
            this.tab1 = new Manina.Windows.Forms.Tab();
            this.tab2 = new Manina.Windows.Forms.Tab();
            this.tab3 = new Manina.Windows.Forms.Tab();
            this.tabControlSecondary = new Manina.Windows.Forms.TabControl();
            this.tab6 = new Manina.Windows.Forms.Tab();
            this.olvViLastNg = new BrightIdeasSoftware.ObjectListView();
            this.tab7 = new Manina.Windows.Forms.Tab();
            this.panelPoziomOdpaduBackground = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clbViPoziomOdpaduSmtLines = new System.Windows.Forms.CheckedListBox();
            this.rbViPoziomOdpaduByLine = new System.Windows.Forms.RadioButton();
            this.rbViPoziomOdpaduCumulated = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpViPoziomOdpaduEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpViPoziomOdpaduStart = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cBViPoziomOdpaduMst = new System.Windows.Forms.CheckBox();
            this.cBViPoziomOdpaduLG = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbViPoziomOdpaduInterval = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tab8 = new Manina.Windows.Forms.Tab();
            this.tab9 = new Manina.Windows.Forms.Tab();
            this.tab4 = new Manina.Windows.Forms.Tab();
            this.tab5 = new Manina.Windows.Forms.Tab();
            this.checkBoxComboBox1 = new PresentationControls.CheckBoxComboBox();
            this.tabControlMain.SuspendLayout();
            this.tab3.SuspendLayout();
            this.tabControlSecondary.SuspendLayout();
            this.tab6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvViLastNg)).BeginInit();
            this.tab7.SuspendLayout();
            this.panelPoziomOdpaduBackground.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.ContentAlignment = Manina.Windows.Forms.Alignment.Center;
            this.tabControlMain.Controls.Add(this.tab1);
            this.tabControlMain.Controls.Add(this.tab2);
            this.tabControlMain.Controls.Add(this.tab3);
            this.tabControlMain.Controls.Add(this.tab4);
            this.tabControlMain.Controls.Add(this.tab5);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Size = new System.Drawing.Size(1248, 602);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.TabPadding = new System.Windows.Forms.Padding(5);
            this.tabControlMain.TabSize = new System.Drawing.Size(140, 23);
            this.tabControlMain.TabSizing = Manina.Windows.Forms.TabSizing.Fixed;
            // 
            // tab1
            // 
            this.tab1.Location = new System.Drawing.Point(1, 23);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(1246, 578);
            this.tab1.Text = "Zlecenie";
            // 
            // tab2
            // 
            this.tab2.Location = new System.Drawing.Point(1, 23);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(1246, 578);
            this.tab2.Text = "SMT";
            // 
            // tab3
            // 
            this.tab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tab3.Controls.Add(this.tabControlSecondary);
            this.tab3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tab3.Location = new System.Drawing.Point(1, 23);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(1246, 578);
            this.tab3.Text = "Kontrla wzrokowa";
            // 
            // tabControlSecondary
            // 
            this.tabControlSecondary.Controls.Add(this.tab6);
            this.tabControlSecondary.Controls.Add(this.tab7);
            this.tabControlSecondary.Controls.Add(this.tab8);
            this.tabControlSecondary.Controls.Add(this.tab9);
            this.tabControlSecondary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSecondary.Location = new System.Drawing.Point(0, 0);
            this.tabControlSecondary.Name = "tabControlSecondary";
            this.tabControlSecondary.Size = new System.Drawing.Size(1246, 578);
            this.tabControlSecondary.TabIndex = 0;
            this.tabControlSecondary.TabLocation = ((Manina.Windows.Forms.TabLocation)((Manina.Windows.Forms.TabLocation.Near | Manina.Windows.Forms.TabLocation.Left)));
            this.tabControlSecondary.TabSizing = Manina.Windows.Forms.TabSizing.Stretch;
            this.tabControlSecondary.TextDirection = Manina.Windows.Forms.TextDirection.Up;
            // 
            // tab6
            // 
            this.tab6.Controls.Add(this.olvViLastNg);
            this.tab6.Location = new System.Drawing.Point(25, 1);
            this.tab6.Name = "tab6";
            this.tab6.Size = new System.Drawing.Size(1220, 576);
            this.tab6.Text = "Ostatnie zlecenia";
            // 
            // olvViLastNg
            // 
            this.olvViLastNg.CellEditUseWholeCell = false;
            this.olvViLastNg.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvViLastNg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvViLastNg.Location = new System.Drawing.Point(0, 0);
            this.olvViLastNg.Name = "olvViLastNg";
            this.olvViLastNg.Size = new System.Drawing.Size(1220, 576);
            this.olvViLastNg.TabIndex = 1;
            this.olvViLastNg.UseCompatibleStateImageBehavior = false;
            this.olvViLastNg.View = System.Windows.Forms.View.Details;
            // 
            // tab7
            // 
            this.tab7.Controls.Add(this.panelPoziomOdpaduBackground);
            this.tab7.Location = new System.Drawing.Point(25, 1);
            this.tab7.Name = "tab7";
            this.tab7.Size = new System.Drawing.Size(1220, 576);
            this.tab7.Text = "Poziom odpadu";
            // 
            // panelPoziomOdpaduBackground
            // 
            this.panelPoziomOdpaduBackground.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelPoziomOdpaduBackground.Controls.Add(this.tableLayoutPanel1);
            this.panelPoziomOdpaduBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPoziomOdpaduBackground.Location = new System.Drawing.Point(0, 0);
            this.panelPoziomOdpaduBackground.Name = "panelPoziomOdpaduBackground";
            this.panelPoziomOdpaduBackground.Size = new System.Drawing.Size(1220, 576);
            this.panelPoziomOdpaduBackground.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 576F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1220, 576);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cartesianChart1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(200, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1020, 576);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.Color.White;
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(1, 61);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(1);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1018, 514);
            this.cartesianChart1.TabIndex = 1;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1020, 60);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.checkBoxComboBox1);
            this.panel3.Controls.Add(this.clbViPoziomOdpaduSmtLines);
            this.panel3.Controls.Add(this.rbViPoziomOdpaduByLine);
            this.panel3.Controls.Add(this.rbViPoziomOdpaduCumulated);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(409, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 58);
            this.panel3.TabIndex = 2;
            // 
            // clbViPoziomOdpaduSmtLines
            // 
            this.clbViPoziomOdpaduSmtLines.CheckOnClick = true;
            this.clbViPoziomOdpaduSmtLines.FormattingEnabled = true;
            this.clbViPoziomOdpaduSmtLines.Location = new System.Drawing.Point(138, 33);
            this.clbViPoziomOdpaduSmtLines.Name = "clbViPoziomOdpaduSmtLines";
            this.clbViPoziomOdpaduSmtLines.Size = new System.Drawing.Size(143, 202);
            this.clbViPoziomOdpaduSmtLines.TabIndex = 4;
            // 
            // rbViPoziomOdpaduByLine
            // 
            this.rbViPoziomOdpaduByLine.AutoSize = true;
            this.rbViPoziomOdpaduByLine.Location = new System.Drawing.Point(7, 20);
            this.rbViPoziomOdpaduByLine.Name = "rbViPoziomOdpaduByLine";
            this.rbViPoziomOdpaduByLine.Size = new System.Drawing.Size(67, 21);
            this.rbViPoziomOdpaduByLine.TabIndex = 3;
            this.rbViPoziomOdpaduByLine.Text = "Po linii";
            this.rbViPoziomOdpaduByLine.UseVisualStyleBackColor = true;
            this.rbViPoziomOdpaduByLine.CheckedChanged += new System.EventHandler(this.rbViPoziomOdpaduByLine_CheckedChanged);
            // 
            // rbViPoziomOdpaduCumulated
            // 
            this.rbViPoziomOdpaduCumulated.AutoSize = true;
            this.rbViPoziomOdpaduCumulated.Checked = true;
            this.rbViPoziomOdpaduCumulated.Location = new System.Drawing.Point(7, 36);
            this.rbViPoziomOdpaduCumulated.Name = "rbViPoziomOdpaduCumulated";
            this.rbViPoziomOdpaduCumulated.Size = new System.Drawing.Size(112, 21);
            this.rbViPoziomOdpaduCumulated.TabIndex = 2;
            this.rbViPoziomOdpaduCumulated.TabStop = true;
            this.rbViPoziomOdpaduCumulated.Text = "Skumulowany";
            this.rbViPoziomOdpaduCumulated.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Linie SMT:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpViPoziomOdpaduEnd);
            this.panel2.Controls.Add(this.dtpViPoziomOdpaduStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(103, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 58);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Od:";
            // 
            // dtpViPoziomOdpaduEnd
            // 
            this.dtpViPoziomOdpaduEnd.Location = new System.Drawing.Point(55, 33);
            this.dtpViPoziomOdpaduEnd.Name = "dtpViPoziomOdpaduEnd";
            this.dtpViPoziomOdpaduEnd.Size = new System.Drawing.Size(200, 23);
            this.dtpViPoziomOdpaduEnd.TabIndex = 1;
            // 
            // dtpViPoziomOdpaduStart
            // 
            this.dtpViPoziomOdpaduStart.Location = new System.Drawing.Point(56, 4);
            this.dtpViPoziomOdpaduStart.Name = "dtpViPoziomOdpaduStart";
            this.dtpViPoziomOdpaduStart.Size = new System.Drawing.Size(200, 23);
            this.dtpViPoziomOdpaduStart.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.cBViPoziomOdpaduMst);
            this.panel1.Controls.Add(this.cBViPoziomOdpaduLG);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 58);
            this.panel1.TabIndex = 0;
            // 
            // cBViPoziomOdpaduMst
            // 
            this.cBViPoziomOdpaduMst.AutoSize = true;
            this.cBViPoziomOdpaduMst.Checked = true;
            this.cBViPoziomOdpaduMst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBViPoziomOdpaduMst.Location = new System.Drawing.Point(14, 40);
            this.cBViPoziomOdpaduMst.Name = "cBViPoziomOdpaduMst";
            this.cBViPoziomOdpaduMst.Size = new System.Drawing.Size(56, 21);
            this.cBViPoziomOdpaduMst.TabIndex = 2;
            this.cBViPoziomOdpaduMst.Text = "MST";
            this.cBViPoziomOdpaduMst.UseVisualStyleBackColor = true;
            // 
            // cBViPoziomOdpaduLG
            // 
            this.cBViPoziomOdpaduLG.AutoSize = true;
            this.cBViPoziomOdpaduLG.Checked = true;
            this.cBViPoziomOdpaduLG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBViPoziomOdpaduLG.Location = new System.Drawing.Point(14, 21);
            this.cBViPoziomOdpaduLG.Name = "cBViPoziomOdpaduLG";
            this.cBViPoziomOdpaduLG.Size = new System.Drawing.Size(46, 21);
            this.cBViPoziomOdpaduLG.TabIndex = 1;
            this.cBViPoziomOdpaduLG.Text = "LG";
            this.cBViPoziomOdpaduLG.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produkcja:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.cbViPoziomOdpaduInterval);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(715, 1);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 58);
            this.panel4.TabIndex = 3;
            // 
            // cbViPoziomOdpaduInterval
            // 
            this.cbViPoziomOdpaduInterval.FormattingEnabled = true;
            this.cbViPoziomOdpaduInterval.Items.AddRange(new object[] {
            "Dziennie",
            "Tygodniowo",
            "Miesiecznie"});
            this.cbViPoziomOdpaduInterval.Location = new System.Drawing.Point(6, 22);
            this.cbViPoziomOdpaduInterval.Name = "cbViPoziomOdpaduInterval";
            this.cbViPoziomOdpaduInterval.Size = new System.Drawing.Size(155, 24);
            this.cbViPoziomOdpaduInterval.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Częstotliwość";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(198, 574);
            this.dataGridView1.TabIndex = 1;
            // 
            // tab8
            // 
            this.tab8.Location = new System.Drawing.Point(21, 1);
            this.tab8.Name = "tab8";
            this.tab8.Size = new System.Drawing.Size(1224, 576);
            this.tab8.Text = "Przyczyny odpadu";
            // 
            // tab9
            // 
            this.tab9.Location = new System.Drawing.Point(21, 1);
            this.tab9.Name = "tab9";
            this.tab9.Size = new System.Drawing.Size(1224, 576);
            this.tab9.Text = "tab9";
            // 
            // tab4
            // 
            this.tab4.Location = new System.Drawing.Point(1, 23);
            this.tab4.Name = "tab4";
            this.tab4.Size = new System.Drawing.Size(1246, 578);
            this.tab4.Text = "Test";
            // 
            // tab5
            // 
            this.tab5.Location = new System.Drawing.Point(1, 23);
            this.tab5.Name = "tab5";
            this.tab5.Size = new System.Drawing.Size(1246, 578);
            this.tab5.Text = "Pakowanie";
            // 
            // checkBoxComboBox1
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxComboBox1.CheckBoxProperties = checkBoxProperties1;
            this.checkBoxComboBox1.DisplayMemberSingleItem = "";
            this.checkBoxComboBox1.FormattingEnabled = true;
            this.checkBoxComboBox1.Location = new System.Drawing.Point(95, 6);
            this.checkBoxComboBox1.Name = "checkBoxComboBox1";
            this.checkBoxComboBox1.Size = new System.Drawing.Size(186, 24);
            this.checkBoxComboBox1.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 602);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tab3.ResumeLayout(false);
            this.tabControlSecondary.ResumeLayout(false);
            this.tab6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvViLastNg)).EndInit();
            this.tab7.ResumeLayout(false);
            this.panelPoziomOdpaduBackground.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Manina.Windows.Forms.TabControl tabControlMain;
        private Manina.Windows.Forms.Tab tab1;
        private Manina.Windows.Forms.Tab tab2;
        private Manina.Windows.Forms.Tab tab3;
        private Manina.Windows.Forms.TabControl tabControlSecondary;
        private Manina.Windows.Forms.Tab tab6;
        private Manina.Windows.Forms.Tab tab7;
        private Manina.Windows.Forms.Tab tab8;
        private Manina.Windows.Forms.Tab tab9;
        private Manina.Windows.Forms.Tab tab4;
        private Manina.Windows.Forms.Tab tab5;
        private BrightIdeasSoftware.ObjectListView olvViLastNg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbViPoziomOdpaduByLine;
        private System.Windows.Forms.RadioButton rbViPoziomOdpaduCumulated;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpViPoziomOdpaduEnd;
        private System.Windows.Forms.DateTimePicker dtpViPoziomOdpaduStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cBViPoziomOdpaduMst;
        private System.Windows.Forms.CheckBox cBViPoziomOdpaduLG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelPoziomOdpaduBackground;
        private System.Windows.Forms.CheckedListBox clbViPoziomOdpaduSmtLines;
        private System.Windows.Forms.ComboBox cbViPoziomOdpaduInterval;
        private PresentationControls.CheckBoxComboBox checkBoxComboBox1;
    }
}

