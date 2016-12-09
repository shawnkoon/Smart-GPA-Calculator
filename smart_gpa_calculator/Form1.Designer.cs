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
            this.applicableComboBox = new System.Windows.Forms.ComboBox();
            this.applicableLabel = new System.Windows.Forms.Label();
            this.minorTextBox = new System.Windows.Forms.TextBox();
            this.enterMinorLabel = new System.Windows.Forms.Label();
            this.majorTextBox = new System.Windows.Forms.TextBox();
            this.enterMajorLabel = new System.Windows.Forms.Label();
            this.addClassButton = new System.Windows.Forms.Button();
            this.outOfLabel = new System.Windows.Forms.Label();
            this.actualLabel = new System.Windows.Forms.Label();
            this.slashLabel = new System.Windows.Forms.Label();
            this.outOfTextBox = new System.Windows.Forms.TextBox();
            this.actualTextBox = new System.Windows.Forms.TextBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.courseNumLabel = new System.Windows.Forms.Label();
            this.deptLabel = new System.Windows.Forms.Label();
            this.courseNumTextBox = new System.Windows.Forms.TextBox();
            this.courseIdLabel = new System.Windows.Forms.Label();
            this.deptTextBox = new System.Windows.Forms.TextBox();
            this.quarterSemesterComboBox = new System.Windows.Forms.ComboBox();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.termComboBox = new System.Windows.Forms.ComboBox();
            this.termLabel = new System.Windows.Forms.Label();
            this.calculatorLabel = new System.Windows.Forms.Label();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.smartLabel = new System.Windows.Forms.Label();
            this.graphExplanationLabel = new System.Windows.Forms.Label();
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.overallCreditLabel = new System.Windows.Forms.Label();
            this.overallLabel = new System.Windows.Forms.Label();
            this.minorGpaLabel = new System.Windows.Forms.Label();
            this.minorCreditsLabel = new System.Windows.Forms.Label();
            this.minorLabel = new System.Windows.Forms.Label();
            this.majorGpaLabel = new System.Windows.Forms.Label();
            this.majorCreditsLabel = new System.Windows.Forms.Label();
            this.majorLabel = new System.Windows.Forms.Label();
            this.cumulativeLabel = new System.Windows.Forms.Label();
            this.termListScrollBar = new System.Windows.Forms.VScrollBar();
            this.overallGpaLabel = new System.Windows.Forms.Label();
            this.overviewExplanationLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBase)).BeginInit();
            this.splitContainerBase.Panel1.SuspendLayout();
            this.splitContainerBase.Panel2.SuspendLayout();
            this.splitContainerBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(933, 24);
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
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
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
            this.splitContainerBase.Size = new System.Drawing.Size(933, 567);
            this.splitContainerBase.SplitterDistance = 540;
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
            this.splitContainerLeft.Panel1.Controls.Add(this.applicableComboBox);
            this.splitContainerLeft.Panel1.Controls.Add(this.applicableLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.minorTextBox);
            this.splitContainerLeft.Panel1.Controls.Add(this.enterMinorLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.majorTextBox);
            this.splitContainerLeft.Panel1.Controls.Add(this.enterMajorLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.addClassButton);
            this.splitContainerLeft.Panel1.Controls.Add(this.outOfLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.actualLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.slashLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.outOfTextBox);
            this.splitContainerLeft.Panel1.Controls.Add(this.actualTextBox);
            this.splitContainerLeft.Panel1.Controls.Add(this.gradeLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.courseNameTextBox);
            this.splitContainerLeft.Panel1.Controls.Add(this.courseNameLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.courseNumLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.deptLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.courseNumTextBox);
            this.splitContainerLeft.Panel1.Controls.Add(this.courseIdLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.deptTextBox);
            this.splitContainerLeft.Panel1.Controls.Add(this.quarterSemesterComboBox);
            this.splitContainerLeft.Panel1.Controls.Add(this.yearUpDown);
            this.splitContainerLeft.Panel1.Controls.Add(this.termComboBox);
            this.splitContainerLeft.Panel1.Controls.Add(this.termLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.calculatorLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.gpaLabel);
            this.splitContainerLeft.Panel1.Controls.Add(this.smartLabel);
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainerLeft.Panel2.Controls.Add(this.graphExplanationLabel);
            this.splitContainerLeft.Size = new System.Drawing.Size(540, 567);
            this.splitContainerLeft.SplitterDistance = 375;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // applicableComboBox
            // 
            this.applicableComboBox.FormattingEnabled = true;
            this.applicableComboBox.Items.AddRange(new object[] {
            "Major",
            "Minor",
            "(General)"});
            this.applicableComboBox.Location = new System.Drawing.Point(440, 275);
            this.applicableComboBox.Name = "applicableComboBox";
            this.applicableComboBox.Size = new System.Drawing.Size(86, 21);
            this.applicableComboBox.TabIndex = 33;
            this.applicableComboBox.Text = "Category";
            // 
            // applicableLabel
            // 
            this.applicableLabel.AutoSize = true;
            this.applicableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicableLabel.Location = new System.Drawing.Point(236, 276);
            this.applicableLabel.Name = "applicableLabel";
            this.applicableLabel.Size = new System.Drawing.Size(198, 16);
            this.applicableLabel.TabIndex = 32;
            this.applicableLabel.Text = "What does this course apply to?";
            // 
            // minorTextBox
            // 
            this.minorTextBox.Location = new System.Drawing.Point(392, 76);
            this.minorTextBox.Name = "minorTextBox";
            this.minorTextBox.Size = new System.Drawing.Size(121, 20);
            this.minorTextBox.TabIndex = 31;
            // 
            // enterMinorLabel
            // 
            this.enterMinorLabel.AutoSize = true;
            this.enterMinorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterMinorLabel.Location = new System.Drawing.Point(279, 76);
            this.enterMinorLabel.Name = "enterMinorLabel";
            this.enterMinorLabel.Size = new System.Drawing.Size(107, 16);
            this.enterMinorLabel.TabIndex = 30;
            this.enterMinorLabel.Text = "Enter your Minor:";
            // 
            // majorTextBox
            // 
            this.majorTextBox.Location = new System.Drawing.Point(126, 76);
            this.majorTextBox.Name = "majorTextBox";
            this.majorTextBox.Size = new System.Drawing.Size(147, 20);
            this.majorTextBox.TabIndex = 29;
            // 
            // enterMajorLabel
            // 
            this.enterMajorLabel.AutoSize = true;
            this.enterMajorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterMajorLabel.Location = new System.Drawing.Point(12, 77);
            this.enterMajorLabel.Name = "enterMajorLabel";
            this.enterMajorLabel.Size = new System.Drawing.Size(108, 16);
            this.enterMajorLabel.TabIndex = 28;
            this.enterMajorLabel.Text = "Enter your Major:";
            // 
            // addClassButton
            // 
            this.addClassButton.Location = new System.Drawing.Point(227, 327);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(75, 23);
            this.addClassButton.TabIndex = 27;
            this.addClassButton.Text = "Add Class";
            this.addClassButton.UseVisualStyleBackColor = true;
            // 
            // outOfLabel
            // 
            this.outOfLabel.AutoSize = true;
            this.outOfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outOfLabel.Location = new System.Drawing.Point(177, 298);
            this.outOfLabel.Name = "outOfLabel";
            this.outOfLabel.Size = new System.Drawing.Size(35, 9);
            this.outOfLabel.TabIndex = 26;
            this.outOfLabel.Text = "OUT OF";
            // 
            // actualLabel
            // 
            this.actualLabel.AutoSize = true;
            this.actualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualLabel.Location = new System.Drawing.Point(117, 298);
            this.actualLabel.Name = "actualLabel";
            this.actualLabel.Size = new System.Drawing.Size(36, 9);
            this.actualLabel.TabIndex = 25;
            this.actualLabel.Text = "ACTUAL";
            // 
            // slashLabel
            // 
            this.slashLabel.AutoSize = true;
            this.slashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slashLabel.Location = new System.Drawing.Point(159, 276);
            this.slashLabel.Name = "slashLabel";
            this.slashLabel.Size = new System.Drawing.Size(12, 16);
            this.slashLabel.TabIndex = 24;
            this.slashLabel.Text = "/";
            // 
            // outOfTextBox
            // 
            this.outOfTextBox.Location = new System.Drawing.Point(177, 275);
            this.outOfTextBox.Name = "outOfTextBox";
            this.outOfTextBox.Size = new System.Drawing.Size(34, 20);
            this.outOfTextBox.TabIndex = 23;
            // 
            // actualTextBox
            // 
            this.actualTextBox.Location = new System.Drawing.Point(119, 275);
            this.actualTextBox.Name = "actualTextBox";
            this.actualTextBox.Size = new System.Drawing.Size(34, 20);
            this.actualTextBox.TabIndex = 22;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.Location = new System.Drawing.Point(12, 276);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(101, 20);
            this.gradeLabel.TabIndex = 21;
            this.gradeLabel.Text = "Enter Grade:";
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(198, 224);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.courseNameTextBox.TabIndex = 20;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.Location = new System.Drawing.Point(12, 222);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(180, 20);
            this.courseNameLabel.TabIndex = 19;
            this.courseNameLabel.Text = "Enter the Course Name:";
            // 
            // courseNumLabel
            // 
            this.courseNumLabel.AutoSize = true;
            this.courseNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNumLabel.Location = new System.Drawing.Point(288, 195);
            this.courseNumLabel.Name = "courseNumLabel";
            this.courseNumLabel.Size = new System.Drawing.Size(40, 9);
            this.courseNumLabel.TabIndex = 18;
            this.courseNumLabel.Text = "NUMBER";
            // 
            // deptLabel
            // 
            this.deptLabel.AutoSize = true;
            this.deptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptLabel.Location = new System.Drawing.Point(225, 195);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(26, 9);
            this.deptLabel.TabIndex = 17;
            this.deptLabel.Text = "DEPT";
            // 
            // courseNumTextBox
            // 
            this.courseNumTextBox.Location = new System.Drawing.Point(290, 172);
            this.courseNumTextBox.Name = "courseNumTextBox";
            this.courseNumTextBox.Size = new System.Drawing.Size(49, 20);
            this.courseNumTextBox.TabIndex = 16;
            // 
            // courseIdLabel
            // 
            this.courseIdLabel.AutoSize = true;
            this.courseIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdLabel.Location = new System.Drawing.Point(12, 170);
            this.courseIdLabel.Name = "courseIdLabel";
            this.courseIdLabel.Size = new System.Drawing.Size(200, 20);
            this.courseIdLabel.TabIndex = 15;
            this.courseIdLabel.Text = "Enter the Course Identifier:";
            // 
            // deptTextBox
            // 
            this.deptTextBox.Location = new System.Drawing.Point(227, 172);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.Size = new System.Drawing.Size(46, 20);
            this.deptTextBox.TabIndex = 14;
            // 
            // quarterSemesterComboBox
            // 
            this.quarterSemesterComboBox.FormattingEnabled = true;
            this.quarterSemesterComboBox.Items.AddRange(new object[] {
            "Quarter",
            "Semester"});
            this.quarterSemesterComboBox.Location = new System.Drawing.Point(430, 117);
            this.quarterSemesterComboBox.Name = "quarterSemesterComboBox";
            this.quarterSemesterComboBox.Size = new System.Drawing.Size(91, 21);
            this.quarterSemesterComboBox.TabIndex = 13;
            this.quarterSemesterComboBox.Text = "Term Length";
            // 
            // yearUpDown
            // 
            this.yearUpDown.Location = new System.Drawing.Point(354, 117);
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
            this.yearUpDown.TabIndex = 12;
            this.yearUpDown.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // termComboBox
            // 
            this.termComboBox.FormattingEnabled = true;
            this.termComboBox.Items.AddRange(new object[] {
            "Fall",
            "Winter",
            "Spring",
            "Summer"});
            this.termComboBox.Location = new System.Drawing.Point(251, 117);
            this.termComboBox.Name = "termComboBox";
            this.termComboBox.Size = new System.Drawing.Size(88, 21);
            this.termComboBox.TabIndex = 11;
            this.termComboBox.Text = "Term";
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termLabel.Location = new System.Drawing.Point(12, 115);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(233, 20);
            this.termLabel.TabIndex = 10;
            this.termLabel.Text = "Which Term will this class be in?";
            // 
            // calculatorLabel
            // 
            this.calculatorLabel.AutoSize = true;
            this.calculatorLabel.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.calculatorLabel.Location = new System.Drawing.Point(281, 10);
            this.calculatorLabel.Name = "calculatorLabel";
            this.calculatorLabel.Size = new System.Drawing.Size(189, 49);
            this.calculatorLabel.TabIndex = 9;
            this.calculatorLabel.Text = "Calculator";
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaLabel.ForeColor = System.Drawing.Color.LightCoral;
            this.gpaLabel.Location = new System.Drawing.Point(193, 10);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(91, 49);
            this.gpaLabel.TabIndex = 8;
            this.gpaLabel.Text = "GPA";
            // 
            // smartLabel
            // 
            this.smartLabel.AutoSize = true;
            this.smartLabel.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.smartLabel.Location = new System.Drawing.Point(67, 10);
            this.smartLabel.Name = "smartLabel";
            this.smartLabel.Size = new System.Drawing.Size(125, 49);
            this.smartLabel.TabIndex = 7;
            this.smartLabel.Text = "Smart";
            // 
            // graphExplanationLabel
            // 
            this.graphExplanationLabel.AutoSize = true;
            this.graphExplanationLabel.Location = new System.Drawing.Point(177, 30);
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
            this.splitContainerRight.Panel1.Controls.Add(this.overallGpaLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.overallCreditLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.overallLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.minorGpaLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.minorCreditsLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.minorLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.majorGpaLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.majorCreditsLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.majorLabel);
            this.splitContainerRight.Panel1.Controls.Add(this.cumulativeLabel);
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.BackColor = System.Drawing.Color.Ivory;
            this.splitContainerRight.Panel2.Controls.Add(this.overviewExplanationLabel);
            this.splitContainerRight.Panel2.Controls.Add(this.termListScrollBar);
            this.splitContainerRight.Size = new System.Drawing.Size(389, 567);
            this.splitContainerRight.SplitterDistance = 186;
            this.splitContainerRight.TabIndex = 0;
            // 
            // overallCreditLabel
            // 
            this.overallCreditLabel.AutoSize = true;
            this.overallCreditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallCreditLabel.Location = new System.Drawing.Point(148, 140);
            this.overallCreditLabel.Name = "overallCreditLabel";
            this.overallCreditLabel.Size = new System.Drawing.Size(15, 16);
            this.overallCreditLabel.TabIndex = 8;
            this.overallCreditLabel.Text = "0";
            // 
            // overallLabel
            // 
            this.overallLabel.AutoSize = true;
            this.overallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallLabel.Location = new System.Drawing.Point(49, 137);
            this.overallLabel.Name = "overallLabel";
            this.overallLabel.Size = new System.Drawing.Size(57, 20);
            this.overallLabel.TabIndex = 7;
            this.overallLabel.Text = "Overall";
            // 
            // minorGpaLabel
            // 
            this.minorGpaLabel.AutoSize = true;
            this.minorGpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minorGpaLabel.Location = new System.Drawing.Point(219, 108);
            this.minorGpaLabel.Name = "minorGpaLabel";
            this.minorGpaLabel.Size = new System.Drawing.Size(25, 16);
            this.minorGpaLabel.TabIndex = 6;
            this.minorGpaLabel.Text = "0.0";
            // 
            // minorCreditsLabel
            // 
            this.minorCreditsLabel.AutoSize = true;
            this.minorCreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minorCreditsLabel.Location = new System.Drawing.Point(148, 107);
            this.minorCreditsLabel.Name = "minorCreditsLabel";
            this.minorCreditsLabel.Size = new System.Drawing.Size(15, 16);
            this.minorCreditsLabel.TabIndex = 5;
            this.minorCreditsLabel.Text = "0";
            // 
            // minorLabel
            // 
            this.minorLabel.AutoSize = true;
            this.minorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minorLabel.Location = new System.Drawing.Point(49, 104);
            this.minorLabel.Name = "minorLabel";
            this.minorLabel.Size = new System.Drawing.Size(48, 20);
            this.minorLabel.TabIndex = 4;
            this.minorLabel.Text = "Minor";
            // 
            // majorGpaLabel
            // 
            this.majorGpaLabel.AutoSize = true;
            this.majorGpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorGpaLabel.Location = new System.Drawing.Point(219, 76);
            this.majorGpaLabel.Name = "majorGpaLabel";
            this.majorGpaLabel.Size = new System.Drawing.Size(25, 16);
            this.majorGpaLabel.TabIndex = 3;
            this.majorGpaLabel.Text = "0.0";
            // 
            // majorCreditsLabel
            // 
            this.majorCreditsLabel.AutoSize = true;
            this.majorCreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorCreditsLabel.Location = new System.Drawing.Point(148, 76);
            this.majorCreditsLabel.Name = "majorCreditsLabel";
            this.majorCreditsLabel.Size = new System.Drawing.Size(15, 16);
            this.majorCreditsLabel.TabIndex = 2;
            this.majorCreditsLabel.Text = "0";
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorLabel.Location = new System.Drawing.Point(49, 72);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(48, 20);
            this.majorLabel.TabIndex = 1;
            this.majorLabel.Text = "Major";
            // 
            // cumulativeLabel
            // 
            this.cumulativeLabel.AutoSize = true;
            this.cumulativeLabel.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cumulativeLabel.Location = new System.Drawing.Point(28, 17);
            this.cumulativeLabel.Name = "cumulativeLabel";
            this.cumulativeLabel.Size = new System.Drawing.Size(162, 40);
            this.cumulativeLabel.TabIndex = 0;
            this.cumulativeLabel.Text = "Cumulative";
            // 
            // termListScrollBar
            // 
            this.termListScrollBar.Location = new System.Drawing.Point(372, 0);
            this.termListScrollBar.Name = "termListScrollBar";
            this.termListScrollBar.Size = new System.Drawing.Size(17, 377);
            this.termListScrollBar.TabIndex = 0;
            // 
            // overallGpaLabel
            // 
            this.overallGpaLabel.AutoSize = true;
            this.overallGpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallGpaLabel.Location = new System.Drawing.Point(219, 140);
            this.overallGpaLabel.Name = "overallGpaLabel";
            this.overallGpaLabel.Size = new System.Drawing.Size(25, 16);
            this.overallGpaLabel.TabIndex = 9;
            this.overallGpaLabel.Text = "0.0";
            // 
            // overviewExplanationLabel
            // 
            this.overviewExplanationLabel.AutoSize = true;
            this.overviewExplanationLabel.Location = new System.Drawing.Point(105, 41);
            this.overviewExplanationLabel.Name = "overviewExplanationLabel";
            this.overviewExplanationLabel.Size = new System.Drawing.Size(171, 13);
            this.overviewExplanationLabel.TabIndex = 1;
            this.overviewExplanationLabel.Text = "List of Term Overviews will be here";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(933, 591);
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
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.splitContainerRight.Panel1.ResumeLayout(false);
            this.splitContainerRight.Panel1.PerformLayout();
            this.splitContainerRight.Panel2.ResumeLayout(false);
            this.splitContainerRight.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox applicableComboBox;
        private System.Windows.Forms.Label applicableLabel;
        private System.Windows.Forms.TextBox minorTextBox;
        private System.Windows.Forms.Label enterMinorLabel;
        private System.Windows.Forms.TextBox majorTextBox;
        private System.Windows.Forms.Label enterMajorLabel;
        private System.Windows.Forms.Button addClassButton;
        private System.Windows.Forms.Label outOfLabel;
        private System.Windows.Forms.Label actualLabel;
        private System.Windows.Forms.Label slashLabel;
        private System.Windows.Forms.TextBox outOfTextBox;
        private System.Windows.Forms.TextBox actualTextBox;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label courseNumLabel;
        private System.Windows.Forms.Label deptLabel;
        private System.Windows.Forms.TextBox courseNumTextBox;
        private System.Windows.Forms.Label courseIdLabel;
        private System.Windows.Forms.TextBox deptTextBox;
        private System.Windows.Forms.ComboBox quarterSemesterComboBox;
        private System.Windows.Forms.NumericUpDown yearUpDown;
        private System.Windows.Forms.ComboBox termComboBox;
        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.Label calculatorLabel;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label smartLabel;
        private System.Windows.Forms.Label graphExplanationLabel;
        private System.Windows.Forms.SplitContainer splitContainerRight;
        private System.Windows.Forms.Label cumulativeLabel;
        private System.Windows.Forms.VScrollBar termListScrollBar;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.Label overallCreditLabel;
        private System.Windows.Forms.Label overallLabel;
        private System.Windows.Forms.Label minorGpaLabel;
        private System.Windows.Forms.Label minorCreditsLabel;
        private System.Windows.Forms.Label minorLabel;
        private System.Windows.Forms.Label majorGpaLabel;
        private System.Windows.Forms.Label majorCreditsLabel;
        private System.Windows.Forms.Label overallGpaLabel;
        private System.Windows.Forms.Label overviewExplanationLabel;
    }
}

