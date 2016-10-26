namespace DataLoadingAndReading
{
    partial class Main_Form
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
            this.t_header = new System.Windows.Forms.TextBox();
            this.b_loadData = new System.Windows.Forms.Button();
            this.l_startVal = new System.Windows.Forms.Label();
            this.l_numLines = new System.Windows.Forms.Label();
            this.n_start = new System.Windows.Forms.NumericUpDown();
            this.n_numLines = new System.Windows.Forms.NumericUpDown();
            this.b_partLoad = new System.Windows.Forms.Button();
            this.t_loadName = new System.Windows.Forms.TextBox();
            this.b_save = new System.Windows.Forms.Button();
            this.t_saveName = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lb_loadedData = new System.Windows.Forms.ListBox();
            this.lb_selectedData = new System.Windows.Forms.ListBox();
            this.ck_headerInLoad = new System.Windows.Forms.CheckBox();
            this.cb_headerInSave = new System.Windows.Forms.CheckBox();
            this.t_voter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.n_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_numLines)).BeginInit();
            this.SuspendLayout();
            // 
            // t_header
            // 
            this.t_header.Location = new System.Drawing.Point(67, 42);
            this.t_header.Multiline = true;
            this.t_header.Name = "t_header";
            this.t_header.Size = new System.Drawing.Size(132, 25);
            this.t_header.TabIndex = 1;
            this.t_header.TextChanged += new System.EventHandler(this.t_dataText_TextChanged);
            // 
            // b_loadData
            // 
            this.b_loadData.Location = new System.Drawing.Point(392, 14);
            this.b_loadData.Name = "b_loadData";
            this.b_loadData.Size = new System.Drawing.Size(75, 23);
            this.b_loadData.TabIndex = 2;
            this.b_loadData.Text = "Load data";
            this.b_loadData.UseVisualStyleBackColor = true;
            this.b_loadData.Click += new System.EventHandler(this.b_loadData_Click);
            // 
            // l_startVal
            // 
            this.l_startVal.AutoSize = true;
            this.l_startVal.Location = new System.Drawing.Point(93, 18);
            this.l_startVal.Name = "l_startVal";
            this.l_startVal.Size = new System.Drawing.Size(59, 13);
            this.l_startVal.TabIndex = 3;
            this.l_startVal.Text = "Start Value";
            // 
            // l_numLines
            // 
            this.l_numLines.AutoSize = true;
            this.l_numLines.Location = new System.Drawing.Point(223, 18);
            this.l_numLines.Name = "l_numLines";
            this.l_numLines.Size = new System.Drawing.Size(84, 13);
            this.l_numLines.TabIndex = 4;
            this.l_numLines.Text = "Number of Lines";
            // 
            // n_start
            // 
            this.n_start.Location = new System.Drawing.Point(158, 16);
            this.n_start.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.n_start.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_start.Name = "n_start";
            this.n_start.Size = new System.Drawing.Size(59, 20);
            this.n_start.TabIndex = 5;
            this.n_start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_start.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // n_numLines
            // 
            this.n_numLines.Location = new System.Drawing.Point(313, 16);
            this.n_numLines.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_numLines.Name = "n_numLines";
            this.n_numLines.Size = new System.Drawing.Size(60, 20);
            this.n_numLines.TabIndex = 6;
            this.n_numLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // b_partLoad
            // 
            this.b_partLoad.Location = new System.Drawing.Point(12, 13);
            this.b_partLoad.Name = "b_partLoad";
            this.b_partLoad.Size = new System.Drawing.Size(75, 23);
            this.b_partLoad.TabIndex = 7;
            this.b_partLoad.Text = "Load part";
            this.b_partLoad.UseVisualStyleBackColor = true;
            this.b_partLoad.Click += new System.EventHandler(this.b_partLoad_Click);
            // 
            // t_loadName
            // 
            this.t_loadName.Location = new System.Drawing.Point(473, 16);
            this.t_loadName.Name = "t_loadName";
            this.t_loadName.Size = new System.Drawing.Size(112, 20);
            this.t_loadName.TabIndex = 8;
            this.t_loadName.Text = "ics4u101_students.csv";
            this.t_loadName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(591, 14);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 23);
            this.b_save.TabIndex = 9;
            this.b_save.Text = "Save File";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // t_saveName
            // 
            this.t_saveName.Location = new System.Drawing.Point(672, 16);
            this.t_saveName.Name = "t_saveName";
            this.t_saveName.Size = new System.Drawing.Size(116, 20);
            this.t_saveName.TabIndex = 10;
            this.t_saveName.Text = "data.txt";
            this.t_saveName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 475);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(775, 18);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lb_loadedData
            // 
            this.lb_loadedData.FormattingEnabled = true;
            this.lb_loadedData.Location = new System.Drawing.Point(13, 74);
            this.lb_loadedData.Name = "lb_loadedData";
            this.lb_loadedData.Size = new System.Drawing.Size(373, 394);
            this.lb_loadedData.TabIndex = 12;
            this.lb_loadedData.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lb_selectedData
            // 
            this.lb_selectedData.FormattingEnabled = true;
            this.lb_selectedData.Location = new System.Drawing.Point(392, 74);
            this.lb_selectedData.Name = "lb_selectedData";
            this.lb_selectedData.Size = new System.Drawing.Size(396, 394);
            this.lb_selectedData.TabIndex = 13;
            this.lb_selectedData.SelectedIndexChanged += new System.EventHandler(this.lb_selectedData_SelectedIndexChanged);
            // 
            // ck_headerInLoad
            // 
            this.ck_headerInLoad.AutoSize = true;
            this.ck_headerInLoad.Location = new System.Drawing.Point(392, 49);
            this.ck_headerInLoad.Name = "ck_headerInLoad";
            this.ck_headerInLoad.Size = new System.Drawing.Size(162, 17);
            this.ck_headerInLoad.TabIndex = 15;
            this.ck_headerInLoad.Text = "Loaded data has header row";
            this.ck_headerInLoad.UseVisualStyleBackColor = true;
            // 
            // cb_headerInSave
            // 
            this.cb_headerInSave.AutoSize = true;
            this.cb_headerInSave.Location = new System.Drawing.Point(591, 49);
            this.cb_headerInSave.Name = "cb_headerInSave";
            this.cb_headerInSave.Size = new System.Drawing.Size(171, 17);
            this.cb_headerInSave.TabIndex = 16;
            this.cb_headerInSave.Text = "Save data with the header row";
            this.cb_headerInSave.UseVisualStyleBackColor = true;
            // 
            // t_voter
            // 
            this.t_voter.Location = new System.Drawing.Point(243, 42);
            this.t_voter.Multiline = true;
            this.t_voter.Name = "t_voter";
            this.t_voter.Size = new System.Drawing.Size(130, 25);
            this.t_voter.TabIndex = 17;
            this.t_voter.TextChanged += new System.EventHandler(this.t_voter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Header";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Voter";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_voter);
            this.Controls.Add(this.cb_headerInSave);
            this.Controls.Add(this.ck_headerInLoad);
            this.Controls.Add(this.lb_selectedData);
            this.Controls.Add(this.lb_loadedData);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.t_saveName);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.t_loadName);
            this.Controls.Add(this.b_partLoad);
            this.Controls.Add(this.n_numLines);
            this.Controls.Add(this.n_start);
            this.Controls.Add(this.l_numLines);
            this.Controls.Add(this.l_startVal);
            this.Controls.Add(this.b_loadData);
            this.Controls.Add(this.t_header);
            this.Name = "Main_Form";
            this.Text = "Data Loader";
            ((System.ComponentModel.ISupportInitialize)(this.n_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_numLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void t_dataText_TextChanged(object sender, System.EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.TextBox t_header;
        private System.Windows.Forms.Button b_loadData;
        private System.Windows.Forms.Label l_startVal;
        private System.Windows.Forms.Label l_numLines;
        private System.Windows.Forms.NumericUpDown n_start;
        private System.Windows.Forms.NumericUpDown n_numLines;
        private System.Windows.Forms.Button b_partLoad;
        private System.Windows.Forms.TextBox t_loadName;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.TextBox t_saveName;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox lb_loadedData;
        private System.Windows.Forms.ListBox lb_selectedData;
        private System.Windows.Forms.CheckBox ck_headerInLoad;
        private System.Windows.Forms.CheckBox cb_headerInSave;
        private System.Windows.Forms.TextBox t_voter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

