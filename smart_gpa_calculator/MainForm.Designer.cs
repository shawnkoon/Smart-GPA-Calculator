namespace smart_gpa_calculator
{
    partial class mainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerBase = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.courseNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.numCreditsUpDown = new System.Windows.Forms.NumericUpDown();
            this.numCreditsLabel = new System.Windows.Forms.Label();
            this.addClassButton = new System.Windows.Forms.Button();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.courseNumLabel = new System.Windows.Forms.Label();
            this.deptLabel = new System.Windows.Forms.Label();
            this.courseIdLabel = new System.Windows.Forms.Label();
            this.deptTextBox = new System.Windows.Forms.TextBox();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.termSeasonComboBox = new System.Windows.Forms.ComboBox();
            this.termLabel = new System.Windows.Forms.Label();
            this.calculatorTitleLabel = new System.Windows.Forms.Label();
            this.gpaTitleLabel = new System.Windows.Forms.Label();
            this.smartTitleLabel = new System.Windows.Forms.Label();
            this.graphExplanationLabel = new System.Windows.Forms.Label();
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.overallPointsLabel = new System.Windows.Forms.Label();
            this.currentPointsLabel = new System.Windows.Forms.Label();
            this.lastPointsLabel = new System.Windows.Forms.Label();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.overallGpaLabel = new System.Windows.Forms.Label();
            this.overallCreditLabel = new System.Windows.Forms.Label();
            this.overallLabel = new System.Windows.Forms.Label();
            this.currentGpaLabel = new System.Windows.Forms.Label();
            this.currentCreditsLabel = new System.Windows.Forms.Label();
            this.minorLabel = new System.Windows.Forms.Label();
            this.lastGpaLabel = new System.Windows.Forms.Label();
            this.lastCreditsLabel = new System.Windows.Forms.Label();
            this.majorLabel = new System.Windows.Forms.Label();
            this.cumulativeLabel = new System.Windows.Forms.Label();
            this.coursesTextBox = new System.Windows.Forms.TextBox();
            this.gradeUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBase)).BeginInit();
            this.splitContainerBase.Panel1.SuspendLayout();
            this.splitContainerBase.Panel2.SuspendLayout();
            this.splitContainerBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCreditsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.LemonChiffon;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(898, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToToolStripMenuItem,
            this.creditToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.howToToolStripMenuItem.Text = "How to";
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.creditToolStripMenuItem.Text = "Credit";
            // 
            // splitContainerBase
            // 
            this.splitContainerBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBase.Location = new System.Drawing.Point(0, 24);
            this.splitContainerBase.Name = "splitContainerBase";
            // 
            // splitContainerBase.Panel1
            // 
            this.splitContainerBase.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerBase.Panel1.Controls.Add(this.splitContainerLeft);
            // 
            // splitContainerBase.Panel2
            // 
            this.splitContainerBase.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerBase.Panel2.Controls.Add(this.splitContainerRight);
            this.splitContainerBase.Size = new System.Drawing.Size(898, 567);
            this.splitContainerBase.SplitterDistance = 512;
            this.splitContainerBase.TabIndex = 7;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.BackColor = System.Drawing.Color.LightYellow;
            this.splitContainerLeft.Panel1.Controls.Add(this.gradeUpDown);
            this.splitContainerLeft.Panel1.Controls.Add(this.courseNumUpDown);
            this.splitContainerLeft.Panel1.Controls.Add(this.numCreditsUpDown);
            this.splitContainerLeft.Panel1.Controls.Add(this.numCreditsLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.addClassButton);
            this.splitContainerLeft.Panel1.Controls.Add(this.gradeLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.courseNameTextBox);
            this.splitContainerLeft.Panel1.Controls.Add(this.courseNameLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.courseNumLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.deptLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.courseIdLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.deptTextBox);
            this.splitContainerLeft.Panel1.Controls.Add(this.yearUpDown);
            this.splitContainerLeft.Panel1.Controls.Add(this.termSeasonComboBox);
            this.splitContainerLeft.Panel1.Controls.Add(this.termLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.calculatorTitleLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.gpaTitleLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.smartTitleLabel);
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainerLeft.Panel2.Controls.Add(this.graphExplanationLabel);
            this.splitContainerLeft.Size = new System.Drawing.Size(512, 567);
            this.splitContainerLeft.SplitterDistance = 355;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // courseNumUpDown
            // 
            this.courseNumUpDown.Location = new System.Drawing.Point(246, 146);
            this.courseNumUpDown.Maximum = new decimal(new int[] {
            699,
            0,
            0,
            0});
            this.courseNumUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.courseNumUpDown.Name = "courseNumUpDown";
            this.courseNumUpDown.Size = new System.Drawing.Size(50, 20);
            this.courseNumUpDown.TabIndex = 3;
            this.courseNumUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numCreditsUpDown
            // 
            this.numCreditsUpDown.DecimalPlaces = 1;
            this.numCreditsUpDown.Location = new System.Drawing.Point(202, 226);
            this.numCreditsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCreditsUpDown.Name = "numCreditsUpDown";
            this.numCreditsUpDown.Size = new System.Drawing.Size(46, 20);
            this.numCreditsUpDown.TabIndex = 5;
            this.numCreditsUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numCreditsLabel
            // 
            this.numCreditsLabel.AutoSize = true;
            this.numCreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCreditsLabel.Location = new System.Drawing.Point(15, 227);
            this.numCreditsLabel.Name = "numCreditsLabel";
            this.numCreditsLabel.Size = new System.Drawing.Size(180, 16);
            this.numCreditsLabel.TabIndex = 16;
            this.numCreditsLabel.Text = "Number of Credits for course:";
            // 
            // addClassButton
            // 
            this.addClassButton.Location = new System.Drawing.Point(221, 313);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(75, 23);
            this.addClassButton.TabIndex = 7;
            this.addClassButton.Text = "Add Class";
            this.addClassButton.UseVisualStyleBackColor = true;
            this.addClassButton.Click += new System.EventHandler(this.addClassButton_Click);
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.Location = new System.Drawing.Point(15, 263);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(83, 16);
            this.gradeLabel.TabIndex = 17;
            this.gradeLabel.Text = "Enter Grade:";
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(164, 189);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.courseNameTextBox.TabIndex = 4;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.Location = new System.Drawing.Point(15, 190);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(149, 16);
            this.courseNameLabel.TabIndex = 15;
            this.courseNameLabel.Text = "Enter the Course Name:";
            // 
            // courseNumLabel
            // 
            this.courseNumLabel.AutoSize = true;
            this.courseNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNumLabel.Location = new System.Drawing.Point(244, 169);
            this.courseNumLabel.Name = "courseNumLabel";
            this.courseNumLabel.Size = new System.Drawing.Size(40, 9);
            this.courseNumLabel.TabIndex = 14;
            this.courseNumLabel.Text = "NUMBER";
            // 
            // deptLabel
            // 
            this.deptLabel.AutoSize = true;
            this.deptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptLabel.Location = new System.Drawing.Point(181, 169);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(26, 9);
            this.deptLabel.TabIndex = 13;
            this.deptLabel.Text = "DEPT";
            // 
            // courseIdLabel
            // 
            this.courseIdLabel.AutoSize = true;
            this.courseIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdLabel.Location = new System.Drawing.Point(15, 150);
            this.courseIdLabel.Name = "courseIdLabel";
            this.courseIdLabel.Size = new System.Drawing.Size(162, 16);
            this.courseIdLabel.TabIndex = 12;
            this.courseIdLabel.Text = "Enter the Course Identifier:";
            // 
            // deptTextBox
            // 
            this.deptTextBox.Location = new System.Drawing.Point(183, 146);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.Size = new System.Drawing.Size(46, 20);
            this.deptTextBox.TabIndex = 2;
            // 
            // yearUpDown
            // 
            this.yearUpDown.Location = new System.Drawing.Point(315, 111);
            this.yearUpDown.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.yearUpDown.Minimum = new decimal(new int[] {
            1930,
            0,
            0,
            0});
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.Size = new System.Drawing.Size(61, 20);
            this.yearUpDown.TabIndex = 1;
            this.yearUpDown.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // termSeasonComboBox
            // 
            this.termSeasonComboBox.FormattingEnabled = true;
            this.termSeasonComboBox.Items.AddRange(new object[] {
            "Fall",
            "Winter",
            "Spring",
            "Summer"});
            this.termSeasonComboBox.Location = new System.Drawing.Point(219, 110);
            this.termSeasonComboBox.Name = "termSeasonComboBox";
            this.termSeasonComboBox.Size = new System.Drawing.Size(88, 21);
            this.termSeasonComboBox.TabIndex = 0;
            this.termSeasonComboBox.Text = "Term";
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termLabel.Location = new System.Drawing.Point(15, 111);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(198, 16);
            this.termLabel.TabIndex = 11;
            this.termLabel.Text = "Which Term will this class be in?";
            // 
            // calculatorTitleLabel
            // 
            this.calculatorTitleLabel.AutoSize = true;
            this.calculatorTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorTitleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.calculatorTitleLabel.Location = new System.Drawing.Point(270, 10);
            this.calculatorTitleLabel.Name = "calculatorTitleLabel";
            this.calculatorTitleLabel.Size = new System.Drawing.Size(189, 49);
            this.calculatorTitleLabel.TabIndex = 10;
            this.calculatorTitleLabel.Text = "Calculator";
            // 
            // gpaTitleLabel
            // 
            this.gpaTitleLabel.AutoSize = true;
            this.gpaTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaTitleLabel.ForeColor = System.Drawing.Color.LightCoral;
            this.gpaTitleLabel.Location = new System.Drawing.Point(182, 10);
            this.gpaTitleLabel.Name = "gpaTitleLabel";
            this.gpaTitleLabel.Size = new System.Drawing.Size(91, 49);
            this.gpaTitleLabel.TabIndex = 9;
            this.gpaTitleLabel.Text = "GPA";
            // 
            // smartTitleLabel
            // 
            this.smartTitleLabel.AutoSize = true;
            this.smartTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTitleLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.smartTitleLabel.Location = new System.Drawing.Point(56, 10);
            this.smartTitleLabel.Name = "smartTitleLabel";
            this.smartTitleLabel.Size = new System.Drawing.Size(125, 49);
            this.smartTitleLabel.TabIndex = 8;
            this.smartTitleLabel.Text = "Smart";
            // 
            // graphExplanationLabel
            // 
            this.graphExplanationLabel.AutoSize = true;
            this.graphExplanationLabel.Location = new System.Drawing.Point(140, 37);
            this.graphExplanationLabel.Name = "graphExplanationLabel";
            this.graphExplanationLabel.Size = new System.Drawing.Size(209, 13);
            this.graphExplanationLabel.TabIndex = 0;
            this.graphExplanationLabel.Text = "Graph of Grade trends (by Term) goes here";
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainerRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRight.Name = "splitContainerRight";
            this.splitContainerRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.BackColor = System.Drawing.Color.MistyRose;
            this.splitContainerRight.Panel1.Controls.Add(this.overallPointsLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.currentPointsLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.lastPointsLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.gpaLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.pointsLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.creditsLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.overallGpaLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.overallCreditLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.overallLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.currentGpaLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.currentCreditsLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.minorLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.lastGpaLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.lastCreditsLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.majorLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.cumulativeLabel);
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.BackColor = System.Drawing.Color.Ivory;
            this.splitContainerRight.Panel2.Controls.Add(this.coursesTextBox);
            this.splitContainerRight.Size = new System.Drawing.Size(382, 567);
            this.splitContainerRight.SplitterDistance = 186;
            this.splitContainerRight.TabIndex = 0;
            // 
            // overallPointsLabel
            // 
            this.overallPointsLabel.AutoSize = true;
            this.overallPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallPointsLabel.Location = new System.Drawing.Point(249, 142);
            this.overallPointsLabel.Name = "overallPointsLabel";
            this.overallPointsLabel.Size = new System.Drawing.Size(15, 16);
            this.overallPointsLabel.TabIndex = 15;
            this.overallPointsLabel.Text = "0";
            // 
            // currentPointsLabel
            // 
            this.currentPointsLabel.AutoSize = true;
            this.currentPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPointsLabel.Location = new System.Drawing.Point(249, 115);
            this.currentPointsLabel.Name = "currentPointsLabel";
            this.currentPointsLabel.Size = new System.Drawing.Size(15, 16);
            this.currentPointsLabel.TabIndex = 14;
            this.currentPointsLabel.Text = "0";
            // 
            // lastPointsLabel
            // 
            this.lastPointsLabel.AutoSize = true;
            this.lastPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPointsLabel.Location = new System.Drawing.Point(249, 84);
            this.lastPointsLabel.Name = "lastPointsLabel";
            this.lastPointsLabel.Size = new System.Drawing.Size(15, 16);
            this.lastPointsLabel.TabIndex = 13;
            this.lastPointsLabel.Text = "0";
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(302, 59);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(29, 13);
            this.gpaLabel.TabIndex = 12;
            this.gpaLabel.Text = "GPA";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(228, 59);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(36, 13);
            this.pointsLabel.TabIndex = 11;
            this.pointsLabel.Text = "Points";
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Location = new System.Drawing.Point(156, 59);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(39, 13);
            this.creditsLabel.TabIndex = 10;
            this.creditsLabel.Text = "Credits";
            // 
            // overallGpaLabel
            // 
            this.overallGpaLabel.AutoSize = true;
            this.overallGpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallGpaLabel.Location = new System.Drawing.Point(306, 142);
            this.overallGpaLabel.Name = "overallGpaLabel";
            this.overallGpaLabel.Size = new System.Drawing.Size(25, 16);
            this.overallGpaLabel.TabIndex = 9;
            this.overallGpaLabel.Text = "0.0";
            // 
            // overallCreditLabel
            // 
            this.overallCreditLabel.AutoSize = true;
            this.overallCreditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallCreditLabel.Location = new System.Drawing.Point(176, 142);
            this.overallCreditLabel.Name = "overallCreditLabel";
            this.overallCreditLabel.Size = new System.Drawing.Size(15, 16);
            this.overallCreditLabel.TabIndex = 8;
            this.overallCreditLabel.Text = "0";
            // 
            // overallLabel
            // 
            this.overallLabel.AutoSize = true;
            this.overallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallLabel.Location = new System.Drawing.Point(67, 142);
            this.overallLabel.Name = "overallLabel";
            this.overallLabel.Size = new System.Drawing.Size(51, 16);
            this.overallLabel.TabIndex = 7;
            this.overallLabel.Text = "Overall";
            // 
            // currentGpaLabel
            // 
            this.currentGpaLabel.AutoSize = true;
            this.currentGpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentGpaLabel.Location = new System.Drawing.Point(306, 114);
            this.currentGpaLabel.Name = "currentGpaLabel";
            this.currentGpaLabel.Size = new System.Drawing.Size(25, 16);
            this.currentGpaLabel.TabIndex = 6;
            this.currentGpaLabel.Text = "0.0";
            // 
            // currentCreditsLabel
            // 
            this.currentCreditsLabel.AutoSize = true;
            this.currentCreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCreditsLabel.Location = new System.Drawing.Point(176, 114);
            this.currentCreditsLabel.Name = "currentCreditsLabel";
            this.currentCreditsLabel.Size = new System.Drawing.Size(15, 16);
            this.currentCreditsLabel.TabIndex = 5;
            this.currentCreditsLabel.Text = "0";
            // 
            // minorLabel
            // 
            this.minorLabel.AutoSize = true;
            this.minorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minorLabel.Location = new System.Drawing.Point(66, 114);
            this.minorLabel.Name = "minorLabel";
            this.minorLabel.Size = new System.Drawing.Size(85, 16);
            this.minorLabel.TabIndex = 4;
            this.minorLabel.Text = "Current Term";
            // 
            // lastGpaLabel
            // 
            this.lastGpaLabel.AutoSize = true;
            this.lastGpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastGpaLabel.Location = new System.Drawing.Point(306, 84);
            this.lastGpaLabel.Name = "lastGpaLabel";
            this.lastGpaLabel.Size = new System.Drawing.Size(25, 16);
            this.lastGpaLabel.TabIndex = 3;
            this.lastGpaLabel.Text = "0.0";
            // 
            // lastCreditsLabel
            // 
            this.lastCreditsLabel.AutoSize = true;
            this.lastCreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastCreditsLabel.Location = new System.Drawing.Point(176, 84);
            this.lastCreditsLabel.Name = "lastCreditsLabel";
            this.lastCreditsLabel.Size = new System.Drawing.Size(15, 16);
            this.lastCreditsLabel.TabIndex = 2;
            this.lastCreditsLabel.Text = "0";
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorLabel.Location = new System.Drawing.Point(66, 84);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(75, 16);
            this.majorLabel.TabIndex = 1;
            this.majorLabel.Text = "Last Terms";
            // 
            // cumulativeLabel
            // 
            this.cumulativeLabel.AutoSize = true;
            this.cumulativeLabel.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cumulativeLabel.Location = new System.Drawing.Point(3, 10);
            this.cumulativeLabel.Name = "cumulativeLabel";
            this.cumulativeLabel.Size = new System.Drawing.Size(162, 40);
            this.cumulativeLabel.TabIndex = 0;
            this.cumulativeLabel.Text = "Cumulative";
            // 
            // coursesTextBox
            // 
            this.coursesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coursesTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.coursesTextBox.Location = new System.Drawing.Point(0, 0);
            this.coursesTextBox.Multiline = true;
            this.coursesTextBox.Name = "coursesTextBox";
            this.coursesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.coursesTextBox.Size = new System.Drawing.Size(382, 377);
            this.coursesTextBox.TabIndex = 1;
            // 
            // gradeUpDown
            // 
            this.gradeUpDown.DecimalPlaces = 1;
            this.gradeUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gradeUpDown.Location = new System.Drawing.Point(104, 263);
            this.gradeUpDown.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            65536});
            this.gradeUpDown.Name = "gradeUpDown";
            this.gradeUpDown.Size = new System.Drawing.Size(46, 20);
            this.gradeUpDown.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(898, 591);
            this.Controls.Add(this.splitContainerBase);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Smart GPA Calculator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainerBase.Panel1.ResumeLayout(false);
            this.splitContainerBase.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBase)).EndInit();
            this.splitContainerBase.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel1.PerformLayout();
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            this.splitContainerLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCreditsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.splitContainerRight.Panel1.ResumeLayout(false);
            this.splitContainerRight.Panel1.PerformLayout();
            this.splitContainerRight.Panel2.ResumeLayout(false);
            this.splitContainerRight.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerBase;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.Button addClassButton;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label courseNumLabel;
        private System.Windows.Forms.Label deptLabel;
        private System.Windows.Forms.Label courseIdLabel;
        private System.Windows.Forms.TextBox deptTextBox;
        private System.Windows.Forms.NumericUpDown yearUpDown;
        private System.Windows.Forms.ComboBox termSeasonComboBox;
        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.Label calculatorTitleLabel;
        private System.Windows.Forms.Label gpaTitleLabel;
        private System.Windows.Forms.Label smartTitleLabel;
        private System.Windows.Forms.Label graphExplanationLabel;
        private System.Windows.Forms.SplitContainer splitContainerRight;
        private System.Windows.Forms.Label cumulativeLabel;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.Label overallCreditLabel;
        private System.Windows.Forms.Label overallLabel;
        private System.Windows.Forms.Label currentGpaLabel;
        private System.Windows.Forms.Label currentCreditsLabel;
        private System.Windows.Forms.Label minorLabel;
        private System.Windows.Forms.Label lastGpaLabel;
        private System.Windows.Forms.Label lastCreditsLabel;
        private System.Windows.Forms.Label overallGpaLabel;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label overallPointsLabel;
        private System.Windows.Forms.Label currentPointsLabel;
        private System.Windows.Forms.Label lastPointsLabel;
        private System.Windows.Forms.NumericUpDown numCreditsUpDown;
        private System.Windows.Forms.Label numCreditsLabel;
        private System.Windows.Forms.TextBox coursesTextBox;
        private System.Windows.Forms.NumericUpDown courseNumUpDown;
        private System.Windows.Forms.NumericUpDown gradeUpDown;
    }
}

