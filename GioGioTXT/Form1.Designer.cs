namespace GioGioTXT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            StripFile = new ToolStripMenuItem();
            StripFileOpen = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            StripFileSave = new ToolStripMenuItem();
            StripFileSaveAs = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            StripFileQuit = new ToolStripMenuItem();
            RichTextInput = new RichTextBox();
            EndFrameLabel = new Label();
            EndFrameCounter = new NumericUpDown();
            BubbleShapeLabel = new Label();
            BubbleShapePicker = new ComboBox();
            BubbleTailLabel = new Label();
            BubbleTailPicker = new ComboBox();
            BubblePositionLabel = new Label();
            BubblePositionPicker = new ComboBox();
            PropertiesTable = new TableLayoutPanel();
            StartFrameLabel = new Label();
            BubblePosXLabel = new Label();
            BubblePosYLabel = new Label();
            Panel2DIndexLabel = new Label();
            Panel2DBehaviorLabel = new Label();
            CutInPanelLabel = new Label();
            CutInPositionLabel = new Label();
            CutInPositionPicker = new ComboBox();
            CutInPanelPicker = new ComboBox();
            Panel2DBehaviorCounter = new NumericUpDown();
            Panel2DIndexCounter = new NumericUpDown();
            BubblePosYCounter = new NumericUpDown();
            BubblePosXCounter = new NumericUpDown();
            StartFrameCounter = new NumericUpDown();
            PropertiesGroup = new GroupBox();
            LineGrid = new DataGridView();
            LineColumn = new DataGridViewTextBoxColumn();
            LineSelectionGroup = new GroupBox();
            LineGroupRemove = new Button();
            LineGroupAdd = new Button();
            LineGroupPicker = new ComboBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EndFrameCounter).BeginInit();
            PropertiesTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Panel2DBehaviorCounter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Panel2DIndexCounter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BubblePosYCounter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BubblePosXCounter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StartFrameCounter).BeginInit();
            PropertiesGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LineGrid).BeginInit();
            LineSelectionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { StripFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(754, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // StripFile
            // 
            StripFile.DropDownItems.AddRange(new ToolStripItem[] { StripFileOpen, toolStripSeparator1, StripFileSave, StripFileSaveAs, toolStripSeparator2, StripFileQuit });
            StripFile.Name = "StripFile";
            StripFile.Size = new Size(37, 20);
            StripFile.Text = "File";
            // 
            // StripFileOpen
            // 
            StripFileOpen.Name = "StripFileOpen";
            StripFileOpen.Size = new Size(121, 22);
            StripFileOpen.Text = "Open";
            StripFileOpen.Click += StripFileOpen_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(118, 6);
            // 
            // StripFileSave
            // 
            StripFileSave.Name = "StripFileSave";
            StripFileSave.Size = new Size(121, 22);
            StripFileSave.Text = "Save";
            StripFileSave.Click += StripFileSave_Click;
            // 
            // StripFileSaveAs
            // 
            StripFileSaveAs.Name = "StripFileSaveAs";
            StripFileSaveAs.Size = new Size(121, 22);
            StripFileSaveAs.Text = "Save as...";
            StripFileSaveAs.Click += StripFileSaveAs_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(118, 6);
            // 
            // StripFileQuit
            // 
            StripFileQuit.Name = "StripFileQuit";
            StripFileQuit.Size = new Size(121, 22);
            StripFileQuit.Text = "Exit";
            StripFileQuit.Click += StripFileQuit_Click;
            // 
            // RichTextInput
            // 
            RichTextInput.Enabled = false;
            RichTextInput.Location = new Point(380, 233);
            RichTextInput.Name = "RichTextInput";
            RichTextInput.Size = new Size(366, 71);
            RichTextInput.TabIndex = 1;
            RichTextInput.Text = "";
            RichTextInput.TextChanged += RichTextInput_TextChanged;
            // 
            // EndFrameLabel
            // 
            EndFrameLabel.AutoSize = true;
            EndFrameLabel.Location = new Point(3, 29);
            EndFrameLabel.Name = "EndFrameLabel";
            EndFrameLabel.Padding = new Padding(5);
            EndFrameLabel.Size = new Size(73, 25);
            EndFrameLabel.TabIndex = 4;
            EndFrameLabel.Text = "End Frame";
            // 
            // EndFrameCounter
            // 
            EndFrameCounter.Location = new Point(255, 32);
            EndFrameCounter.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            EndFrameCounter.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            EndFrameCounter.Name = "EndFrameCounter";
            EndFrameCounter.Size = new Size(102, 23);
            EndFrameCounter.TabIndex = 3;
            EndFrameCounter.ValueChanged += EndFrameCounter_ValueChanged;
            // 
            // BubbleShapeLabel
            // 
            BubbleShapeLabel.AutoSize = true;
            BubbleShapeLabel.Location = new Point(3, 58);
            BubbleShapeLabel.Name = "BubbleShapeLabel";
            BubbleShapeLabel.Padding = new Padding(5);
            BubbleShapeLabel.Size = new Size(130, 25);
            BubbleShapeLabel.TabIndex = 5;
            BubbleShapeLabel.Text = "Speech Bubble Shape";
            // 
            // BubbleShapePicker
            // 
            BubbleShapePicker.FormattingEnabled = true;
            BubbleShapePicker.Items.AddRange(new object[] { "Speech (Tiny)", "Speech (Medium)", "Speech (Big)", "Thought (Tiny)", "Thought (Medium)", "Thought (Big)", "Scream (Tiny)", "Scream (Medium)", "Scream (Big)", "Ghost (Tiny)", "Ghost (Medium)", "Ghost (Big)", "Narration (Tiny)", "Narration (Medium)", "Narration (Big)" });
            BubbleShapePicker.Location = new Point(255, 61);
            BubbleShapePicker.Name = "BubbleShapePicker";
            BubbleShapePicker.Size = new Size(102, 23);
            BubbleShapePicker.TabIndex = 6;
            BubbleShapePicker.SelectionChangeCommitted += BubbleShapePicker_SelectionChangeCommitted;
            // 
            // BubbleTailLabel
            // 
            BubbleTailLabel.AutoSize = true;
            BubbleTailLabel.Location = new Point(3, 87);
            BubbleTailLabel.Name = "BubbleTailLabel";
            BubbleTailLabel.Padding = new Padding(5);
            BubbleTailLabel.Size = new Size(166, 25);
            BubbleTailLabel.TabIndex = 7;
            BubbleTailLabel.Text = "Speech Bubble Tail Direction";
            // 
            // BubbleTailPicker
            // 
            BubbleTailPicker.FormattingEnabled = true;
            BubbleTailPicker.Items.AddRange(new object[] { "Top Left", "Top Right", "Bottom Left", "Bottom Right" });
            BubbleTailPicker.Location = new Point(255, 90);
            BubbleTailPicker.Name = "BubbleTailPicker";
            BubbleTailPicker.Size = new Size(102, 23);
            BubbleTailPicker.TabIndex = 8;
            BubbleTailPicker.SelectionChangeCommitted += BubbleTailPicker_SelectionChangeCommitted;
            // 
            // BubblePositionLabel
            // 
            BubblePositionLabel.AutoSize = true;
            BubblePositionLabel.Location = new Point(3, 116);
            BubblePositionLabel.Name = "BubblePositionLabel";
            BubblePositionLabel.Padding = new Padding(5);
            BubblePositionLabel.Size = new Size(141, 25);
            BubblePositionLabel.TabIndex = 9;
            BubblePositionLabel.Text = "Speech Bubble Position";
            // 
            // BubblePositionPicker
            // 
            BubblePositionPicker.FormattingEnabled = true;
            BubblePositionPicker.Items.AddRange(new object[] { "Top Left", "Top Middle", "Top Right", "Center Left", "Center Middle", "Center Right", "Bottom Left", "Bottom Middle", "Bottom Right" });
            BubblePositionPicker.Location = new Point(255, 119);
            BubblePositionPicker.Name = "BubblePositionPicker";
            BubblePositionPicker.Size = new Size(102, 23);
            BubblePositionPicker.TabIndex = 10;
            BubblePositionPicker.SelectionChangeCommitted += BubblePositionPicker_SelectionChangeCommitted;
            // 
            // PropertiesTable
            // 
            PropertiesTable.ColumnCount = 2;
            PropertiesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            PropertiesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            PropertiesTable.Controls.Add(StartFrameLabel, 0, 0);
            PropertiesTable.Controls.Add(EndFrameLabel, 0, 1);
            PropertiesTable.Controls.Add(BubbleShapeLabel, 0, 2);
            PropertiesTable.Controls.Add(BubbleTailLabel, 0, 3);
            PropertiesTable.Controls.Add(BubblePositionLabel, 0, 4);
            PropertiesTable.Controls.Add(BubblePosXLabel, 0, 5);
            PropertiesTable.Controls.Add(BubblePosYLabel, 0, 6);
            PropertiesTable.Controls.Add(Panel2DIndexLabel, 0, 7);
            PropertiesTable.Controls.Add(Panel2DBehaviorLabel, 0, 8);
            PropertiesTable.Controls.Add(CutInPanelLabel, 0, 9);
            PropertiesTable.Controls.Add(CutInPositionLabel, 0, 10);
            PropertiesTable.Controls.Add(CutInPositionPicker, 1, 10);
            PropertiesTable.Controls.Add(CutInPanelPicker, 1, 9);
            PropertiesTable.Controls.Add(Panel2DBehaviorCounter, 1, 8);
            PropertiesTable.Controls.Add(Panel2DIndexCounter, 1, 7);
            PropertiesTable.Controls.Add(BubblePosYCounter, 1, 6);
            PropertiesTable.Controls.Add(BubblePosXCounter, 1, 5);
            PropertiesTable.Controls.Add(BubblePositionPicker, 1, 4);
            PropertiesTable.Controls.Add(BubbleTailPicker, 1, 3);
            PropertiesTable.Controls.Add(BubbleShapePicker, 1, 2);
            PropertiesTable.Controls.Add(EndFrameCounter, 1, 1);
            PropertiesTable.Controls.Add(StartFrameCounter, 1, 0);
            PropertiesTable.Dock = DockStyle.Fill;
            PropertiesTable.Location = new Point(3, 19);
            PropertiesTable.Name = "PropertiesTable";
            PropertiesTable.RowCount = 13;
            PropertiesTable.RowStyles.Add(new RowStyle());
            PropertiesTable.RowStyles.Add(new RowStyle());
            PropertiesTable.RowStyles.Add(new RowStyle());
            PropertiesTable.RowStyles.Add(new RowStyle());
            PropertiesTable.RowStyles.Add(new RowStyle());
            PropertiesTable.RowStyles.Add(new RowStyle());
            PropertiesTable.RowStyles.Add(new RowStyle());
            PropertiesTable.RowStyles.Add(new RowStyle());
            PropertiesTable.RowStyles.Add(new RowStyle());
            PropertiesTable.RowStyles.Add(new RowStyle());
            PropertiesTable.RowStyles.Add(new RowStyle());
            PropertiesTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            PropertiesTable.RowStyles.Add(new RowStyle());
            PropertiesTable.Size = new Size(360, 175);
            PropertiesTable.TabIndex = 11;
            // 
            // StartFrameLabel
            // 
            StartFrameLabel.AutoSize = true;
            StartFrameLabel.Location = new Point(3, 0);
            StartFrameLabel.Name = "StartFrameLabel";
            StartFrameLabel.Padding = new Padding(5);
            StartFrameLabel.Size = new Size(77, 25);
            StartFrameLabel.TabIndex = 2;
            StartFrameLabel.Text = "Start Frame";
            // 
            // BubblePosXLabel
            // 
            BubblePosXLabel.AutoSize = true;
            BubblePosXLabel.Location = new Point(3, 145);
            BubblePosXLabel.Name = "BubblePosXLabel";
            BubblePosXLabel.Padding = new Padding(5);
            BubblePosXLabel.Size = new Size(199, 25);
            BubblePosXLabel.TabIndex = 11;
            BubblePosXLabel.Text = "Speech Bubble Horizontal Position";
            // 
            // BubblePosYLabel
            // 
            BubblePosYLabel.AutoSize = true;
            BubblePosYLabel.Location = new Point(3, 174);
            BubblePosYLabel.Name = "BubblePosYLabel";
            BubblePosYLabel.Padding = new Padding(5);
            BubblePosYLabel.Size = new Size(182, 25);
            BubblePosYLabel.TabIndex = 12;
            BubblePosYLabel.Text = "Speech Bubble Vertical Position";
            // 
            // Panel2DIndexLabel
            // 
            Panel2DIndexLabel.AutoSize = true;
            Panel2DIndexLabel.Location = new Point(3, 203);
            Panel2DIndexLabel.Name = "Panel2DIndexLabel";
            Panel2DIndexLabel.Padding = new Padding(5);
            Panel2DIndexLabel.Size = new Size(100, 25);
            Panel2DIndexLabel.TabIndex = 13;
            Panel2DIndexLabel.Text = "Panel Displayed";
            // 
            // Panel2DBehaviorLabel
            // 
            Panel2DBehaviorLabel.AutoSize = true;
            Panel2DBehaviorLabel.Location = new Point(3, 232);
            Panel2DBehaviorLabel.Name = "Panel2DBehaviorLabel";
            Panel2DBehaviorLabel.Padding = new Padding(5);
            Panel2DBehaviorLabel.Size = new Size(95, 25);
            Panel2DBehaviorLabel.TabIndex = 15;
            Panel2DBehaviorLabel.Text = "Panel Behavior";
            // 
            // CutInPanelLabel
            // 
            CutInPanelLabel.AutoSize = true;
            CutInPanelLabel.Location = new Point(3, 261);
            CutInPanelLabel.Name = "CutInPanelLabel";
            CutInPanelLabel.Padding = new Padding(5);
            CutInPanelLabel.Size = new Size(83, 25);
            CutInPanelLabel.TabIndex = 14;
            CutInPanelLabel.Text = "Cut-In Panel";
            // 
            // CutInPositionLabel
            // 
            CutInPositionLabel.AutoSize = true;
            CutInPositionLabel.Location = new Point(3, 290);
            CutInPositionLabel.Name = "CutInPositionLabel";
            CutInPositionLabel.Padding = new Padding(5);
            CutInPositionLabel.Size = new Size(97, 25);
            CutInPositionLabel.TabIndex = 16;
            CutInPositionLabel.Text = "Cut-In Position";
            // 
            // CutInPositionPicker
            // 
            CutInPositionPicker.FormattingEnabled = true;
            CutInPositionPicker.Items.AddRange(new object[] { "Top Left", "Top Right" });
            CutInPositionPicker.Location = new Point(255, 293);
            CutInPositionPicker.Name = "CutInPositionPicker";
            CutInPositionPicker.Size = new Size(102, 23);
            CutInPositionPicker.TabIndex = 22;
            CutInPositionPicker.SelectedValueChanged += CutInPositionPicker_SelectedValueChanged;
            // 
            // CutInPanelPicker
            // 
            CutInPanelPicker.FormattingEnabled = true;
            CutInPanelPicker.Items.AddRange(new object[] { "Player (Neutral)", "Player (Shock)", "Player (Hurt)", "Player (Attack)", "Enemy (Neutral)", "Enemy (Shock)", "Enemy (Hurt)", "Enemy (Attack)", "Stage Specific (A)", "StageSpecific ( B)", "Stace Specific (C)", "Stage Specific (D)" });
            CutInPanelPicker.Location = new Point(255, 264);
            CutInPanelPicker.Name = "CutInPanelPicker";
            CutInPanelPicker.Size = new Size(102, 23);
            CutInPanelPicker.TabIndex = 21;
            CutInPanelPicker.SelectedValueChanged += CutInPanelPicker_SelectedValueChanged;
            // 
            // Panel2DBehaviorCounter
            // 
            Panel2DBehaviorCounter.BackColor = SystemColors.Window;
            Panel2DBehaviorCounter.Location = new Point(255, 235);
            Panel2DBehaviorCounter.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            Panel2DBehaviorCounter.Minimum = new decimal(new int[] { int.MaxValue, 0, 0, int.MinValue });
            Panel2DBehaviorCounter.Name = "Panel2DBehaviorCounter";
            Panel2DBehaviorCounter.Size = new Size(102, 23);
            Panel2DBehaviorCounter.TabIndex = 20;
            Panel2DBehaviorCounter.ValueChanged += Panel2DBehaviorCounter_ValueChanged;
            // 
            // Panel2DIndexCounter
            // 
            Panel2DIndexCounter.BackColor = SystemColors.Window;
            Panel2DIndexCounter.Location = new Point(255, 206);
            Panel2DIndexCounter.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            Panel2DIndexCounter.Name = "Panel2DIndexCounter";
            Panel2DIndexCounter.Size = new Size(102, 23);
            Panel2DIndexCounter.TabIndex = 19;
            Panel2DIndexCounter.ValueChanged += Panel2DIndexCounter_ValueChanged;
            // 
            // BubblePosYCounter
            // 
            BubblePosYCounter.BackColor = SystemColors.Window;
            BubblePosYCounter.Location = new Point(255, 177);
            BubblePosYCounter.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            BubblePosYCounter.Minimum = new decimal(new int[] { int.MaxValue, 0, 0, int.MinValue });
            BubblePosYCounter.Name = "BubblePosYCounter";
            BubblePosYCounter.Size = new Size(102, 23);
            BubblePosYCounter.TabIndex = 18;
            BubblePosYCounter.ValueChanged += BubblePosYCounter_ValueChanged;
            // 
            // BubblePosXCounter
            // 
            BubblePosXCounter.BackColor = SystemColors.Window;
            BubblePosXCounter.Location = new Point(255, 148);
            BubblePosXCounter.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            BubblePosXCounter.Minimum = new decimal(new int[] { int.MaxValue, 0, 0, int.MinValue });
            BubblePosXCounter.Name = "BubblePosXCounter";
            BubblePosXCounter.Size = new Size(102, 23);
            BubblePosXCounter.TabIndex = 17;
            BubblePosXCounter.ValueChanged += BubblePosXCounter_ValueChanged;
            // 
            // StartFrameCounter
            // 
            StartFrameCounter.Location = new Point(255, 3);
            StartFrameCounter.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            StartFrameCounter.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            StartFrameCounter.Name = "StartFrameCounter";
            StartFrameCounter.Size = new Size(102, 23);
            StartFrameCounter.TabIndex = 1;
            StartFrameCounter.ValueChanged += StartFrameCounter_ValueChanged;
            // 
            // PropertiesGroup
            // 
            PropertiesGroup.Controls.Add(PropertiesTable);
            PropertiesGroup.Enabled = false;
            PropertiesGroup.Location = new Point(380, 27);
            PropertiesGroup.Name = "PropertiesGroup";
            PropertiesGroup.Size = new Size(366, 197);
            PropertiesGroup.TabIndex = 12;
            PropertiesGroup.TabStop = false;
            PropertiesGroup.Text = "Properties";
            // 
            // LineGrid
            // 
            LineGrid.AllowUserToOrderColumns = true;
            LineGrid.AllowUserToResizeColumns = false;
            LineGrid.BackgroundColor = SystemColors.ControlLight;
            LineGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LineGrid.Columns.AddRange(new DataGridViewColumn[] { LineColumn });
            LineGrid.Enabled = false;
            LineGrid.Location = new Point(6, 51);
            LineGrid.MultiSelect = false;
            LineGrid.Name = "LineGrid";
            LineGrid.RowHeadersVisible = false;
            LineGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            LineGrid.Size = new Size(350, 220);
            LineGrid.TabIndex = 14;
            LineGrid.CellEndEdit += LineGrid_CellEndEdit;
            LineGrid.SelectionChanged += LineGrid_SelectionChanged;
            LineGrid.UserAddedRow += LineGrid_UserAddedRow;
            // 
            // LineColumn
            // 
            LineColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LineColumn.HeaderText = "Line";
            LineColumn.Name = "LineColumn";
            LineColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // LineSelectionGroup
            // 
            LineSelectionGroup.Controls.Add(LineGroupRemove);
            LineSelectionGroup.Controls.Add(LineGroupAdd);
            LineSelectionGroup.Controls.Add(LineGroupPicker);
            LineSelectionGroup.Controls.Add(LineGrid);
            LineSelectionGroup.Enabled = false;
            LineSelectionGroup.Location = new Point(12, 27);
            LineSelectionGroup.Name = "LineSelectionGroup";
            LineSelectionGroup.Size = new Size(362, 277);
            LineSelectionGroup.TabIndex = 15;
            LineSelectionGroup.TabStop = false;
            LineSelectionGroup.Text = "Line Selection";
            // 
            // LineGroupRemove
            // 
            LineGroupRemove.Enabled = false;
            LineGroupRemove.Location = new Point(260, 22);
            LineGroupRemove.Name = "LineGroupRemove";
            LineGroupRemove.Size = new Size(96, 23);
            LineGroupRemove.TabIndex = 18;
            LineGroupRemove.Text = "Remove Group";
            LineGroupRemove.UseVisualStyleBackColor = true;
            LineGroupRemove.Click += LineGroupRemove_Click;
            // 
            // LineGroupAdd
            // 
            LineGroupAdd.Location = new Point(170, 22);
            LineGroupAdd.Name = "LineGroupAdd";
            LineGroupAdd.Size = new Size(84, 23);
            LineGroupAdd.TabIndex = 17;
            LineGroupAdd.Text = "Add Group";
            LineGroupAdd.UseVisualStyleBackColor = true;
            LineGroupAdd.Click += LineGroupAdd_Click;
            // 
            // LineGroupPicker
            // 
            LineGroupPicker.FormattingEnabled = true;
            LineGroupPicker.Location = new Point(6, 22);
            LineGroupPicker.Name = "LineGroupPicker";
            LineGroupPicker.Size = new Size(158, 23);
            LineGroupPicker.TabIndex = 15;
            LineGroupPicker.Text = "Select Line Group...";
            LineGroupPicker.SelectedIndexChanged += LineGroupPicker_SelectedIndexChanged;
            LineGroupPicker.SelectionChangeCommitted += LineGroupPicker_SelectionChangeCommitted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 315);
            Controls.Add(LineSelectionGroup);
            Controls.Add(PropertiesGroup);
            Controls.Add(RichTextInput);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EndFrameCounter).EndInit();
            PropertiesTable.ResumeLayout(false);
            PropertiesTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Panel2DBehaviorCounter).EndInit();
            ((System.ComponentModel.ISupportInitialize)Panel2DIndexCounter).EndInit();
            ((System.ComponentModel.ISupportInitialize)BubblePosYCounter).EndInit();
            ((System.ComponentModel.ISupportInitialize)BubblePosXCounter).EndInit();
            ((System.ComponentModel.ISupportInitialize)StartFrameCounter).EndInit();
            PropertiesGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LineGrid).EndInit();
            LineSelectionGroup.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem StripFile;
        private ToolStripMenuItem StripFileOpen;
        private RichTextBox RichTextInput;
        private Label EndFrameLabel;
        private NumericUpDown EndFrameCounter;
        private Label BubbleShapeLabel;
        private ComboBox BubbleShapePicker;
        private Label BubbleTailLabel;
        private ComboBox BubbleTailPicker;
        private Label BubblePositionLabel;
        private ComboBox BubblePositionPicker;
        private TableLayoutPanel PropertiesTable;
        private Label BubblePosXLabel;
        private Label BubblePosYLabel;
        private Label Panel2DIndexLabel;
        private NumericUpDown BubblePosXCounter;
        private NumericUpDown BubblePosYCounter;
        private NumericUpDown Panel2DIndexCounter;
        private GroupBox PropertiesGroup;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private DataGridView LineGrid;
        private GroupBox LineSelectionGroup;
        private ComboBox LineGroupPicker;
        private Button LineGroupRemove;
        private Button LineGroupAdd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem StripFileSave;
        private ToolStripMenuItem StripFileSaveAs;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem StripFileQuit;
        private DataGridViewTextBoxColumn LineColumn;
        private Label Panel2DBehaviorLabel;
        private Label CutInPanelLabel;
        private NumericUpDown Panel2DBehaviorCounter;
        private ComboBox CutInPanelPicker;
        private Label StartFrameLabel;
        private NumericUpDown StartFrameCounter;
        private Label CutInPositionLabel;
        private ComboBox CutInPositionPicker;
    }
}
